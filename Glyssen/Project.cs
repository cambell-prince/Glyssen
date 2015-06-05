﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DesktopAnalytics;
using Glyssen.Analysis;
using Glyssen.Bundle;
using Glyssen.Character;
using Glyssen.Dialogs;
using Glyssen.Properties;
using Glyssen.Quote;
using Glyssen.Utilities;
using L10NSharp;
using Paratext;
using SIL.DblBundle;
using SIL.DblBundle.Text;
using SIL.DblBundle.Usx;
using SIL.IO;
using SIL.Reporting;
using SIL.ScriptureUtils;
using SIL.Windows.Forms.FileSystem;
using SIL.WritingSystems;
using SIL.Xml;

namespace Glyssen
{
	public class Project
	{
		public const string kProjectFileExtension = ".glyssen";
		private const string kBookScriptFileExtension = ".xml";
		public const string kProjectCharacterVerseFileName = "ProjectCharacterVerse.txt";
		private const string kSample = "sample";
		private const string kSampleProjectName = "Sample Project";

		private const double kUsxPercent = 0.25;
		private const double kGuessPercent = 0.10;
		private const double kQuotePercent = 0.65;

		private readonly GlyssenDblTextMetadata m_metadata;
		private readonly List<BookScript> m_books = new List<BookScript>();
		private readonly Paratext.ScrVers m_vers;
		private string m_recordingProjectName;
		private int m_usxPercentComplete;
		private int m_guessPercentComplete;
		private int m_quotePercentComplete;
		private ProjectState m_projectState;
		private ProjectAnalysis m_analysis;
		private WritingSystemDefinition m_wsDefinition;
		private IWritingSystemRepository m_wsRepository;

		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		public event EventHandler<ProjectStateChangedEventArgs> ProjectStateChanged;
		public event EventHandler AnalysisCompleted;

		private Project(GlyssenDblTextMetadata metadata, string recordingProjectName = null)
		{
			m_metadata = metadata;
			m_recordingProjectName = recordingProjectName ?? GetDefaultRecordingProjectName(m_metadata.Identification.Name);
			ProjectCharacterVerseData = new ProjectCharacterVerseData(ProjectCharacterVerseDataPath);
			if (m_metadata.QuoteSystem == null)
				LoadWritingSystem();
			if (File.Exists(VersificationFilePath))
				m_vers = LoadVersification(VersificationFilePath);
		}

		public Project(GlyssenBundle bundle, string recordingProjectName = null, Project projectBeingUpdated = null) :
			this(bundle.Metadata, recordingProjectName)
		{
			Directory.CreateDirectory(ProjectFolder);
			bundle.CopyVersificationFile(VersificationFilePath);
			try
			{
				m_vers = LoadVersification(VersificationFilePath);
			}
			catch (InvalidVersificationLineException)
			{
				DeleteProjectFolderAndEmptyContainingFolders(ProjectFolder);
				throw;
			}
			UserDecisionsProject = projectBeingUpdated;
			PopulateAndParseBooks(bundle);
		}

		/// <summary>
		/// Used only for sample project and in tests.
		/// </summary>
		public Project(GlyssenDblTextMetadata metadata, IEnumerable<UsxDocument> books, IStylesheet stylesheet) : this(metadata)
		{
			AddAndParseBooks(books, stylesheet);

			Directory.CreateDirectory(ProjectFolder);
			File.WriteAllText(VersificationFilePath, Resources.EnglishVersification);
			m_vers = LoadVersification(VersificationFilePath);
		}

		private static string ProjectsBaseFolder
		{
			get
			{
				return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
					Program.kCompany, Program.kProduct);
			}
		}

		public static IEnumerable<string> AllPublicationFolders
		{
			get
			{
				return Directory.GetDirectories(ProjectsBaseFolder).SelectMany(Directory.GetDirectories);
			}
		}

		public static IEnumerable<string> AllRecordingProjectFolders
		{
			get 
			{
				return AllPublicationFolders.SelectMany(Directory.GetDirectories);
			}
		}

		public string Id
		{
			get { return m_metadata.Id; }
		}

		public string Name
		{
			get { return m_recordingProjectName; }
		}

		public string PublicationName
		{
			get { return m_metadata.Identification == null ? null : m_metadata.Identification.Name; }
		}

		public string LanguageIsoCode
		{
			get { return m_metadata.Language.Iso; }
		}

