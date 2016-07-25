// ------------------------------------------------------------------------------------
// <copyright file="MainForm.Designer.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

namespace Atalasoft.Demo.PdfViewer
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
            this._menuView = new System.Windows.Forms.ToolStripMenuItem();
            this._menuViewFullSize = new System.Windows.Forms.ToolStripMenuItem();
            this._menuViewFitWidth = new System.Windows.Forms.ToolStripMenuItem();
            this._menuViewBestFit = new System.Windows.Forms.ToolStripMenuItem();
            this._menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this._menuPdfDecoderSettings = new System.Windows.Forms.ToolStripMenuItem();
            this._menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this._menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this._menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this._menuExtractImages = new System.Windows.Forms.ToolStripMenuItem();
            this._menuGetInfo = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemSplitter = new System.Windows.Forms.ToolStripSeparator();
            this._menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this._statusBar = new System.Windows.Forms.StatusBar();
            this._statusBarPanel = new System.Windows.Forms.StatusBarPanel();
            this._statusProgress = new System.Windows.Forms.StatusBarPanel();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this._workspaceViewer = new Atalasoft.Annotate.UI.AnnotateViewer();
            this._splitter = new System.Windows.Forms.Splitter();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPages = new System.Windows.Forms.TabPage();
            this._pagesLabel = new System.Windows.Forms.Label();
            this._thumbnailView = new Atalasoft.Imaging.WinControls.ThumbnailView();
            this._tabBookmarks = new System.Windows.Forms.TabPage();
            this._bookmarksLabel = new System.Windows.Forms.Label();
            this._treeBookmarks = new System.Windows.Forms.TreeView();
            this._mainMenu = new System.Windows.Forms.MenuStrip();
            this._toolStripMenu = new System.Windows.Forms.ToolStrip();
            this._openButton = new System.Windows.Forms.ToolStripButton();
            this._findButton = new System.Windows.Forms.ToolStripButton();
            this._printButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this._statusBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusProgress)).BeginInit();
            this._toolStripContainer.ContentPanel.SuspendLayout();
            this._toolStripContainer.TopToolStripPanel.SuspendLayout();
            this._toolStripContainer.SuspendLayout();
            this._tabControl.SuspendLayout();
            this._tabPages.SuspendLayout();
            this._tabBookmarks.SuspendLayout();
            this._mainMenu.SuspendLayout();
            this._toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menuView
            // 
            this._menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuViewFullSize,
            this._menuViewFitWidth,
            this._menuViewBestFit});
            this._menuView.Name = "_menuView";
            this._menuView.Size = new System.Drawing.Size(44, 20);
            this._menuView.Text = "View";
            // 
            // _menuViewFullSize
            // 
            this._menuViewFullSize.Image = ((System.Drawing.Image)(resources.GetObject("_menuViewFullSize.Image")));
            this._menuViewFullSize.Name = "_menuViewFullSize";
            this._menuViewFullSize.Size = new System.Drawing.Size(152, 22);
            this._menuViewFullSize.Text = "Full Size";
            this._menuViewFullSize.Click += new System.EventHandler(this.MenuViewFullSizeOnClick);
            // 
            // _menuViewFitWidth
            // 
            this._menuViewFitWidth.Name = "_menuViewFitWidth";
            this._menuViewFitWidth.Size = new System.Drawing.Size(152, 22);
            this._menuViewFitWidth.Text = "Fit To Width";
            this._menuViewFitWidth.Click += new System.EventHandler(this.MenuViewFitWidthOnClick);
            // 
            // _menuViewBestFit
            // 
            this._menuViewBestFit.Image = ((System.Drawing.Image)(resources.GetObject("_menuViewBestFit.Image")));
            this._menuViewBestFit.Name = "_menuViewBestFit";
            this._menuViewBestFit.Size = new System.Drawing.Size(152, 22);
            this._menuViewBestFit.Text = "Best Fit";
            this._menuViewBestFit.Click += new System.EventHandler(this.MenuViewBestFitOnClick);
            // 
            // _menuOptions
            // 
            this._menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuPdfDecoderSettings});
            this._menuOptions.Name = "_menuOptions";
            this._menuOptions.Size = new System.Drawing.Size(61, 20);
            this._menuOptions.Text = "Options";
            // 
            // _menuPdfDecoderSettings
            // 
            this._menuPdfDecoderSettings.Name = "_menuPdfDecoderSettings";
            this._menuPdfDecoderSettings.Size = new System.Drawing.Size(185, 22);
            this._menuPdfDecoderSettings.Text = "PDF decoder settings";
            this._menuPdfDecoderSettings.Click += new System.EventHandler(this.MenuPdfDecoderSettingsOnClick);
            // 
            // _menuHelp
            // 
            this._menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuAbout});
            this._menuHelp.Name = "_menuHelp";
            this._menuHelp.Size = new System.Drawing.Size(44, 20);
            this._menuHelp.Text = "Help";
            // 
            // _menuAbout
            // 
            this._menuAbout.Name = "_menuAbout";
            this._menuAbout.Size = new System.Drawing.Size(119, 22);
            this._menuAbout.Text = "About ...";
            this._menuAbout.Click += new System.EventHandler(this.MenuAboutOnClick);
            // 
            // _menuFile
            // 
            this._menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuOpen,
            this._menuSave,
            this._menuItemFind,
            this._menuExtractImages,
            this._menuGetInfo,
            this._menuItemSplitter,
            this._menuPrint});
            this._menuFile.Name = "_menuFile";
            this._menuFile.Size = new System.Drawing.Size(37, 20);
            this._menuFile.Text = "File";
            // 
            // _menuOpen
            // 
            this._menuOpen.Image = ((System.Drawing.Image)(resources.GetObject("_menuOpen.Image")));
            this._menuOpen.Name = "_menuOpen";
            this._menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._menuOpen.Size = new System.Drawing.Size(158, 22);
            this._menuOpen.Text = "Open";
            this._menuOpen.Click += new System.EventHandler(this.MenuOpenOnClick);
            // 
            // _menuSave
            // 
            this._menuSave.Name = "_menuSave";
            this._menuSave.Size = new System.Drawing.Size(158, 22);
            this._menuSave.Text = "Save As";
            this._menuSave.Click += new System.EventHandler(this.MenuSaveOnClick);
            // 
            // _menuItemFind
            // 
            this._menuItemFind.Enabled = false;
            this._menuItemFind.Image = ((System.Drawing.Image)(resources.GetObject("_menuItemFind.Image")));
            this._menuItemFind.Name = "_menuItemFind";
            this._menuItemFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this._menuItemFind.Size = new System.Drawing.Size(158, 22);
            this._menuItemFind.Text = "Find ...";
            this._menuItemFind.Click += new System.EventHandler(this.MenuItemFindOnClick);
            // 
            // _menuExtractImages
            // 
            this._menuExtractImages.Name = "_menuExtractImages";
            this._menuExtractImages.Size = new System.Drawing.Size(158, 22);
            this._menuExtractImages.Text = "Extract Images";
            this._menuExtractImages.Click += new System.EventHandler(this.MenuExtractImagesOnClick);
            // 
            // _menuGetInfo
            // 
            this._menuGetInfo.Name = "_menuGetInfo";
            this._menuGetInfo.Size = new System.Drawing.Size(158, 22);
            this._menuGetInfo.Text = "Get Information";
            this._menuGetInfo.Click += new System.EventHandler(this.MenuGetInfoOnClick);
            // 
            // _menuItemSplitter
            // 
            this._menuItemSplitter.Name = "_menuItemSplitter";
            this._menuItemSplitter.Size = new System.Drawing.Size(155, 6);
            // 
            // _menuPrint
            // 
            this._menuPrint.Image = ((System.Drawing.Image)(resources.GetObject("_menuPrint.Image")));
            this._menuPrint.Name = "_menuPrint";
            this._menuPrint.Size = new System.Drawing.Size(158, 22);
            this._menuPrint.Text = "Print ... ";
            this._menuPrint.Click += new System.EventHandler(this.MenuPrintOnClick);
            // 
            // _openFileDialog
            // 
            this._openFileDialog.DefaultExt = "pdf";
            this._openFileDialog.Filter = "PDF Files|*.pdf|All Files|*.*";
            // 
            // _saveFileDialog
            // 
            this._saveFileDialog.DefaultExt = "pdf";
            this._saveFileDialog.Filter = "PDF File(*.pdf)|*.pdf|TIFF File(*tif)|*.tif|JPEG File(*.jpg)|*.jpg";
            // 
            // _statusBar
            // 
            this._statusBar.Location = new System.Drawing.Point(0, 686);
            this._statusBar.Name = "_statusBar";
            this._statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this._statusBarPanel,
            this._statusProgress});
            this._statusBar.ShowPanels = true;
            this._statusBar.Size = new System.Drawing.Size(960, 22);
            this._statusBar.TabIndex = 1;
            // 
            // _statusBarPanel
            // 
            this._statusBarPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this._statusBarPanel.Name = "_statusBarPanel";
            this._statusBarPanel.Width = 643;
            // 
            // _statusProgress
            // 
            this._statusProgress.Name = "_statusProgress";
            this._statusProgress.Width = 300;
            // 
            // _progressBar
            // 
            this._progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._progressBar.Location = new System.Drawing.Point(646, 688);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(300, 20);
            this._progressBar.TabIndex = 3;
            // 
            // _toolStripContainer
            // 
            // 
            // _toolStripContainer.ContentPanel
            // 
            this._toolStripContainer.ContentPanel.Controls.Add(this._workspaceViewer);
            this._toolStripContainer.ContentPanel.Controls.Add(this._splitter);
            this._toolStripContainer.ContentPanel.Controls.Add(this._tabControl);
            this._toolStripContainer.ContentPanel.Size = new System.Drawing.Size(960, 623);
            this._toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this._toolStripContainer.Name = "_toolStripContainer";
            this._toolStripContainer.Size = new System.Drawing.Size(960, 686);
            this._toolStripContainer.TabIndex = 6;
            this._toolStripContainer.Text = "toolStripContainer1";
            // 
            // _toolStripContainer.TopToolStripPanel
            // 
            this._toolStripContainer.TopToolStripPanel.Controls.Add(this._mainMenu);
            this._toolStripContainer.TopToolStripPanel.Controls.Add(this._toolStripMenu);
            // 
            // _workspaceViewer
            // 
            this._workspaceViewer.AntialiasDisplay = Atalasoft.Imaging.WinControls.AntialiasDisplayMode.ReductionOnly;
            this._workspaceViewer.Asynchronous = true;
            this._workspaceViewer.BackColor = System.Drawing.SystemColors.Control;
            this._workspaceViewer.Centered = true;
            this._workspaceViewer.DefaultSecurity = null;
            this._workspaceViewer.DisplayProfile = null;
            this._workspaceViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._workspaceViewer.Location = new System.Drawing.Point(212, 0);
            this._workspaceViewer.Magnifier.BackColor = System.Drawing.Color.White;
            this._workspaceViewer.Magnifier.BorderColor = System.Drawing.Color.Black;
            this._workspaceViewer.Magnifier.Size = new System.Drawing.Size(100, 100);
            this._workspaceViewer.MouseWheelScrolling = true;
            this._workspaceViewer.Name = "_workspaceViewer";
            this._workspaceViewer.OutputProfile = null;
            this._workspaceViewer.RotationSnapInterval = 0F;
            this._workspaceViewer.RotationSnapThreshold = 0F;
            this._workspaceViewer.Selection = null;
            this._workspaceViewer.Size = new System.Drawing.Size(748, 623);
            this._workspaceViewer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this._workspaceViewer.TabIndex = 6;
            this._workspaceViewer.Text = "workspaceViewer1";
            this._workspaceViewer.ToolTip = null;
            this._workspaceViewer.UndoManager.Levels = 0;
            this._workspaceViewer.ProcessError += new Atalasoft.Imaging.ExceptionEventHandler(this.WorkspaceViewerOnProcessError);
            this._workspaceViewer.ImageChanged += new Atalasoft.Imaging.ImageEventHandler(this.WorkspaceViewerOnChangedImage);
            // 
            // _splitter
            // 
            this._splitter.Location = new System.Drawing.Point(206, 0);
            this._splitter.Name = "_splitter";
            this._splitter.Size = new System.Drawing.Size(6, 623);
            this._splitter.TabIndex = 8;
            this._splitter.TabStop = false;
            // 
            // _tabControl
            // 
            this._tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this._tabControl.Controls.Add(this._tabPages);
            this._tabControl.Controls.Add(this._tabBookmarks);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this._tabControl.ItemSize = new System.Drawing.Size(35, 35);
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Multiline = true;
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(206, 623);
            this._tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this._tabControl.TabIndex = 7;
            // 
            // _tabPages
            // 
            this._tabPages.Controls.Add(this._pagesLabel);
            this._tabPages.Controls.Add(this._thumbnailView);
            this._tabPages.ImageIndex = 0;
            this._tabPages.Location = new System.Drawing.Point(39, 4);
            this._tabPages.Name = "_tabPages";
            this._tabPages.Padding = new System.Windows.Forms.Padding(3);
            this._tabPages.Size = new System.Drawing.Size(163, 615);
            this._tabPages.TabIndex = 0;
            this._tabPages.ToolTipText = "Pages";
            this._tabPages.UseVisualStyleBackColor = true;
            // 
            // _pagesLabel
            // 
            this._pagesLabel.AutoSize = true;
            this._pagesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._pagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pagesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._pagesLabel.Location = new System.Drawing.Point(3, 3);
            this._pagesLabel.Name = "_pagesLabel";
            this._pagesLabel.Size = new System.Drawing.Size(48, 17);
            this._pagesLabel.TabIndex = 0;
            this._pagesLabel.Text = "Pages";
            // 
            // _thumbnailView
            // 
            this._thumbnailView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._thumbnailView.BackColor = System.Drawing.Color.Gainsboro;
            this._thumbnailView.CaptionLines = 1;
            this._thumbnailView.CaptionSpacing = 2;
            this._thumbnailView.DragSelectionColor = System.Drawing.Color.Red;
            this._thumbnailView.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._thumbnailView.HighlightBackgroundColor = System.Drawing.SystemColors.Highlight;
            this._thumbnailView.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            this._thumbnailView.LoadErrorMessage = "";
            this._thumbnailView.LoadMethod = Atalasoft.Imaging.WinControls.ThumbLoadMethod.EntireFolder;
            this._thumbnailView.Location = new System.Drawing.Point(3, 23);
            this._thumbnailView.Margins = new Atalasoft.Imaging.WinControls.Margin(4, 4, 4, 4);
            this._thumbnailView.Name = "_thumbnailView";
            this._thumbnailView.SelectedItemStyle = Atalasoft.Imaging.WinControls.SelectedItemRenderStyle.Full;
            this._thumbnailView.SelectionRectangleBackColor = System.Drawing.Color.Transparent;
            this._thumbnailView.SelectionRectangleDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this._thumbnailView.SelectionRectangleLineColor = System.Drawing.Color.Black;
            this._thumbnailView.Size = new System.Drawing.Size(157, 589);
            this._thumbnailView.TabIndex = 2;
            this._thumbnailView.Text = "thumbnailView1";
            this._thumbnailView.ThumbnailBackground = null;
            this._thumbnailView.ThumbnailOffset = new System.Drawing.Point(0, 0);
            this._thumbnailView.ThumbnailSize = new System.Drawing.Size(100, 100);
            this._thumbnailView.SelectedIndexChanged += new System.EventHandler(this.ThumbnailViewOnSelectedIndexChanged);
            this._thumbnailView.ThumbnailCreated += new Atalasoft.Imaging.WinControls.ThumbnailEventHandler(this.ThumbnailViewOnThumbnailLoad);
            // 
            // _tabBookmarks
            // 
            this._tabBookmarks.Controls.Add(this._bookmarksLabel);
            this._tabBookmarks.Controls.Add(this._treeBookmarks);
            this._tabBookmarks.ImageIndex = 1;
            this._tabBookmarks.Location = new System.Drawing.Point(39, 4);
            this._tabBookmarks.Name = "_tabBookmarks";
            this._tabBookmarks.Padding = new System.Windows.Forms.Padding(3);
            this._tabBookmarks.Size = new System.Drawing.Size(163, 615);
            this._tabBookmarks.TabIndex = 1;
            this._tabBookmarks.ToolTipText = "Bookmarks";
            this._tabBookmarks.UseVisualStyleBackColor = true;
            // 
            // _bookmarksLabel
            // 
            this._bookmarksLabel.AutoSize = true;
            this._bookmarksLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._bookmarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bookmarksLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._bookmarksLabel.Location = new System.Drawing.Point(3, 3);
            this._bookmarksLabel.Name = "_bookmarksLabel";
            this._bookmarksLabel.Size = new System.Drawing.Size(78, 17);
            this._bookmarksLabel.TabIndex = 1;
            this._bookmarksLabel.Text = "Bookmarks";
            // 
            // _treeBookmarks
            // 
            this._treeBookmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._treeBookmarks.BackColor = System.Drawing.Color.Gainsboro;
            this._treeBookmarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._treeBookmarks.ForeColor = System.Drawing.Color.Black;
            this._treeBookmarks.Location = new System.Drawing.Point(3, 23);
            this._treeBookmarks.Name = "_treeBookmarks";
            this._treeBookmarks.Size = new System.Drawing.Size(157, 589);
            this._treeBookmarks.TabIndex = 0;
            this._treeBookmarks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeBookmarksOnAfterSelect);
            // 
            // _mainMenu
            // 
            this._mainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this._mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuFile,
            this._menuView,
            this._menuOptions,
            this._menuHelp});
            this._mainMenu.Location = new System.Drawing.Point(0, 0);
            this._mainMenu.Name = "_mainMenu";
            this._mainMenu.Size = new System.Drawing.Size(960, 24);
            this._mainMenu.TabIndex = 1;
            this._mainMenu.Text = "_mainMenu";
            // 
            // _toolStripMenu
            // 
            this._toolStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this._toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openButton,
            this._findButton,
            this._printButton});
            this._toolStripMenu.Location = new System.Drawing.Point(3, 24);
            this._toolStripMenu.Name = "_toolStripMenu";
            this._toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._toolStripMenu.Size = new System.Drawing.Size(120, 39);
            this._toolStripMenu.TabIndex = 0;
            // 
            // _openButton
            // 
            this._openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._openButton.Image = ((System.Drawing.Image)(resources.GetObject("_openButton.Image")));
            this._openButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._openButton.Name = "_openButton";
            this._openButton.Size = new System.Drawing.Size(36, 36);
            this._openButton.Text = "toolStripButton1";
            this._openButton.ToolTipText = "Open File";
            this._openButton.Click += new System.EventHandler(this.MenuOpenOnClick);
            // 
            // _findButton
            // 
            this._findButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._findButton.Image = ((System.Drawing.Image)(resources.GetObject("_findButton.Image")));
            this._findButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._findButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._findButton.Name = "_findButton";
            this._findButton.Size = new System.Drawing.Size(36, 36);
            this._findButton.Text = "toolStripButton1";
            this._findButton.ToolTipText = "Find";
            this._findButton.Click += new System.EventHandler(this.MenuItemFindOnClick);
            // 
            // _printButton
            // 
            this._printButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._printButton.Image = ((System.Drawing.Image)(resources.GetObject("_printButton.Image")));
            this._printButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._printButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._printButton.Name = "_printButton";
            this._printButton.Size = new System.Drawing.Size(36, 36);
            this._printButton.Text = "toolStripButton1";
            this._printButton.ToolTipText = "Print document";
            this._printButton.Click += new System.EventHandler(this.MenuPrintOnClick);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(960, 708);
            this.Controls.Add(this._toolStripContainer);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._statusBar);
            this.MainMenuStrip = this._mainMenu;
            this.Name = "MainForm";
            this.Text = "Atalasoft PDF Viewer Demo";
            ((System.ComponentModel.ISupportInitialize)(this._statusBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusProgress)).EndInit();
            this._toolStripContainer.ContentPanel.ResumeLayout(false);
            this._toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this._toolStripContainer.TopToolStripPanel.PerformLayout();
            this._toolStripContainer.ResumeLayout(false);
            this._toolStripContainer.PerformLayout();
            this._tabControl.ResumeLayout(false);
            this._tabPages.ResumeLayout(false);
            this._tabPages.PerformLayout();
            this._tabBookmarks.ResumeLayout(false);
            this._tabBookmarks.PerformLayout();
            this._mainMenu.ResumeLayout(false);
            this._mainMenu.PerformLayout();
            this._toolStripMenu.ResumeLayout(false);
            this._toolStripMenu.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.ToolTip _toolTip;
		private System.Windows.Forms.ProgressBar _progressBar;
		private System.Windows.Forms.StatusBarPanel _statusProgress;
		private System.Windows.Forms.StatusBarPanel _statusBarPanel;
		private System.Windows.Forms.StatusBar _statusBar;
		private System.Windows.Forms.SaveFileDialog _saveFileDialog;
		private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem _menuHelp;
        private System.Windows.Forms.ToolStripMenuItem _menuAbout;
        private System.Windows.Forms.ToolStripMenuItem _menuViewBestFit;
        private System.Windows.Forms.ToolStripMenuItem _menuViewFitWidth;
        private System.Windows.Forms.ToolStripMenuItem _menuViewFullSize;
        private System.Windows.Forms.ToolStripMenuItem _menuView;
        private System.Windows.Forms.ToolStripMenuItem _menuPrint;
        private System.Windows.Forms.ToolStripSeparator _menuItemSplitter;
        private System.Windows.Forms.ToolStripMenuItem _menuGetInfo;
        private System.Windows.Forms.ToolStripMenuItem _menuExtractImages;
        private System.Windows.Forms.ToolStripMenuItem _menuItemFind;
        private System.Windows.Forms.ToolStripMenuItem _menuSave;
        private System.Windows.Forms.ToolStripMenuItem _menuOpen;
        private System.Windows.Forms.ToolStripMenuItem _menuFile;
        private System.Windows.Forms.ToolStripMenuItem _menuOptions;
        private System.Windows.Forms.ToolStripMenuItem _menuPdfDecoderSettings;
        private System.Windows.Forms.ToolStripContainer _toolStripContainer;
        private Annotate.UI.AnnotateViewer _workspaceViewer;
        private System.Windows.Forms.Splitter _splitter;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPages;
        private Imaging.WinControls.ThumbnailView _thumbnailView;
        private System.Windows.Forms.TabPage _tabBookmarks;
        private System.Windows.Forms.TreeView _treeBookmarks;
        private System.Windows.Forms.ToolStrip _toolStripMenu;
        private System.Windows.Forms.ToolStripButton _openButton;
        private System.Windows.Forms.ToolStripButton _findButton;
        private System.Windows.Forms.ToolStripButton _printButton;
        private System.Windows.Forms.MenuStrip _mainMenu;
        private System.Windows.Forms.Label _pagesLabel;
        private System.Windows.Forms.Label _bookmarksLabel;
	}
}

