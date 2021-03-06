﻿using L10NSharp.UI;

namespace Glyssen.Dialogs
{
	partial class VoiceActorInformationDlg
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
				LocalizeItemDlg.StringsLocalized -= HandleStringsLocalized;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceActorInformationDlg));
			this.m_lblInstructions = new System.Windows.Forms.Label();
			this.m_btnNext = new System.Windows.Forms.Button();
			this.l10NSharpExtender1 = new L10NSharp.UI.L10NSharpExtender(this.components);
			this.m_linkClose = new System.Windows.Forms.LinkLabel();
			this.m_btnOk = new System.Windows.Forms.Button();
			this.m_lblProjectSummary = new System.Windows.Forms.Label();
			this.m_lblRecordingTime = new System.Windows.Forms.Label();
			this.m_lblRecommendedCast = new System.Windows.Forms.Label();
			this.m_linkNarrationPreferences = new System.Windows.Forms.LinkLabel();
			this.m_linkMoreInfo = new System.Windows.Forms.LinkLabel();
			this.m_lblTally = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.m_toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
			this.m_dataGrid = new Glyssen.Controls.VoiceActorInformationGrid();
			this.m_saveStatus = new Glyssen.Controls.SaveStatus();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.glyssenColorPalette = new Glyssen.Utilities.GlyssenColorPalette();
			((System.ComponentModel.ISupportInitialize)(this.l10NSharpExtender1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.glyssenColorPalette)).BeginInit();
			this.SuspendLayout();
			// 
			// m_lblInstructions
			// 
			this.m_lblInstructions.AutoSize = true;
			this.m_lblInstructions.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblInstructions, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.glyssenColorPalette.SetForeColor(this.m_lblInstructions, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblInstructions.ForeColor = System.Drawing.SystemColors.WindowText;
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_lblInstructions, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_lblInstructions, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_lblInstructions, "DialogBoxes.VoiceActorInformation.EnterVoiceActors");
			this.m_lblInstructions.Location = new System.Drawing.Point(0, 80);
			this.m_lblInstructions.Margin = new System.Windows.Forms.Padding(0, 0, 3, 6);
			this.m_lblInstructions.Name = "m_lblInstructions";
			this.m_lblInstructions.Size = new System.Drawing.Size(143, 13);
			this.m_lblInstructions.TabIndex = 0;
			this.m_lblInstructions.Text = "Enter Your Voice Actors";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblInstructions, true);
			// 
			// m_btnNext
			// 
			this.m_btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.glyssenColorPalette.SetBackColor(this.m_btnNext, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_btnNext.Enabled = false;
			this.glyssenColorPalette.SetFlatAppearanceBorderColor(this.m_btnNext, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.glyssenColorPalette.SetForeColor(this.m_btnNext, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_btnNext, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_btnNext, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_btnNext, "Common.Next");
			this.m_btnNext.Location = new System.Drawing.Point(504, 296);
			this.m_btnNext.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.m_btnNext.Name = "m_btnNext";
			this.m_btnNext.Size = new System.Drawing.Size(75, 23);
			this.m_btnNext.TabIndex = 2;
			this.m_btnNext.Text = "Next";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_btnNext, false);
			this.m_btnNext.UseVisualStyleBackColor = true;
			this.m_btnNext.Click += new System.EventHandler(this.BtnNext_Click);
			// 
			// l10NSharpExtender1
			// 
			this.l10NSharpExtender1.LocalizationManagerId = "Glyssen";
			this.l10NSharpExtender1.PrefixForNewItems = "DialogBoxes.VoiceActorInformation";
			// 
			// m_linkClose
			// 
			this.m_linkClose.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetActiveLinkColor(this.m_linkClose, Glyssen.Utilities.GlyssenColors.ActiveLinkColor);
			this.m_linkClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.m_linkClose.AutoSize = true;
			this.glyssenColorPalette.SetBackColor(this.m_linkClose, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_linkClose.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetDisabledLinkColor(this.m_linkClose, Glyssen.Utilities.GlyssenColors.DisabledLinkColor);
			this.m_linkClose.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
			this.glyssenColorPalette.SetForeColor(this.m_linkClose, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_linkClose.ForeColor = System.Drawing.SystemColors.WindowText;
			this.m_linkClose.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetLinkColor(this.m_linkClose, Glyssen.Utilities.GlyssenColors.LinkColor);
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_linkClose, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_linkClose, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_linkClose, "DialogBoxes.VoiceActorInformation.Close");
			this.m_linkClose.Location = new System.Drawing.Point(546, 360);
			this.m_linkClose.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
			this.m_linkClose.Name = "m_linkClose";
			this.m_linkClose.Size = new System.Drawing.Size(33, 13);
			this.m_linkClose.TabIndex = 5;
			this.m_linkClose.TabStop = true;
			this.m_linkClose.Text = "Close";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_linkClose, true);
			this.m_linkClose.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetVisitedLinkColor(this.m_linkClose, Glyssen.Utilities.GlyssenColors.VisitedLinkColor);
			this.m_linkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClose_LinkClicked);
			// 
			// m_btnOk
			// 
			this.m_btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.glyssenColorPalette.SetBackColor(this.m_btnOk, Glyssen.Utilities.GlyssenColors.BackColor);
			this.glyssenColorPalette.SetFlatAppearanceBorderColor(this.m_btnOk, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.glyssenColorPalette.SetForeColor(this.m_btnOk, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_btnOk, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_btnOk, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_btnOk, "Common.OK");
			this.m_btnOk.Location = new System.Drawing.Point(504, 328);
			this.m_btnOk.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.m_btnOk.Name = "m_btnOk";
			this.m_btnOk.Size = new System.Drawing.Size(75, 23);
			this.m_btnOk.TabIndex = 2;
			this.m_btnOk.Text = "OK";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_btnOk, false);
			this.m_btnOk.UseVisualStyleBackColor = true;
			this.m_btnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// m_lblProjectSummary
			// 
			this.m_lblProjectSummary.AutoSize = true;
			this.m_lblProjectSummary.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblProjectSummary, Glyssen.Utilities.GlyssenColors.BackColor);
			this.tableLayoutPanel1.SetColumnSpan(this.m_lblProjectSummary, 4);
			this.glyssenColorPalette.SetForeColor(this.m_lblProjectSummary, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblProjectSummary.ForeColor = System.Drawing.SystemColors.WindowText;
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_lblProjectSummary, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_lblProjectSummary, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_lblProjectSummary, "DialogBoxes.VoiceActorInformation.ProjectSummary");
			this.m_lblProjectSummary.Location = new System.Drawing.Point(3, 0);
			this.m_lblProjectSummary.Name = "m_lblProjectSummary";
			this.m_lblProjectSummary.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.m_lblProjectSummary.Size = new System.Drawing.Size(282, 16);
			this.m_lblProjectSummary.TabIndex = 7;
			this.m_lblProjectSummary.Text = "This project has {0} books with {1} distinct character roles.";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblProjectSummary, true);
			// 
			// m_lblRecordingTime
			// 
			this.m_lblRecordingTime.AutoSize = true;
			this.m_lblRecordingTime.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblRecordingTime, Glyssen.Utilities.GlyssenColors.BackColor);
			this.tableLayoutPanel1.SetColumnSpan(this.m_lblRecordingTime, 4);
			this.glyssenColorPalette.SetForeColor(this.m_lblRecordingTime, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblRecordingTime.ForeColor = System.Drawing.SystemColors.WindowText;
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_lblRecordingTime, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_lblRecordingTime, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_lblRecordingTime, "DialogBoxes.VoiceActorInformation.RecordingTime");
			this.m_lblRecordingTime.Location = new System.Drawing.Point(3, 16);
			this.m_lblRecordingTime.Name = "m_lblRecordingTime";
			this.m_lblRecordingTime.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.m_lblRecordingTime.Size = new System.Drawing.Size(188, 16);
			this.m_lblRecordingTime.TabIndex = 8;
			this.m_lblRecordingTime.Text = "Estimated recording time: {0:N2} hours";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblRecordingTime, true);
			// 
			// m_lblRecommendedCast
			// 
			this.m_lblRecommendedCast.AutoSize = true;
			this.m_lblRecommendedCast.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblRecommendedCast, Glyssen.Utilities.GlyssenColors.BackColor);
			this.tableLayoutPanel1.SetColumnSpan(this.m_lblRecommendedCast, 4);
			this.glyssenColorPalette.SetForeColor(this.m_lblRecommendedCast, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblRecommendedCast.ForeColor = System.Drawing.SystemColors.WindowText;
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_lblRecommendedCast, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_lblRecommendedCast, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_lblRecommendedCast, "DialogBoxes.VoiceActorInformation.RecommendedCast");
			this.m_lblRecommendedCast.Location = new System.Drawing.Point(3, 32);
			this.m_lblRecommendedCast.Name = "m_lblRecommendedCast";
			this.m_lblRecommendedCast.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.m_lblRecommendedCast.Size = new System.Drawing.Size(351, 16);
			this.m_lblRecommendedCast.TabIndex = 9;
			this.m_lblRecommendedCast.Text = "Recommended cast: 15-23 voice actors, including 2 women and 1 child. ";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblRecommendedCast, true);
			// 
			// m_linkNarrationPreferences
			// 
			this.m_linkNarrationPreferences.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetActiveLinkColor(this.m_linkNarrationPreferences, Glyssen.Utilities.GlyssenColors.ActiveLinkColor);
			this.m_linkNarrationPreferences.AutoSize = true;
			this.glyssenColorPalette.SetBackColor(this.m_linkNarrationPreferences, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_linkNarrationPreferences.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.SetColumnSpan(this.m_linkNarrationPreferences, 4);
			this.glyssenColorPalette.SetDisabledLinkColor(this.m_linkNarrationPreferences, Glyssen.Utilities.GlyssenColors.DisabledLinkColor);
			this.m_linkNarrationPreferences.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
			this.glyssenColorPalette.SetForeColor(this.m_linkNarrationPreferences, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_linkNarrationPreferences.ForeColor = System.Drawing.SystemColors.WindowText;
			this.m_linkNarrationPreferences.LinkArea = new System.Windows.Forms.LinkArea(60, 3);
			this.m_linkNarrationPreferences.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetLinkColor(this.m_linkNarrationPreferences, Glyssen.Utilities.GlyssenColors.LinkColor);
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_linkNarrationPreferences, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_linkNarrationPreferences, "{0} is the clickable text.  Its localizingId is DialogBoxes.VoiceActorInformation" +
        ".NarrationPreferences.LinkText");
			this.l10NSharpExtender1.SetLocalizingId(this.m_linkNarrationPreferences, "DialogBoxes.VoiceActorInformation.NarrationPreferences.NonLinkText");
			this.m_linkNarrationPreferences.Location = new System.Drawing.Point(3, 48);
			this.m_linkNarrationPreferences.Name = "m_linkNarrationPreferences";
			this.m_linkNarrationPreferences.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.m_linkNarrationPreferences.Size = new System.Drawing.Size(325, 17);
			this.m_linkNarrationPreferences.TabIndex = 10;
			this.m_linkNarrationPreferences.TabStop = true;
			this.m_linkNarrationPreferences.Text = "6-8 of the actors will have narration roles. You can change {0}.";
			this.m_linkNarrationPreferences.UseCompatibleTextRendering = true;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_linkNarrationPreferences, true);
			this.m_linkNarrationPreferences.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetVisitedLinkColor(this.m_linkNarrationPreferences, Glyssen.Utilities.GlyssenColors.VisitedLinkColor);
			this.m_linkNarrationPreferences.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNarrationPreferences_LinkClicked);
			// 
			// m_linkMoreInfo
			// 
			this.m_linkMoreInfo.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetActiveLinkColor(this.m_linkMoreInfo, Glyssen.Utilities.GlyssenColors.ActiveLinkColor);
			this.m_linkMoreInfo.AutoSize = true;
			this.glyssenColorPalette.SetBackColor(this.m_linkMoreInfo, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_linkMoreInfo.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.SetColumnSpan(this.m_linkMoreInfo, 4);
			this.glyssenColorPalette.SetDisabledLinkColor(this.m_linkMoreInfo, Glyssen.Utilities.GlyssenColors.DisabledLinkColor);
			this.m_linkMoreInfo.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
			this.glyssenColorPalette.SetForeColor(this.m_linkMoreInfo, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_linkMoreInfo.ForeColor = System.Drawing.SystemColors.WindowText;
			this.m_linkMoreInfo.LinkArea = new System.Windows.Forms.LinkArea(77, 3);
			this.m_linkMoreInfo.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetLinkColor(this.m_linkMoreInfo, Glyssen.Utilities.GlyssenColors.LinkColor);
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_linkMoreInfo, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_linkMoreInfo, "{0} is the clickable text.  Its localizingId is DialogBoxes.VoiceActorInformation" +
        ".MoreInfo.LinkText");
			this.l10NSharpExtender1.SetLocalizingId(this.m_linkMoreInfo, "DialogBoxes.VoiceActorInformation.MoreInfo.NonLinkText");
			this.m_linkMoreInfo.Location = new System.Drawing.Point(3, 99);
			this.m_linkMoreInfo.Name = "m_linkMoreInfo";
			this.m_linkMoreInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.m_linkMoreInfo.Size = new System.Drawing.Size(409, 20);
			this.m_linkMoreInfo.TabIndex = 11;
			this.m_linkMoreInfo.TabStop = true;
			this.m_linkMoreInfo.Text = "(the voice actors you intend to use, even if fewer or more than recommended) {0}";
			this.m_linkMoreInfo.UseCompatibleTextRendering = true;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_linkMoreInfo, true);
			this.m_linkMoreInfo.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
			this.glyssenColorPalette.SetVisitedLinkColor(this.m_linkMoreInfo, Glyssen.Utilities.GlyssenColors.VisitedLinkColor);
			this.m_linkMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMoreInfo_LinkClicked);
			// 
			// m_lblTally
			// 
			this.m_lblTally.AutoSize = true;
			this.m_lblTally.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_lblTally, Glyssen.Utilities.GlyssenColors.BackColor);
			this.tableLayoutPanel1.SetColumnSpan(this.m_lblTally, 4);
			this.glyssenColorPalette.SetForeColor(this.m_lblTally, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_lblTally.ForeColor = System.Drawing.SystemColors.WindowText;
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_lblTally, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_lblTally, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_lblTally, "DialogBoxes.VoiceActorInformation.Tally");
			this.m_lblTally.Location = new System.Drawing.Point(3, 274);
			this.m_lblTally.Name = "m_lblTally";
			this.m_lblTally.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.m_lblTally.Size = new System.Drawing.Size(178, 16);
			this.m_lblTally.TabIndex = 12;
			this.m_lblTally.Text = "Tally: {0} Male, {1} Female, {2} Child";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_lblTally, true);
			// 
			// toolStrip1
			// 
			this.glyssenColorPalette.SetBackColor(this.toolStrip1, Glyssen.Utilities.GlyssenColors.BackColor);
			this.glyssenColorPalette.SetForeColor(this.toolStrip1, Glyssen.Utilities.GlyssenColors.Default);
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_toolStripButtonHelp});
			this.l10NSharpExtender1.SetLocalizableToolTip(this.toolStrip1, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.toolStrip1, null);
			this.l10NSharpExtender1.SetLocalizingId(this.toolStrip1, "DialogBoxes.VoiceActorInformation.toolStrip1");
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(609, 25);
			this.toolStrip1.TabIndex = 7;
			this.toolStrip1.Text = "toolStrip1";
			this.glyssenColorPalette.SetUsePaletteColors(this.toolStrip1, false);
			// 
			// m_toolStripButtonHelp
			// 
			this.m_toolStripButtonHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.glyssenColorPalette.SetBackColor(this.m_toolStripButtonHelp, Glyssen.Utilities.GlyssenColors.BackColor);
			this.glyssenColorPalette.SetForeColor(this.m_toolStripButtonHelp, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.m_toolStripButtonHelp.Image = global::Glyssen.Properties.Resources.helpSmall;
			this.m_toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_toolStripButtonHelp, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_toolStripButtonHelp, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_toolStripButtonHelp, "Common.Help");
			this.m_toolStripButtonHelp.Name = "m_toolStripButtonHelp";
			this.m_toolStripButtonHelp.Size = new System.Drawing.Size(52, 22);
			this.m_toolStripButtonHelp.Text = "Help";
			this.glyssenColorPalette.SetUsePaletteColors(this.m_toolStripButtonHelp, false);
			// 
			// m_dataGrid
			// 
			this.m_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.m_dataGrid.AutoScroll = true;
			this.m_dataGrid.AutoSize = true;
			this.m_dataGrid.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_dataGrid, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.SetColumnSpan(this.m_dataGrid, 4);
			this.m_dataGrid.ForeColor = System.Drawing.SystemColors.WindowText;
			this.glyssenColorPalette.SetForeColor(this.m_dataGrid, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_dataGrid, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_dataGrid, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_dataGrid, "DialogBoxes.VoiceActorInformation.voiceActorInformationGrid21");
			this.m_dataGrid.Location = new System.Drawing.Point(0, 119);
			this.m_dataGrid.Margin = new System.Windows.Forms.Padding(0);
			this.m_dataGrid.Name = "m_dataGrid";
			this.m_dataGrid.ReadOnly = false;
			this.m_dataGrid.Size = new System.Drawing.Size(582, 155);
			this.m_dataGrid.TabIndex = 3;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_dataGrid, true);
			// 
			// m_saveStatus
			// 
			this.m_saveStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.m_saveStatus.AutoSize = true;
			this.m_saveStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_saveStatus.BackColor = System.Drawing.SystemColors.Control;
			this.glyssenColorPalette.SetBackColor(this.m_saveStatus, Glyssen.Utilities.GlyssenColors.BackColor);
			this.m_saveStatus.ForeColor = System.Drawing.SystemColors.WindowText;
			this.glyssenColorPalette.SetForeColor(this.m_saveStatus, Glyssen.Utilities.GlyssenColors.ForeColor);
			this.l10NSharpExtender1.SetLocalizableToolTip(this.m_saveStatus, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.m_saveStatus, null);
			this.l10NSharpExtender1.SetLocalizingId(this.m_saveStatus, "DialogBoxes.VoiceActorInformation.SaveStatus");
			this.m_saveStatus.Location = new System.Drawing.Point(485, 80);
			this.m_saveStatus.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
			this.m_saveStatus.Name = "m_saveStatus";
			this.m_saveStatus.Size = new System.Drawing.Size(97, 13);
			this.m_saveStatus.TabIndex = 4;
			this.m_saveStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.glyssenColorPalette.SetUsePaletteColors(this.m_saveStatus, true);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.glyssenColorPalette.SetBackColor(this.tableLayoutPanel1, Glyssen.Utilities.GlyssenColors.BackColor);
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.m_linkMoreInfo, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.m_btnNext, 3, 9);
			this.tableLayoutPanel1.Controls.Add(this.m_dataGrid, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.m_btnOk, 3, 10);
			this.tableLayoutPanel1.Controls.Add(this.m_linkClose, 3, 11);
			this.tableLayoutPanel1.Controls.Add(this.m_lblProjectSummary, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.m_lblRecordingTime, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.m_lblRecommendedCast, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.m_linkNarrationPreferences, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.m_lblInstructions, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.m_saveStatus, 3, 5);
			this.tableLayoutPanel1.Controls.Add(this.m_lblTally, 0, 8);
			this.glyssenColorPalette.SetForeColor(this.tableLayoutPanel1, Glyssen.Utilities.GlyssenColors.Default);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 31);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 12;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 373);
			this.tableLayoutPanel1.TabIndex = 6;
			this.glyssenColorPalette.SetUsePaletteColors(this.tableLayoutPanel1, false);
			// 
			// VoiceActorInformationDlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.glyssenColorPalette.SetBackColor(this, Glyssen.Utilities.GlyssenColors.BackColor);
			this.ClientSize = new System.Drawing.Size(609, 413);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.glyssenColorPalette.SetForeColor(this, Glyssen.Utilities.GlyssenColors.Default);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.l10NSharpExtender1.SetLocalizableToolTip(this, null);
			this.l10NSharpExtender1.SetLocalizationComment(this, "{0} is the project name");
			this.l10NSharpExtender1.SetLocalizingId(this, "DialogBoxes.VoiceActorInformation.WindowTitle");
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(600, 425);
			this.Name = "VoiceActorInformationDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Voice Actor Information - {0}";
			this.glyssenColorPalette.SetUsePaletteColors(this, true);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VoiceActorInformationDlg_FormClosing);
			this.Load += new System.EventHandler(this.VoiceActorInformationDlg_Load);
			((System.ComponentModel.ISupportInitialize)(this.l10NSharpExtender1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.glyssenColorPalette)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label m_lblInstructions;
		private System.Windows.Forms.Button m_btnNext;
		private L10NSharp.UI.L10NSharpExtender l10NSharpExtender1;
		private Controls.VoiceActorInformationGrid m_dataGrid;
		private Controls.SaveStatus m_saveStatus;
		private System.Windows.Forms.LinkLabel m_linkClose;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button m_btnOk;
		private System.Windows.Forms.Label m_lblProjectSummary;
		private System.Windows.Forms.Label m_lblRecordingTime;
		private System.Windows.Forms.Label m_lblRecommendedCast;
		private System.Windows.Forms.LinkLabel m_linkNarrationPreferences;
		private System.Windows.Forms.LinkLabel m_linkMoreInfo;
		private System.Windows.Forms.Label m_lblTally;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton m_toolStripButtonHelp;
		private Utilities.GlyssenColorPalette glyssenColorPalette;
	}
}