		public string LanguageName
		{
			get { return m_metadata.Language.Name; }
		}

		public string FontFamily
		{
			get { return m_metadata.FontFamily; }
		}

		public int FontSizeInPoints
		{
			get { return m_metadata.FontSizeInPoints; }
		}

		public int FontSizeUiAdjustment
		{
			get { return m_metadata.FontSizeUiAdjustment; }
			set { m_metadata.FontSizeUiAdjustment = value; }
		}

		public bool RightToLeftScript
		{
			get { return m_metadata.Language.ScriptDirection == "RTL"; }
		}

		public Paratext.ScrVers Versification
		{
			get  { return m_vers; }
		}

		public static Paratext.ScrVers LoadVersification(string vrsPath)
		{
			return Paratext.Versification.Table.Load(vrsPath, LocalizationManager.GetString("Project.DefaultCustomVersificationName",
				"custom", "Used as the versification name when a the versification file does not contain a name."));
		}

		public ProjectStatus Status
		{
			get { return m_metadata.ProjectStatus; }
		}

		public ProjectAnalysis ProjectAnalysis
		{
			get { return m_analysis ?? (m_analysis = new ProjectAnalysis(this)); }
		}

		public QuoteSystem QuoteSystem
		{
			get
			{
				if (m_metadata.QuoteSystem != null && m_metadata.QuoteSystem.AllLevels.Any())
					return m_metadata.QuoteSystem;
				return null;
			}
			set
			{
				bool quoteSystemBeingSetForFirstTime = QuoteSystem == null;
				bool quoteSystemChanged = m_metadata.QuoteSystem != value;

				if (IsQuoteSystemReadyForParse && ProjectState == ProjectState.NeedsQuoteSystemConfirmation)
				{
					m_metadata.QuoteSystem = value;
					DoQuoteParse();
				}
				else if (quoteSystemChanged && !quoteSystemBeingSetForFirstTime)
				{
					// These need to happen in this order
					Save();
					CreateBackup("Backup before quote system change");
					m_metadata.QuoteSystem = value;
					HandleQuoteSystemChanged();
				}
				else
				{
					m_metadata.QuoteSystem = value;
				}
			}
		}

		public QuoteSystemStatus QuoteSystemStatus
		{
			get { return m_metadata.ProjectStatus.QuoteSystemStatus; }
			set { m_metadata.ProjectStatus.QuoteSystemStatus = value; }
		}

		public bool IsQuoteSystemReadyForParse { get { return (QuoteSystemStatus & QuoteSystemStatus.ParseReady) != 0; } }

		public DateTime QuoteSystemDate
		{
			get { return m_metadata.ProjectStatus.QuoteSystemDate; }
		}

		public BookSelectionStatus BookSelectionStatus
		{
			get { return m_metadata.ProjectStatus.BookSelectionStatus; }
			set { m_metadata.ProjectStatus.BookSelectionStatus = value; }
		}

		public ProjectSettingsStatus ProjectSettingsStatus
		{
			get { return m_metadata.ProjectStatus.ProjectSettingsStatus; }
			set { m_metadata.ProjectStatus.ProjectSettingsStatus = value; }
		}

		public IReadOnlyList<BookScript> Books { get { return m_books; } }

		public IReadOnlyList<BookScript> IncludedBooks
		{
			get
			{
				return (from book in Books 
						where AvailableBooks.Where(ab => ab.IncludeInScript).Select(ab => ab.Code).Contains(book.BookId)
						select book).ToList();
			}
		}

		public IReadOnlyList<Book> AvailableBooks
		{ 
			get
			{ 
				return m_metadata.AvailableBooks.Where(b =>
				{
					var bookNum = BCVRef.BookToNumber(b.Code);
					return bookNum >= 1 && bookNum <= BCVRef.LastBook;
				}).ToList(); 
			} 
		}

		public string OriginalBundlePath
		{
			get { return m_metadata.OriginalPathBundlePath; }
			set { m_metadata.OriginalPathBundlePath = value; }
		}

		public readonly ProjectCharacterVerseData ProjectCharacterVerseData;

		public void UpdateSettings(ProjectMetadataViewModel model)
		{
			var newPath = GetProjectFolderPath(model.IsoCode, model.PublicationId, model.RecordingProjectName);
			if (newPath != ProjectFolder)
			{
				Directory.Move(ProjectFolder, newPath);
				m_recordingProjectName = model.RecordingProjectName;
				m_wsRepository = null;
			}
			m_metadata.FontFamily = model.WsModel.CurrentDefaultFontName;
			m_metadata.FontSizeInPoints = (int) model.WsModel.CurrentDefaultFontSize;
			m_metadata.Language.ScriptDirection = model.WsModel.CurrentRightToLeftScript ? "RTL" : "LTR";
		}

