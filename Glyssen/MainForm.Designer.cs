﻿namespace Glyssen
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.m_L10NSharpExtender = new L10NSharp.UI.L10NSharpExtender(this.components);
			this.m_toolStrip = new System.Windows.Forms.ToolStrip();
			this.m_btnAbout = new System.Windows.Forms.ToolStripButton();
			this.m_uiLanguageMenu = new System.Windows.Forms.ToolStripDropDownButton();
			this.m_lastExportLocationLink = new System.Windows.Forms.LinkLabel();
			this.m_lnkExit = new System.Windows.Forms.LinkLabel();
			this.m_btnOpenProject = new System.Windows.Forms.Button();
			this.m_imgCheckOpen = new System.Windows.Forms.PictureBox();
			this.m_lblActorsAssigned = new System.Windows.Forms.Label();
			this.m_imgCheckAssignActors = new System.Windows.Forms.PictureBox();
			this.m_lblProjectInfo = new System.Windows.Forms.Label();
			this.m_imgCheckSettings = new System.Windows.Forms.PictureBox();
			this.m_btnAssignVoiceActors = new System.Windows.Forms.Button();
			this.m_lblSettingsInfo = new System.Windows.Forms.Label();
			this.m_imgCheckAssignCharacters = new System.Windows.Forms.PictureBox();
			this.m_btnSettings = new System.Windows.Forms.Button();
			this.m_lblBookSelectionInfo = new System.Windows.Forms.Label();
			this.m_lblPercentAssigned = new System.Windows.Forms.Label();
			this.m_imgCheckBooks = new System.Windows.Forms.PictureBox();
			this.m_btnSelectBooks = new System.Windows.Forms.Button();
			this.m_btnAssign = new System.Windows.Forms.Button();
			this.m_btnExport = new System.Windows.Forms.Button();
			this.m_lblSelectNextTask = new System.Windows.Forms.Label();
			this.glyssenColorPalette = new Glyssen.Utilities.GlyssenColorPalette();
			this.m_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.m_L10NSharpExtender)).BeginInit();
			this.m_toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_imgCheckOpen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_imgCheckAssignActors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_imgCheckSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_imgCheckAssignCharacters)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_imgCheckBooks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.glyssenColorPalette)).BeginInit();
			this.m_tableLayoutPanel.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_L10NSharpExtender
			// 
			this.m_L10NSharpExtender.LocalizationManagerId = "Glyssen";
			this.m_L10NSharpExtender.PrefixForNewItems = "MainForm";
			// 
			// m_toolStrip
			// 
			this.glyssenColorPalette.SetBackColor(this.m_toolStrip, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_toolStrip.BackColor = System.Drawing.Color.Transparent;
			this.glyssenColorPalette.SetForeColor(this.m_toolStrip, Glyssen.Utilities.GlyssenColors.Default);
			this.m_toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.m_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_btnAbout,
            this.m_uiLanguageMenu});
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_toolStrip, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_toolStrip, null);
			this.m_L10NSharpExtender.SetLocalizationPriority(this.m_toolStrip, L10NSharp.LocalizationPriority.NotLocalizable);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_toolStrip, "MainForm.toolStrip1");
			this.m_toolStrip.Location = new System.Drawing.Point(0, 0);
			this.m_toolStrip.Name = "m_toolStrip";
			this.m_toolStrip.Padding = new System.Windows.Forms.Padding(15, 10, 20, 0);
			this.m_toolStrip.Size = new System.Drawing.Size(572, 32);
			this.m_toolStrip.TabIndex = 7;
			this.m_toolStrip.Text = "toolStrip1";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_toolStrip, false);
			// 
			// m_btnAbout
			// 
			this.m_btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.m_btnAbout.AutoToolTip = false;
			this.m_btnAbout.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_btnAbout, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.glyssenColorPalette.SetForeColor(this.m_btnAbout, Glyssen.Utilities.GlyssenColors.LinkColor);
			this.m_btnAbout.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.m_btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("m_btnAbout.Image")));
			this.m_btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_btnAbout, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_btnAbout, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_btnAbout, "MainForm.About");
			this.m_btnAbout.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
			this.m_btnAbout.Name = "m_btnAbout";
			this.m_btnAbout.Size = new System.Drawing.Size(53, 19);
			this.m_btnAbout.Text = "About...";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_btnAbout, true);
			this.m_btnAbout.Click += new System.EventHandler(this.About_Click);
			// 
			// m_uiLanguageMenu
			// 
			this.m_uiLanguageMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.m_uiLanguageMenu.AutoToolTip = false;
			this.glyssenColorPalette.SetBackColor(this.m_uiLanguageMenu, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_uiLanguageMenu.BackColor = System.Drawing.SystemColors.Control;
			this.m_uiLanguageMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.m_uiLanguageMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetForeColor(this.m_uiLanguageMenu, Glyssen.Utilities.GlyssenColors.LinkColor);
			this.m_uiLanguageMenu.Image = ((System.Drawing.Image)(resources.GetObject("m_uiLanguageMenu.Image")));
			this.m_uiLanguageMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_uiLanguageMenu, "");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_uiLanguageMenu, null);
			this.m_L10NSharpExtender.SetLocalizationPriority(this.m_uiLanguageMenu, L10NSharp.LocalizationPriority.NotLocalizable);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_uiLanguageMenu, "MainForm.toolStripDropDownButton1");
			this.m_uiLanguageMenu.Name = "m_uiLanguageMenu";
			this.m_uiLanguageMenu.Size = new System.Drawing.Size(58, 19);
			this.m_uiLanguageMenu.Text = "English";
			this.m_uiLanguageMenu.ToolTipText = "User-interface Language";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_uiLanguageMenu, true);
			// 
			// m_lastExportLocationLink
			// 
			this.m_lastExportLocationLink.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetActiveLinkColor(this.m_lastExportLocationLink, Glyssen.Utilities.GlyssenColors.ActiveLinkColor);
			this.m_lastExportLocationLink.AutoEllipsis = true;
			this.m_lastExportLocationLink.AutoSize = true;
			this.glyssenColorPalette.SetBackColor(this.m_lastExportLocationLink, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_lastExportLocationLink.BackColor = System.Drawing.SystemColors.Control;
			this.m_lastExportLocationLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
			this.glyssenColorPalette.SetDisabledLinkColor(this.m_lastExportLocationLink, Glyssen.Utilities.GlyssenColors.DisabledLinkColor);
			this.m_lastExportLocationLink.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_lastExportLocationLink.ForeColor = System.Drawing.SystemColors.WindowText;
			this.glyssenColorPalette.SetForeColor(this.m_lastExportLocationLink, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lastExportLocationLink.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetLinkColor(this.m_lastExportLocationLink, Glyssen.Utilities.GlyssenColors.LinkColor);
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_lastExportLocationLink, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_lastExportLocationLink, null);
			this.m_L10NSharpExtender.SetLocalizationPriority(this.m_lastExportLocationLink, L10NSharp.LocalizationPriority.NotLocalizable);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_lastExportLocationLink, "MainForm.LastExportLocation");
			this.m_lastExportLocationLink.Location = new System.Drawing.Point(3, 0);
			this.m_lastExportLocationLink.Name = "m_lastExportLocationLink";
			this.m_lastExportLocationLink.Size = new System.Drawing.Size(311, 29);
			this.m_lastExportLocationLink.TabIndex = 32;
			this.m_lastExportLocationLink.TabStop = true;
			this.m_lastExportLocationLink.Text = "last export location";
			this.m_lastExportLocationLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lastExportLocationLink, true);
			this.glyssenColorPalette.SetVisitedLinkColor(this.m_lastExportLocationLink, Glyssen.Utilities.GlyssenColors.VisitedLinkColor);
			this.m_lastExportLocationLink.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
			this.m_lastExportLocationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.m_lastExportLocationLink_LinkClicked);
			// 
			// m_lnkExit
			// 
			this.m_lnkExit.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetActiveLinkColor(this.m_lnkExit, Glyssen.Utilities.GlyssenColors.ActiveLinkColor);
			this.m_lnkExit.AutoSize = true;
			this.glyssenColorPalette.SetBackColor(this.m_lnkExit, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_lnkExit.BackColor = System.Drawing.SystemColors.Control;
			this.m_lnkExit.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
			this.glyssenColorPalette.SetDisabledLinkColor(this.m_lnkExit, Glyssen.Utilities.GlyssenColors.DisabledLinkColor);
			this.m_lnkExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.m_lnkExit.ForeColor = System.Drawing.SystemColors.WindowText;
			this.glyssenColorPalette.SetForeColor(this.m_lnkExit, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lnkExit.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetLinkColor(this.m_lnkExit, Glyssen.Utilities.GlyssenColors.LinkColor);
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_lnkExit, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_lnkExit, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_lnkExit, "MainForm.Exit");
			this.m_lnkExit.Location = new System.Drawing.Point(320, 0);
			this.m_lnkExit.Name = "m_lnkExit";
			this.m_lnkExit.Size = new System.Drawing.Size(24, 29);
			this.m_lnkExit.TabIndex = 6;
			this.m_lnkExit.TabStop = true;
			this.m_lnkExit.Text = "Exit";
			this.m_lnkExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lnkExit, true);
			this.glyssenColorPalette.SetVisitedLinkColor(this.m_lnkExit, Glyssen.Utilities.GlyssenColors.VisitedLinkColor);
			this.m_lnkExit.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
			this.m_lnkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Exit_LinkClicked);
			// 
			// m_btnOpenProject
			// 
			this.glyssenColorPalette.SetBackColor(this.m_btnOpenProject, Glyssen.Utilities.GlyssenColors.BackColor);
			this.glyssenColorPalette.SetFlatAppearanceBorderColor(this.m_btnOpenProject, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.glyssenColorPalette.SetForeColor(this.m_btnOpenProject, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_btnOpenProject, "Choose a recording project to work on");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_btnOpenProject, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_btnOpenProject, "MainForm.OpenProject");
			this.m_btnOpenProject.Location = new System.Drawing.Point(23, 35);
			this.m_btnOpenProject.Name = "m_btnOpenProject";
			this.m_btnOpenProject.Size = new System.Drawing.Size(151, 23);
			this.m_btnOpenProject.TabIndex = 0;
			this.m_btnOpenProject.Text = "(1) Open Project...";
			this.m_btnOpenProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_btnOpenProject, false);
			this.m_btnOpenProject.UseVisualStyleBackColor = false;
			this.m_btnOpenProject.Click += new System.EventHandler(this.HandleOpenProject_Click);
			// 
			// m_imgCheckOpen
			// 
			this.glyssenColorPalette.SetBackColor(this.m_imgCheckOpen, Glyssen.Utilities.GlyssenColors.BackColor);
			this.glyssenColorPalette.SetForeColor(this.m_imgCheckOpen, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_imgCheckOpen.Image = global::Glyssen.Properties.Resources.green_check;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_imgCheckOpen, "Sufficiently completed to move on to following tasks");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_imgCheckOpen, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_imgCheckOpen, "MainForm.SufficientlyCompleted");
			this.m_imgCheckOpen.Location = new System.Drawing.Point(180, 35);
			this.m_imgCheckOpen.Name = "m_imgCheckOpen";
			this.m_imgCheckOpen.Size = new System.Drawing.Size(22, 23);
			this.m_imgCheckOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_imgCheckOpen.TabIndex = 26;
			this.m_imgCheckOpen.TabStop = false;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_imgCheckOpen, false);
			this.m_imgCheckOpen.Visible = false;
			// 
			// m_lblActorsAssigned
			// 
			this.m_lblActorsAssigned.AutoEllipsis = true;
			this.m_lblActorsAssigned.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblActorsAssigned, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_lblActorsAssigned.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glyssenColorPalette.SetForeColor(this.m_lblActorsAssigned, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblActorsAssigned.ForeColor = System.Drawing.SystemColors.WindowText;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_lblActorsAssigned, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_lblActorsAssigned, "{0} and {1} are numbers");
			this.m_L10NSharpExtender.SetLocalizingId(this.m_lblActorsAssigned, "MainForm.ActorsAssigned");
			this.m_lblActorsAssigned.Location = new System.Drawing.Point(208, 148);
			this.m_lblActorsAssigned.Name = "m_lblActorsAssigned";
			this.m_lblActorsAssigned.Size = new System.Drawing.Size(341, 29);
			this.m_lblActorsAssigned.TabIndex = 30;
			this.m_lblActorsAssigned.Text = "{0} voice actors identified, {1} assigned";
			this.m_lblActorsAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblActorsAssigned, true);
			// 
			// m_imgCheckAssignActors
			// 
			this.glyssenColorPalette.SetBackColor(this.m_imgCheckAssignActors, Glyssen.Utilities.GlyssenColors.BackColor);
			this.glyssenColorPalette.SetForeColor(this.m_imgCheckAssignActors, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_imgCheckAssignActors.Image = global::Glyssen.Properties.Resources.green_check;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_imgCheckAssignActors, "Sufficiently completed to move on to following tasks");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_imgCheckAssignActors, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_imgCheckAssignActors, "MainForm.SufficientlyCompleted");
			this.m_imgCheckAssignActors.Location = new System.Drawing.Point(180, 151);
			this.m_imgCheckAssignActors.Name = "m_imgCheckAssignActors";
			this.m_imgCheckAssignActors.Size = new System.Drawing.Size(22, 23);
			this.m_imgCheckAssignActors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_imgCheckAssignActors.TabIndex = 31;
			this.m_imgCheckAssignActors.TabStop = false;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_imgCheckAssignActors, false);
			this.m_imgCheckAssignActors.Visible = false;
			// 
			// m_lblProjectInfo
			// 
			this.m_lblProjectInfo.AutoEllipsis = true;
			this.m_lblProjectInfo.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblProjectInfo, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_lblProjectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glyssenColorPalette.SetForeColor(this.m_lblProjectInfo, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblProjectInfo.ForeColor = System.Drawing.SystemColors.WindowText;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_lblProjectInfo, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_lblProjectInfo, null);
			this.m_L10NSharpExtender.SetLocalizationPriority(this.m_lblProjectInfo, L10NSharp.LocalizationPriority.NotLocalizable);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_lblProjectInfo, "MainForm.MainForm.m_lblBundleId");
			this.m_lblProjectInfo.Location = new System.Drawing.Point(208, 32);
			this.m_lblProjectInfo.Name = "m_lblProjectInfo";
			this.m_lblProjectInfo.Size = new System.Drawing.Size(341, 29);
			this.m_lblProjectInfo.TabIndex = 3;
			this.m_lblProjectInfo.Text = "{0}";
			this.m_lblProjectInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblProjectInfo, true);
			// 
			// m_imgCheckSettings
			// 
			this.glyssenColorPalette.SetBackColor(this.m_imgCheckSettings, Glyssen.Utilities.GlyssenColors.BackColor);
			this.glyssenColorPalette.SetForeColor(this.m_imgCheckSettings, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_imgCheckSettings.Image = global::Glyssen.Properties.Resources.green_check;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_imgCheckSettings, "Sufficiently completed to move on to following tasks");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_imgCheckSettings, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_imgCheckSettings, "MainForm.SufficientlyCompleted");
			this.m_imgCheckSettings.Location = new System.Drawing.Point(180, 64);
			this.m_imgCheckSettings.Name = "m_imgCheckSettings";
			this.m_imgCheckSettings.Size = new System.Drawing.Size(22, 23);
			this.m_imgCheckSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_imgCheckSettings.TabIndex = 27;
			this.m_imgCheckSettings.TabStop = false;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_imgCheckSettings, false);
			this.m_imgCheckSettings.Visible = false;
			// 
			// m_btnAssignVoiceActors
			// 
			this.glyssenColorPalette.SetBackColor(this.m_btnAssignVoiceActors, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_btnAssignVoiceActors.Enabled = false;
			this.glyssenColorPalette.SetFlatAppearanceBorderColor(this.m_btnAssignVoiceActors, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.glyssenColorPalette.SetForeColor(this.m_btnAssignVoiceActors, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_btnAssignVoiceActors, "Enter Voice Actor information and assign Voice Actors to Character Groups");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_btnAssignVoiceActors, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_btnAssignVoiceActors, "MainForm.AssignVoiceActors");
			this.m_btnAssignVoiceActors.Location = new System.Drawing.Point(23, 151);
			this.m_btnAssignVoiceActors.Name = "m_btnAssignVoiceActors";
			this.m_btnAssignVoiceActors.Size = new System.Drawing.Size(151, 23);
			this.m_btnAssignVoiceActors.TabIndex = 4;
			this.m_btnAssignVoiceActors.Text = "(5) Assign Voice Actors...";
			this.m_btnAssignVoiceActors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_btnAssignVoiceActors, false);
			this.m_btnAssignVoiceActors.UseVisualStyleBackColor = false;
			this.m_btnAssignVoiceActors.Click += new System.EventHandler(this.AssignVoiceActors_Click);
			// 
			// m_lblSettingsInfo
			// 
			this.m_lblSettingsInfo.AutoEllipsis = true;
			this.m_lblSettingsInfo.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblSettingsInfo, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_lblSettingsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glyssenColorPalette.SetForeColor(this.m_lblSettingsInfo, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblSettingsInfo.ForeColor = System.Drawing.SystemColors.WindowText;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_lblSettingsInfo, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_lblSettingsInfo, null);
			this.m_L10NSharpExtender.SetLocalizationPriority(this.m_lblSettingsInfo, L10NSharp.LocalizationPriority.NotLocalizable);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_lblSettingsInfo, "MainForm.MainForm.m_lblLanguage");
			this.m_lblSettingsInfo.Location = new System.Drawing.Point(208, 61);
			this.m_lblSettingsInfo.Name = "m_lblSettingsInfo";
			this.m_lblSettingsInfo.Size = new System.Drawing.Size(341, 29);
			this.m_lblSettingsInfo.TabIndex = 5;
			this.m_lblSettingsInfo.Text = "{0}";
			this.m_lblSettingsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblSettingsInfo, true);
			// 
			// m_imgCheckAssignCharacters
			// 
			this.glyssenColorPalette.SetBackColor(this.m_imgCheckAssignCharacters, Glyssen.Utilities.GlyssenColors.BackColor);
			this.glyssenColorPalette.SetForeColor(this.m_imgCheckAssignCharacters, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_imgCheckAssignCharacters.Image = global::Glyssen.Properties.Resources.green_check;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_imgCheckAssignCharacters, "Sufficiently completed to move on to following tasks");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_imgCheckAssignCharacters, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_imgCheckAssignCharacters, "MainForm.SufficientlyCompleted");
			this.m_imgCheckAssignCharacters.Location = new System.Drawing.Point(180, 122);
			this.m_imgCheckAssignCharacters.Name = "m_imgCheckAssignCharacters";
			this.m_imgCheckAssignCharacters.Size = new System.Drawing.Size(22, 23);
			this.m_imgCheckAssignCharacters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_imgCheckAssignCharacters.TabIndex = 29;
			this.m_imgCheckAssignCharacters.TabStop = false;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_imgCheckAssignCharacters, false);
			this.m_imgCheckAssignCharacters.Visible = false;
			// 
			// m_btnSettings
			// 
			this.glyssenColorPalette.SetBackColor(this.m_btnSettings, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_btnSettings.Enabled = false;
			this.glyssenColorPalette.SetFlatAppearanceBorderColor(this.m_btnSettings, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.glyssenColorPalette.SetForeColor(this.m_btnSettings, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_btnSettings, "Change the settings used to generate the recording script");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_btnSettings, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_btnSettings, "MainForm.ProjectSettings");
			this.m_btnSettings.Location = new System.Drawing.Point(23, 64);
			this.m_btnSettings.Name = "m_btnSettings";
			this.m_btnSettings.Size = new System.Drawing.Size(151, 23);
			this.m_btnSettings.TabIndex = 1;
			this.m_btnSettings.Text = "(2) Project Settings...";
			this.m_btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_btnSettings, false);
			this.m_btnSettings.UseVisualStyleBackColor = false;
			this.m_btnSettings.Click += new System.EventHandler(this.Settings_Click);
			// 
			// m_lblBookSelectionInfo
			// 
			this.m_lblBookSelectionInfo.AutoEllipsis = true;
			this.m_lblBookSelectionInfo.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblBookSelectionInfo, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_lblBookSelectionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glyssenColorPalette.SetForeColor(this.m_lblBookSelectionInfo, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblBookSelectionInfo.ForeColor = System.Drawing.SystemColors.WindowText;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_lblBookSelectionInfo, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_lblBookSelectionInfo, null);
			this.m_L10NSharpExtender.SetLocalizationPriority(this.m_lblBookSelectionInfo, L10NSharp.LocalizationPriority.NotLocalizable);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_lblBookSelectionInfo, "MainForm.MainForm.m_lblLanguage");
			this.m_lblBookSelectionInfo.Location = new System.Drawing.Point(208, 90);
			this.m_lblBookSelectionInfo.Name = "m_lblBookSelectionInfo";
			this.m_lblBookSelectionInfo.Size = new System.Drawing.Size(341, 29);
			this.m_lblBookSelectionInfo.TabIndex = 24;
			this.m_lblBookSelectionInfo.Text = "{0}";
			this.m_lblBookSelectionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblBookSelectionInfo, true);
			// 
			// m_lblPercentAssigned
			// 
			this.m_lblPercentAssigned.AutoEllipsis = true;
			this.m_lblPercentAssigned.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblPercentAssigned, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_lblPercentAssigned.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glyssenColorPalette.SetForeColor(this.m_lblPercentAssigned, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblPercentAssigned.ForeColor = System.Drawing.SystemColors.WindowText;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_lblPercentAssigned, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_lblPercentAssigned, "{0:N1} is a number with one decimal point");
			this.m_L10NSharpExtender.SetLocalizingId(this.m_lblPercentAssigned, "MainForm.PercentComplete");
			this.m_lblPercentAssigned.Location = new System.Drawing.Point(208, 119);
			this.m_lblPercentAssigned.Name = "m_lblPercentAssigned";
			this.m_lblPercentAssigned.Size = new System.Drawing.Size(341, 29);
			this.m_lblPercentAssigned.TabIndex = 17;
			this.m_lblPercentAssigned.Text = "{0:N1}% complete";
			this.m_lblPercentAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblPercentAssigned, true);
			// 
			// m_imgCheckBooks
			// 
			this.glyssenColorPalette.SetBackColor(this.m_imgCheckBooks, Glyssen.Utilities.GlyssenColors.BackColor);
			this.glyssenColorPalette.SetForeColor(this.m_imgCheckBooks, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_imgCheckBooks.Image = global::Glyssen.Properties.Resources.green_check;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_imgCheckBooks, "Sufficiently completed to move on to following tasks");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_imgCheckBooks, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_imgCheckBooks, "MainForm.SufficientlyCompleted");
			this.m_imgCheckBooks.Location = new System.Drawing.Point(180, 93);
			this.m_imgCheckBooks.Name = "m_imgCheckBooks";
			this.m_imgCheckBooks.Size = new System.Drawing.Size(22, 23);
			this.m_imgCheckBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.m_imgCheckBooks.TabIndex = 28;
			this.m_imgCheckBooks.TabStop = false;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_imgCheckBooks, false);
			this.m_imgCheckBooks.Visible = false;
			// 
			// m_btnSelectBooks
			// 
			this.glyssenColorPalette.SetBackColor(this.m_btnSelectBooks, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_btnSelectBooks.Enabled = false;
			this.glyssenColorPalette.SetFlatAppearanceBorderColor(this.m_btnSelectBooks, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.glyssenColorPalette.SetForeColor(this.m_btnSelectBooks, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_btnSelectBooks, "Choose which books to include in the recording script");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_btnSelectBooks, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_btnSelectBooks, "MainForm.SelectBooks");
			this.m_btnSelectBooks.Location = new System.Drawing.Point(23, 93);
			this.m_btnSelectBooks.Name = "m_btnSelectBooks";
			this.m_btnSelectBooks.Size = new System.Drawing.Size(151, 23);
			this.m_btnSelectBooks.TabIndex = 2;
			this.m_btnSelectBooks.Text = "(3) Select Books...";
			this.m_btnSelectBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_btnSelectBooks, false);
			this.m_btnSelectBooks.UseVisualStyleBackColor = false;
			this.m_btnSelectBooks.Click += new System.EventHandler(this.SelectBooks_Click);
			// 
			// m_btnAssign
			// 
			this.glyssenColorPalette.SetBackColor(this.m_btnAssign, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_btnAssign.Enabled = false;
			this.glyssenColorPalette.SetFlatAppearanceBorderColor(this.m_btnAssign, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.glyssenColorPalette.SetForeColor(this.m_btnAssign, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_btnAssign, "Select a Character ID for each block in the recording script");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_btnAssign, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_btnAssign, "MainForm.AssignCharacters");
			this.m_btnAssign.Location = new System.Drawing.Point(23, 122);
			this.m_btnAssign.Name = "m_btnAssign";
			this.m_btnAssign.Size = new System.Drawing.Size(151, 23);
			this.m_btnAssign.TabIndex = 3;
			this.m_btnAssign.Text = "(4) Assign Characters...";
			this.m_btnAssign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_btnAssign, false);
			this.m_btnAssign.UseVisualStyleBackColor = false;
			this.m_btnAssign.Click += new System.EventHandler(this.Assign_Click);
			// 
			// m_btnExport
			// 
			this.glyssenColorPalette.SetBackColor(this.m_btnExport, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_btnExport.Enabled = false;
			this.glyssenColorPalette.SetFlatAppearanceBorderColor(this.m_btnExport, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.glyssenColorPalette.SetForeColor(this.m_btnExport, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_btnExport, "Export to a spreadsheet file");
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_btnExport, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_btnExport, "MainForm.ExportScript");
			this.m_btnExport.Location = new System.Drawing.Point(23, 180);
			this.m_btnExport.Name = "m_btnExport";
			this.m_btnExport.Size = new System.Drawing.Size(151, 23);
			this.m_btnExport.TabIndex = 5;
			this.m_btnExport.Text = "({0}) Export Recording Script...";
			this.m_btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_btnExport, false);
			this.m_btnExport.UseVisualStyleBackColor = false;
			this.m_btnExport.Click += new System.EventHandler(this.Export_Click);
			// 
			// m_lblSelectNextTask
			// 
			this.m_lblSelectNextTask.AutoSize = true;
			this.m_lblSelectNextTask.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblSelectNextTask, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_tableLayoutPanel.SetColumnSpan(this.m_lblSelectNextTask, 3);
			this.glyssenColorPalette.SetForeColor(this.m_lblSelectNextTask, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblSelectNextTask.ForeColor = System.Drawing.SystemColors.WindowText;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this.m_lblSelectNextTask, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this.m_lblSelectNextTask, null);
			this.m_L10NSharpExtender.SetLocalizingId(this.m_lblSelectNextTask, "MainForm.SelectTask");
			this.m_lblSelectNextTask.Location = new System.Drawing.Point(23, 4);
			this.m_lblSelectNextTask.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
			this.m_lblSelectNextTask.Name = "m_lblSelectNextTask";
			this.m_lblSelectNextTask.Size = new System.Drawing.Size(177, 13);
			this.m_lblSelectNextTask.TabIndex = 38;
			this.m_lblSelectNextTask.Text = "Select the next task you want to do:";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblSelectNextTask, true);
			// 
			// m_tableLayoutPanel
			// 
			this.m_tableLayoutPanel.AutoSize = true;
			this.m_tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.glyssenColorPalette.SetBackColor(this.m_tableLayoutPanel, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_tableLayoutPanel.ColumnCount = 3;
			this.m_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.m_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tableLayoutPanel.Controls.Add(this.m_lblSelectNextTask, 0, 0);
			this.m_tableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 2, 6);
			this.m_tableLayoutPanel.Controls.Add(this.m_btnOpenProject, 0, 1);
			this.m_tableLayoutPanel.Controls.Add(this.m_imgCheckOpen, 1, 1);
			this.m_tableLayoutPanel.Controls.Add(this.m_lblActorsAssigned, 2, 5);
			this.m_tableLayoutPanel.Controls.Add(this.m_imgCheckAssignActors, 1, 5);
			this.m_tableLayoutPanel.Controls.Add(this.m_lblProjectInfo, 2, 1);
			this.m_tableLayoutPanel.Controls.Add(this.m_imgCheckSettings, 1, 2);
			this.m_tableLayoutPanel.Controls.Add(this.m_btnAssignVoiceActors, 0, 5);
			this.m_tableLayoutPanel.Controls.Add(this.m_lblSettingsInfo, 2, 2);
			this.m_tableLayoutPanel.Controls.Add(this.m_imgCheckAssignCharacters, 1, 4);
			this.m_tableLayoutPanel.Controls.Add(this.m_btnSettings, 0, 2);
			this.m_tableLayoutPanel.Controls.Add(this.m_lblBookSelectionInfo, 2, 3);
			this.m_tableLayoutPanel.Controls.Add(this.m_lblPercentAssigned, 2, 4);
			this.m_tableLayoutPanel.Controls.Add(this.m_imgCheckBooks, 1, 3);
			this.m_tableLayoutPanel.Controls.Add(this.m_btnSelectBooks, 0, 3);
			this.m_tableLayoutPanel.Controls.Add(this.m_btnAssign, 0, 4);
			this.m_tableLayoutPanel.Controls.Add(this.m_btnExport, 0, 6);
			this.m_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.glyssenColorPalette.SetForeColor(this.m_tableLayoutPanel, Glyssen.Utilities.GlyssenColors.Default);
			this.m_tableLayoutPanel.Location = new System.Drawing.Point(0, 32);
			this.m_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
			this.m_tableLayoutPanel.Name = "m_tableLayoutPanel";
			this.m_tableLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 4, 20, 20);
			this.m_tableLayoutPanel.RowCount = 8;
			this.m_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_tableLayoutPanel.Size = new System.Drawing.Size(572, 226);
			this.m_tableLayoutPanel.TabIndex = 40;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_tableLayoutPanel, false);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.glyssenColorPalette.SetBackColor(this.tableLayoutPanel2, Glyssen.Utilities.GlyssenColors.BackColor);
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.m_lastExportLocationLink, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.m_lnkExit, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glyssenColorPalette.SetForeColor(this.tableLayoutPanel2, Glyssen.Utilities.GlyssenColors.Default);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(205, 177);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(347, 29);
			this.tableLayoutPanel2.TabIndex = 34;
			this.glyssenColorPalette.SetUsePaletteColors(this.tableLayoutPanel2, false);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.glyssenColorPalette.SetBackColor(this, Glyssen.Utilities.GlyssenColors.BackColor);
			this.ClientSize = new System.Drawing.Size(572, 319);
			this.Controls.Add(this.m_tableLayoutPanel);
			this.Controls.Add(this.m_toolStrip);
			this.glyssenColorPalette.SetForeColor(this, Glyssen.Utilities.GlyssenColors.Default);
			this.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Icon = global::Glyssen.Properties.Resources.glyssenIcon;
			this.m_L10NSharpExtender.SetLocalizableToolTip(this, null);
			this.m_L10NSharpExtender.SetLocalizationComment(this, null);
			this.m_L10NSharpExtender.SetLocalizationPriority(this, L10NSharp.LocalizationPriority.NotLocalizable);
			this.m_L10NSharpExtender.SetLocalizingId(this, "MainForm.WindowTitle");
			this.Location = new System.Drawing.Point(50, 50);
			this.MinimumSize = new System.Drawing.Size(540, 100);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Glyssen";
			this.glyssenColorPalette.SetUsePaletteColors(this, true);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.m_L10NSharpExtender)).EndInit();
			this.m_toolStrip.ResumeLayout(false);
			this.m_toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_imgCheckOpen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_imgCheckAssignActors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_imgCheckSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_imgCheckAssignCharacters)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_imgCheckBooks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.glyssenColorPalette)).EndInit();
			this.m_tableLayoutPanel.ResumeLayout(false);
			this.m_tableLayoutPanel.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private L10NSharp.UI.L10NSharpExtender m_L10NSharpExtender;
		private System.Windows.Forms.ToolStrip m_toolStrip;
		private System.Windows.Forms.ToolStripButton m_btnAbout;
		private System.Windows.Forms.ToolStripDropDownButton m_uiLanguageMenu;
		private Utilities.GlyssenColorPalette glyssenColorPalette;
		private System.Windows.Forms.TableLayoutPanel m_tableLayoutPanel;
		private System.Windows.Forms.Label m_lblSelectNextTask;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.LinkLabel m_lastExportLocationLink;
		private System.Windows.Forms.LinkLabel m_lnkExit;
		private System.Windows.Forms.Button m_btnOpenProject;
		private System.Windows.Forms.PictureBox m_imgCheckOpen;
		private System.Windows.Forms.Label m_lblActorsAssigned;
		private System.Windows.Forms.PictureBox m_imgCheckAssignActors;
		private System.Windows.Forms.Label m_lblProjectInfo;
		private System.Windows.Forms.PictureBox m_imgCheckSettings;
		private System.Windows.Forms.Button m_btnAssignVoiceActors;
		private System.Windows.Forms.Label m_lblSettingsInfo;
		private System.Windows.Forms.PictureBox m_imgCheckAssignCharacters;
		private System.Windows.Forms.Button m_btnSettings;
		private System.Windows.Forms.Label m_lblBookSelectionInfo;
		private System.Windows.Forms.Label m_lblPercentAssigned;
		private System.Windows.Forms.PictureBox m_imgCheckBooks;
		private System.Windows.Forms.Button m_btnSelectBooks;
		private System.Windows.Forms.Button m_btnAssign;
		private System.Windows.Forms.Button m_btnExport;
	}
}