		public Project UpdateProjectFromBundleData(GlyssenBundle bundle)
		{
			// If we're updating the projectb in place, we need to make a backup. Otherwise, if it's moving to a new
			// location, just mark the existing one as inactive.
			bool moving = (ProjectFilePath != GetProjectFilePath(bundle.LanguageIso, bundle.Id, m_recordingProjectName));
			if (moving)
				m_metadata.Inactive = true;
			Save();
			if (!moving)
				CreateBackup("Backup before updating from new bundle");

			bundle.Metadata.CopyGlyssenModifiableSettings(m_metadata);

			return new Project(bundle, m_recordingProjectName);
		}

		private int PercentInitialized { get; set; }

		public ProjectState ProjectState
		{
			get { return m_projectState; }
			private set
			{
				if (m_projectState == value)
					return;
				m_projectState = value;
				if (ProjectStateChanged != null)
					ProjectStateChanged(this, new ProjectStateChangedEventArgs { ProjectState = m_projectState });
			}
		}

		public string ProjectSummary
		{
			get
			{
				var sb = new StringBuilder(Name);
				if (!string.IsNullOrEmpty(m_metadata.Language.Name))
					sb.Append(", ").Append(m_metadata.Language.Name);
				if (!string.IsNullOrEmpty(LanguageIsoCode))
					sb.Append(" (").Append(LanguageIsoCode).Append(")");
				if (!string.IsNullOrEmpty(PublicationName))
					sb.Append(", ").Append(PublicationName);
				if (!string.IsNullOrEmpty(Id))
					sb.Append(" (").Append(Id).Append(")");
				return sb.ToString();
			}
		}

		public string SettingsSummary
		{
			get
			{
				var sb = new StringBuilder(QuoteSystem.ToString());
				sb.Append(", ").Append(FontFamily);
				sb.Append(", ").Append(FontSizeInPoints).Append(LocalizationManager.GetString("WritingSystem.Points", "pt", "Units appended to font size to represent points"));
				sb.Append(", ").Append(RightToLeftScript ? LocalizationManager.GetString("WritingSystem.RightToLeft", "Right-to-left", "Describes a writing system") :
					LocalizationManager.GetString("WritingSystem.LeftToRight", "Left-to-right", "Describes a writing system"));
				return sb.ToString();
			}
		}

		public string BookSelectionSummary { get { return IncludedBooks.BookSummary(); } }

		/// <summary>
		/// If this is set, the user decisions in it will be applied when the quote parser is done
		/// </summary>
		private Project UserDecisionsProject { get; set; }

		internal void ClearAssignCharacterStatus()
		{
			Status.AssignCharacterMode = BlocksToDisplay.NeedAssignments;
			Status.AssignCharacterBlock = new BookBlockIndices();
		}

		public static Project Load(string projectFilePath)
		{
			Project existingProject = LoadExistingProject(projectFilePath);

			if (!existingProject.IsSampleProject && existingProject.m_metadata.ParserVersion != Settings.Default.ParserVersion)
			{
				bool upgradeProject = true;
				if (!File.Exists(existingProject.OriginalBundlePath))
				{
					upgradeProject = false;
					if (Settings.Default.ParserVersion > existingProject.m_metadata.ParserUpgradeOptOutVersion)
					{
						string msg = string.Format(LocalizationManager.GetString("Project.ParserUpgradeBundleMissingMsg", "The splitting engine has been upgraded. To make use of the new engine, the original text bundle must be available, but it is not in the original location ({0})."), existingProject.OriginalBundlePath) +
							Environment.NewLine + Environment.NewLine + 
							LocalizationManager.GetString("Project.LocateBundleYourself", "Would you like to locate the text bundle yourself?");
						string caption = LocalizationManager.GetString("Project.UnableToLocateTextBundle", "Unable to Locate Text Bundle");
						if (DialogResult.Yes == MessageBox.Show(msg, caption, MessageBoxButtons.YesNo))
							upgradeProject = SelectProjectDlg.GiveUserChanceToFindOriginalBundle(existingProject);
						if (!upgradeProject)
							existingProject.m_metadata.ParserUpgradeOptOutVersion = Settings.Default.ParserVersion;
					}
				}
				if (upgradeProject)
				{
					using (var bundle = new GlyssenBundle(existingProject.OriginalBundlePath))
					{
						var upgradedProject = new Project(existingProject.m_metadata, existingProject.m_recordingProjectName);

						Analytics.Track("UpgradeProject", new Dictionary<string, string>
						{
							{"language", existingProject.LanguageIsoCode},
							{"ID", existingProject.Id},
							{"recordingProjectName", existingProject.Name},
							{"oldParserVersion", existingProject.m_metadata.ParserVersion.ToString(CultureInfo.InvariantCulture)},
							{"newParserVersion", Settings.Default.ParserVersion.ToString(CultureInfo.InvariantCulture)}
						});

						upgradedProject.UserDecisionsProject = existingProject;
						upgradedProject.PopulateAndParseBooks(bundle);
						upgradedProject.m_metadata.ParserVersion = Settings.Default.ParserVersion;
						return upgradedProject;
					}
				}
			}

			existingProject.InitializeLoadedProject();
			return existingProject;
		}

		public static void SetHiddenFlag(string projectFilePath, bool hidden)
		{
			Exception exception;
			var metadata = GlyssenDblTextMetadata.Load<GlyssenDblTextMetadata>(projectFilePath, out exception);
			if (exception != null)
			{
				ErrorReport.ReportNonFatalExceptionWithMessage(exception,
					LocalizationManager.GetString("File.ProjectCouldNotBeModified", "Project could not be modified: {0}"), projectFilePath);
				return;
			}
			metadata.Inactive = hidden;
			new Project(metadata, GetRecordingProjectNameFromProjectFilePath(projectFilePath)).Save();
		}

		public static void DeleteProjectFolderAndEmptyContainingFolders(string projectFolder, bool confirmAndRecycle = false)
		{
			if (confirmAndRecycle)
			{
				if (!ConfirmRecycleDialog.ConfirmThenRecycle(string.Format("Standard format project \"{0}\"", projectFolder), projectFolder))
					return;
			}
			else if (Directory.Exists(projectFolder))
				Directory.Delete(projectFolder, true);
			var parent = Path.GetDirectoryName(projectFolder);
			if (Directory.Exists(parent) && !Directory.GetFileSystemEntries(parent).Any())
				Directory.Delete(parent);
			parent = Path.GetDirectoryName(parent);
			if (Directory.Exists(parent) && !Directory.GetFileSystemEntries(parent).Any())
				Directory.Delete(parent);
		}

		private static string GetRecordingProjectNameFromProjectFilePath(string path)
		{
			return Path.GetFileName(Path.GetDirectoryName(path));
		}

		private int UpdatePercentInitialized()
		{
			return PercentInitialized = (int)(m_usxPercentComplete * kUsxPercent + m_guessPercentComplete * kGuessPercent + m_quotePercentComplete * kQuotePercent);
		}

		private static Project LoadExistingProject(string projectFilePath)
		{
			Exception exception;
			var metadata = GlyssenDblTextMetadata.Load<GlyssenDblTextMetadata>(projectFilePath, out exception);
			if (exception != null)
			{
				ErrorReport.ReportNonFatalExceptionWithMessage(exception,
					LocalizationManager.GetString("File.ProjectMetadataInvalid", "Project could not be loaded: {0}"), projectFilePath);
				return null;
			}
			Project project = new Project(metadata, GetRecordingProjectNameFromProjectFilePath(projectFilePath));
			var projectDir = Path.GetDirectoryName(projectFilePath);
			Debug.Assert(projectDir != null);
			string[] files = Directory.GetFiles(projectDir, "???" + kBookScriptFileExtension);
			for (int i = 1; i <= BCVRef.LastBook; i++)
			{
				string bookCode = BCVRef.NumberToBookCode(i);
				string possibleFileName = Path.Combine(projectDir, bookCode + kBookScriptFileExtension);
				if (files.Contains(possibleFileName))
					project.m_books.Add(XmlSerializationHelper.DeserializeFromFile<BookScript>(possibleFileName));
			}
			return project;
		}

		private void InitializeLoadedProject()
		{
			LoadWritingSystem();

			m_usxPercentComplete = 100;
			int controlFileVersion = ControlCharacterVerseData.Singleton.ControlFileVersion;
			if (QuoteSystem == null)
			{
				GuessAtQuoteSystem();
				m_metadata.ControlFileVersion = controlFileVersion;
				return;
			}
			m_guessPercentComplete = 100;

			if (IsSampleProject)
			{
				ProjectSettingsStatus = ProjectSettingsStatus.Reviewed;
				QuoteSystemStatus = QuoteSystemStatus.Obtained;
				BookSelectionStatus = BookSelectionStatus.Reviewed;
			}

			if (!IsQuoteSystemReadyForParse)
			{
				m_quotePercentComplete = 0;
				UpdatePercentInitialized();
				ProjectState = ProjectState.NeedsQuoteSystemConfirmation;
				return;
			}
			m_quotePercentComplete = 100;
			if (m_metadata.ControlFileVersion != controlFileVersion)
			{
				new CharacterAssigner(new CombinedCharacterVerseData(this)).AssignAll(m_books, Versification);
				m_metadata.ControlFileVersion = controlFileVersion;
			}
			UpdatePercentInitialized();
			ProjectState = ProjectState.FullyInitialized;
			Analyze();
		}

		private void ApplyUserDecisions(Project sourceProject)
		{
			foreach (var targetBookScript in m_books)
			{
				BookScript script = targetBookScript;
				var sourceBookScript = sourceProject.m_books.SingleOrDefault(b => b.BookId == script.BookId);
				if (sourceBookScript != null)
					targetBookScript.ApplyUserDecisions(sourceBookScript);
			}
			Analyze();
		}

		private void PopulateAndParseBooks(ITextBundle bundle)
		{
			AddAndParseBooks(GetUsxBooksToInclude(bundle), bundle.Stylesheet);
		}

		private IEnumerable<UsxDocument> GetUsxBooksToInclude(ITextBundle bundle)
		{
			foreach (var book in AvailableBooks.Where(b => b.IncludeInScript))
			{
				UsxDocument usxBook;
				if (bundle.TryGetBook(book.Code, out usxBook))
					yield return usxBook;
			}
		}

		private void AddAndParseBooks(IEnumerable<UsxDocument> books, IStylesheet stylesheet)
		{
			ProjectState = ProjectState.Initial;
			var usxWorker = new BackgroundWorker { WorkerReportsProgress = true };
			usxWorker.DoWork += UsxWorker_DoWork;
			usxWorker.RunWorkerCompleted += UsxWorker_RunWorkerCompleted;
			usxWorker.ProgressChanged += UsxWorker_ProgressChanged;

			object[] parameters = { books, stylesheet };
			usxWorker.RunWorkerAsync(parameters);
		}

		private void UsxWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			var parameters = (object[])e.Argument;
			var books = (IEnumerable<UsxDocument>)parameters[0];
			var stylesheet = (IStylesheet)parameters[1];

			e.Result = UsxParser.ParseProject(books, stylesheet, sender as BackgroundWorker);
		}

		private void UsxWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
				throw e.Error;
			
			var result = (IEnumerable<BookScript>)e.Result;
			//REVIEW: more efficient to sort after the fact like this?  Or just don't run them in parallel (in ProjectUsxParser) in the first place?
			var resultList = result.ToList();
			resultList.Sort((a, b) => BCVRef.BookToNumber(a.BookId).CompareTo(BCVRef.BookToNumber(b.BookId)));
			m_books.AddRange(resultList);
			m_metadata.ParserVersion = Settings.Default.ParserVersion;
			m_metadata.ControlFileVersion = ControlCharacterVerseData.Singleton.ControlFileVersion;

			if (QuoteSystem == null)
				GuessAtQuoteSystem();
			else if (IsQuoteSystemReadyForParse)
				DoQuoteParse();
		}

		private void UsxWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			m_usxPercentComplete = e.ProgressPercentage;
			var pe = new ProgressChangedEventArgs(UpdatePercentInitialized(), null);
			OnReport(pe);
		}

		private void GuessAtQuoteSystem()
		{
			ProjectState = ProjectState.UsxComplete;
			var guessWorker = new BackgroundWorker { WorkerReportsProgress = true };
			guessWorker.DoWork += GuessWorker_DoWork;
			guessWorker.RunWorkerCompleted += GuessWorker_RunWorkerCompleted;
			guessWorker.ProgressChanged += GuessWorker_ProgressChanged;
			guessWorker.RunWorkerAsync();
		}

		private void GuessWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			bool certain;
			e.Result = QuoteSystemGuesser.Guess(ControlCharacterVerseData.Singleton, m_books, Versification, out certain, sender as BackgroundWorker);
		}

		private void GuessWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
				throw e.Error;

			QuoteSystemStatus = QuoteSystemStatus.Guessed;
			QuoteSystem = (QuoteSystem)e.Result;
			
			Save();
		}

		private void GuessWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			m_guessPercentComplete = e.ProgressPercentage;
			var pe = new ProgressChangedEventArgs(UpdatePercentInitialized(), null);
			OnReport(pe);
		}

		private void DoQuoteParse()
		{
			ProjectState = ProjectState.GuessComplete;
			var quoteWorker = new BackgroundWorker { WorkerReportsProgress = true };
			quoteWorker.DoWork += QuoteWorker_DoWork;
			quoteWorker.RunWorkerCompleted += QuoteWorker_RunWorkerCompleted;
			quoteWorker.ProgressChanged += QuoteWorker_ProgressChanged;
			quoteWorker.RunWorkerAsync();
		}

		private void QuoteWorker_DoWork(object sender, DoWorkEventArgs doWorkEventArgs)
		{
			QuoteParser.ParseProject(this, sender as BackgroundWorker);
		}

		private void QuoteWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				Debug.WriteLine(e.Error.InnerException.Message + e.Error.InnerException.StackTrace);
				throw e.Error;
			}

			m_metadata.ControlFileVersion = ControlCharacterVerseData.Singleton.ControlFileVersion;
			if (UserDecisionsProject != null)
			{
				ApplyUserDecisions(UserDecisionsProject);
				UserDecisionsProject = null;
			}
			else
				Analyze();

			Save();
		}

		private void QuoteWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			m_quotePercentComplete = e.ProgressPercentage;
			var pe = new ProgressChangedEventArgs(UpdatePercentInitialized(), null);
			OnReport(pe);
		}

		public static string GetProjectFilePath(string langId, string publicationId, string recordingProjectId)
		{
			return Path.Combine(GetProjectFolderPath(langId, publicationId, recordingProjectId), langId + kProjectFileExtension);
		}

		public static string GetDefaultProjectFilePath(IBundle bundle)
		{
			return GetProjectFilePath(bundle.LanguageIso, bundle.Id, GetDefaultRecordingProjectName(bundle));
		}

		public static string GetProjectFolderPath(string langId, string publicationId, string recordingProjectId)
		{
			return Path.Combine(ProjectsBaseFolder, langId, publicationId, recordingProjectId);
		}

		public static string GetPublicationFolderPath(IBundle bundle)
		{
			return Path.Combine(ProjectsBaseFolder, bundle.LanguageIso, bundle.Id);
		}

		public string ProjectFilePath
		{
			get { return GetProjectFilePath(m_metadata.Language.Iso, m_metadata.Id, m_recordingProjectName); }
		}

		private string ProjectCharacterVerseDataPath
		{
			get { return Path.Combine(ProjectFolder, kProjectCharacterVerseFileName); }
		}

		private string VersificationFilePath
		{
			get { return Path.Combine(ProjectFolder, DblBundleFileUtils.kVersificationFileName); }
		}

		private string ProjectFolder
		{
			get { return GetProjectFolderPath(m_metadata.Language.Iso, m_metadata.Id, m_recordingProjectName); }
		}

		public void Analyze()
		{
			ProjectAnalysis.AnalyzeQuoteParse();

			Analytics.Track("ProjectAnalysis", new Dictionary<string, string>
			{
				{ "language", LanguageIsoCode },
				{ "ID", Id },
				{ "recordingProjectName", Name },
				{ "TotalBlocks", ProjectAnalysis.TotalBlocks.ToString(CultureInfo.InvariantCulture) },
				{ "UserPercentAssigned", ProjectAnalysis.UserPercentAssigned.ToString(CultureInfo.InvariantCulture) },
				{ "TotalPercentAssigned", ProjectAnalysis.TotalPercentAssigned.ToString(CultureInfo.InvariantCulture) },
				{ "PercentUnknown", ProjectAnalysis.PercentUnknown.ToString(CultureInfo.InvariantCulture) }
			});
			
			if (AnalysisCompleted != null)
				AnalysisCompleted(this, new EventArgs());
		}

		public void Save()
		{
			Directory.CreateDirectory(ProjectFolder);

			var projectPath = ProjectFilePath;
			Exception error;
			XmlSerializationHelper.SerializeToFile(projectPath, m_metadata, out error);
			if (error != null)
			{
				MessageBox.Show(error.Message);
				return;
			}
			Settings.Default.CurrentProject = projectPath;
			foreach (var book in m_books)
				SaveBook(book);
			SaveProjectCharacterVerseData();
			SaveWritingSystem();
			ProjectState = !IsQuoteSystemReadyForParse ? ProjectState.NeedsQuoteSystemConfirmation : ProjectState.FullyInitialized;
		}

		public void SaveBook(BookScript book)
		{
			Exception error;
			XmlSerializationHelper.SerializeToFile(Path.ChangeExtension(Path.Combine(ProjectFolder, book.BookId), "xml"), book, out error);
			if (error != null)
				MessageBox.Show(error.Message);
		}

		public void SaveProjectCharacterVerseData()
		{
			ProjectCharacterVerseData.WriteToFile(ProjectCharacterVerseDataPath);
		}

		public WritingSystemDefinition WritingSystem
		{
			get
			{
				if (m_wsDefinition != null)
					return m_wsDefinition;

				string languagecode = LanguageIsoCode;
				if (!IetfLanguageTag.IsValid(languagecode))
					languagecode = WellKnownSubtags.UnlistedLanguage;

				if (!WritingSystemRepository.TryGet(languagecode, out m_wsDefinition))
					m_wsDefinition = new WritingSystemDefinition(languagecode);

				WritingSystemRepository.Set(m_wsDefinition);
				return m_wsDefinition;
			}
		}

		private void SaveWritingSystem()
		{
			WritingSystemDefinition ws = WritingSystem;
			ws.QuotationMarks.Clear();
			if (QuoteSystem != null)
				ws.QuotationMarks.AddRange(QuoteSystem.AllLevels);

			WritingSystemRepository.Save();
		}

		private void LoadWritingSystem()
		{
			// TODO (PG-230): Here or maybe somewhere else, we need to set the quote status to Obtained if we get it from the bundle.
			WritingSystemDefinition ws = WritingSystem;
			if (m_metadata.QuoteSystem == null)
				m_metadata.QuoteSystem = new QuoteSystem();

			// If we read in the quote data from the metadata (where it used to be stored)
			// and haven't created the LDML file yet, don't blow away the old data yet
			if (ws.QuotationMarks.Any())
			{
				m_metadata.QuoteSystem.AllLevels.Clear();
				m_metadata.QuoteSystem.AllLevels.AddRange(ws.QuotationMarks);
			}
		}

		public void ExportTabDelimited(string fileName)
		{
			int blockNumber = 1;
			using (var stream = new StreamWriter(fileName, false, Encoding.UTF8))
			{
				foreach (var book in IncludedBooks)
				{
					foreach (var block in book.GetScriptBlocks(true))
					{
						stream.WriteLine((blockNumber++) + "\t" + block.GetAsTabDelimited(book.BookId));
					}
				}
			}
		}

		private void HandleQuoteSystemChanged()
		{
			Project copyOfExistingProject = new Project(m_metadata, Name);
			copyOfExistingProject.m_books.AddRange(m_books);

			m_books.Clear();

			if (File.Exists(OriginalBundlePath) && QuoteSystem != null)
			{
				UserDecisionsProject = copyOfExistingProject;
				using (var bundle = new GlyssenBundle(OriginalBundlePath))
					PopulateAndParseBooks(bundle);
			}
			else
			{
				// This is prevented by logic elsewhere
				throw new ApplicationException();
			}
		}

		private void CreateBackup(string textToAppendToRecordingProjectName, bool hidden = true)
		{
			if (!m_books.Any(b => b.GetScriptBlocks().Any(sb => sb.UserConfirmed)))
				return;
			string newDirectoryPath = GetProjectFolderPath(LanguageIsoCode, Id, Name + " - " + textToAppendToRecordingProjectName);
			if (Directory.Exists(newDirectoryPath))
			{
				string fmt = newDirectoryPath + " ({0})";
				int n = 1;
				do
				{
					newDirectoryPath = String.Format(fmt, n++);
				} while (Directory.Exists(newDirectoryPath));
			}
			DirectoryUtilities.CopyDirectoryContents(ProjectFolder, newDirectoryPath);
			if (hidden)
			{
				var newFilePath = Directory.GetFiles(newDirectoryPath, "*" + kProjectFileExtension).FirstOrDefault();
				if (newFilePath != null)
					SetHiddenFlag(newFilePath, true);
			}
		}

		private IWritingSystemRepository WritingSystemRepository
		{
			get
			{
				if (m_wsRepository != null)
					return m_wsRepository;
				if (!Directory.Exists(ProjectFolder))
					Directory.CreateDirectory(ProjectFolder);
				return m_wsRepository = LdmlInFolderWritingSystemRepository.Initialize(FileSystemUtils.GetShortName(ProjectFolder));
			}
		}

		public bool IsReparseOkay()
		{
			if (QuoteSystem == null)
				return false;
			if (File.Exists(OriginalBundlePath))
				return true;
			return false;
		}

		private void OnReport(ProgressChangedEventArgs e)
		{
			if (ProgressChanged != null)
				ProgressChanged(this, e);
		}

		public bool IsSampleProject
		{
			get { return Id.Equals(kSample, StringComparison.OrdinalIgnoreCase) && LanguageIsoCode == kSample; }
		}

		public static string SampleProjectFilePath
		{
			get { return GetProjectFilePath(kSample, kSample, GetDefaultRecordingProjectName(kSampleProjectName)); }
		}

		public static void CreateSampleProjectIfNeeded()
		{
			if (File.Exists(SampleProjectFilePath))
				return;
			var sampleMetadata = new GlyssenDblTextMetadata();
			sampleMetadata.AvailableBooks = new List<Book>();
			var bookOfMark = new Book();
			bookOfMark.Code = "MRK";
			bookOfMark.IncludeInScript = true;
			bookOfMark.LongName = "Gospel of Mark";
			bookOfMark.ShortName = "Mark";
			sampleMetadata.AvailableBooks.Add(bookOfMark);
			sampleMetadata.FontFamily = "Times New Roman";
			sampleMetadata.FontSizeInPoints = 12;
			sampleMetadata.Id = kSample;
			sampleMetadata.Language = new GlyssenDblMetadataLanguage {Iso = kSample};
			sampleMetadata.Identification = new DblMetadataIdentification { Name = kSampleProjectName, NameLocal = kSampleProjectName};
			sampleMetadata.ProjectStatus.ProjectSettingsStatus = ProjectSettingsStatus.Reviewed;
			sampleMetadata.ProjectStatus.QuoteSystemStatus = QuoteSystemStatus.Obtained;
			sampleMetadata.ProjectStatus.BookSelectionStatus = BookSelectionStatus.Reviewed;
			sampleMetadata.QuoteSystem = GetSampleQuoteSystem();

			XmlDocument sampleMark = new XmlDocument();
			sampleMark.LoadXml(Resources.SampleMRK);
			UsxDocument mark = new UsxDocument(sampleMark);

			new Project(sampleMetadata, new[] { mark }, SfmLoader.GetUsfmStylesheet());
		}

		private static QuoteSystem GetSampleQuoteSystem()
		{
			QuoteSystem sampleQuoteSystem = new QuoteSystem();
			sampleQuoteSystem.AllLevels.Add(new QuotationMark("“", "”", "“", 1, QuotationMarkingSystemType.Normal));
			sampleQuoteSystem.AllLevels.Add(new QuotationMark("‘", "’", "“‘", 2, QuotationMarkingSystemType.Normal));
			sampleQuoteSystem.AllLevels.Add(new QuotationMark("“", "”", "“‘“", 3, QuotationMarkingSystemType.Normal));
			return sampleQuoteSystem;
		}

		internal static string GetDefaultRecordingProjectName(string publicationName)
		{
			return String.Format("{0} {1}", publicationName, LocalizationManager.GetString("Project.RecordingProjectDefaultSuffix", "Audio"));
		}

		internal static string GetDefaultRecordingProjectName(IBundle bundle)
		{
			return GetDefaultRecordingProjectName(bundle.Name);
		}
	}

	public class ProjectStateChangedEventArgs : EventArgs
	{
		public ProjectState ProjectState { get; set; }
	}

	[Flags]
	public enum ProjectState
	{
		Initial = 1,
		UsxComplete = 2,
		GuessComplete = 4,
		NeedsQuoteSystemConfirmation = 8,
		QuoteParseComplete = 16,
		FullyInitialized = 32,
		ReadyForUserInteraction = NeedsQuoteSystemConfirmation | FullyInitialized
	}
}