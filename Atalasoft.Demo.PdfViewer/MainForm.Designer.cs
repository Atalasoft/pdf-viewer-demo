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
            this._fileMenuSplitter = new System.Windows.Forms.ToolStripSeparator();
            this._exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this._statusBar = new System.Windows.Forms.StatusBar();
            this._statusBarPanel = new System.Windows.Forms.StatusBarPanel();
            this._statusProgress = new System.Windows.Forms.StatusBarPanel();
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
            this._toolStripMenu = new System.Windows.Forms.ToolStrip();
            this._openButton = new System.Windows.Forms.ToolStripButton();
            this._findButton = new System.Windows.Forms.ToolStripButton();
            this._printButton = new System.Windows.Forms.ToolStripButton();
            this._mouseToolStripMenu = new System.Windows.Forms.ToolStrip();
            this._panButton = new System.Windows.Forms.ToolStripButton();
            this._magnifierButton = new System.Windows.Forms.ToolStripButton();
            this._zoomButton = new System.Windows.Forms.ToolStripButton();
            this._zoomAreaButton = new System.Windows.Forms.ToolStripButton();
            this._navigationToolStrip = new System.Windows.Forms.ToolStrip();
            this._previousPageButton = new System.Windows.Forms.ToolStripButton();
            this._nextPageButton = new System.Windows.Forms.ToolStripButton();
            this._toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._currentPageBox = new System.Windows.Forms.ToolStripTextBox();
            this._totalPageLabel = new System.Windows.Forms.ToolStripLabel();
            this._zoomToolStrip = new System.Windows.Forms.ToolStrip();
            this._fullSizeButton = new System.Windows.Forms.ToolStripButton();
            this._fitWidthButton = new System.Windows.Forms.ToolStripButton();
            this._bestFitButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._zoomInButton = new System.Windows.Forms.ToolStripButton();
            this._zoomOutButton = new System.Windows.Forms.ToolStripButton();
            this._mainMenu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this._statusBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusProgress)).BeginInit();
            this._toolStripContainer.ContentPanel.SuspendLayout();
            this._toolStripContainer.TopToolStripPanel.SuspendLayout();
            this._toolStripContainer.SuspendLayout();
            this._tabControl.SuspendLayout();
            this._tabPages.SuspendLayout();
            this._tabBookmarks.SuspendLayout();
            this._toolStripMenu.SuspendLayout();
            this._mouseToolStripMenu.SuspendLayout();
            this._navigationToolStrip.SuspendLayout();
            this._zoomToolStrip.SuspendLayout();
            this._mainMenu.SuspendLayout();
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
            this._menuView.Text = "&View";
            // 
            // _menuViewFullSize
            // 
            this._menuViewFullSize.Image = ((System.Drawing.Image)(resources.GetObject("_menuViewFullSize.Image")));
            this._menuViewFullSize.Name = "_menuViewFullSize";
            this._menuViewFullSize.Size = new System.Drawing.Size(139, 22);
            this._menuViewFullSize.Tag = Atalasoft.Imaging.WinControls.AutoZoomMode.None;
            this._menuViewFullSize.Text = "Full Size";
            this._menuViewFullSize.Click += new System.EventHandler(this.MenuViewItemOnClick);
            // 
            // _menuViewFitWidth
            // 
            this._menuViewFitWidth.Image = ((System.Drawing.Image)(resources.GetObject("_menuViewFitWidth.Image")));
            this._menuViewFitWidth.Name = "_menuViewFitWidth";
            this._menuViewFitWidth.Size = new System.Drawing.Size(139, 22);
            this._menuViewFitWidth.Tag = Atalasoft.Imaging.WinControls.AutoZoomMode.FitToWidth;
            this._menuViewFitWidth.Text = "Fit To Width";
            this._menuViewFitWidth.Click += new System.EventHandler(this.MenuViewItemOnClick);
            // 
            // _menuViewBestFit
            // 
            this._menuViewBestFit.Image = ((System.Drawing.Image)(resources.GetObject("_menuViewBestFit.Image")));
            this._menuViewBestFit.Name = "_menuViewBestFit";
            this._menuViewBestFit.Size = new System.Drawing.Size(139, 22);
            this._menuViewBestFit.Tag = Atalasoft.Imaging.WinControls.AutoZoomMode.BestFit;
            this._menuViewBestFit.Text = "Best Fit";
            this._menuViewBestFit.Click += new System.EventHandler(this.MenuViewItemOnClick);
            // 
            // _menuOptions
            // 
            this._menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuPdfDecoderSettings});
            this._menuOptions.Name = "_menuOptions";
            this._menuOptions.Size = new System.Drawing.Size(61, 20);
            this._menuOptions.Text = "&Options";
            // 
            // _menuPdfDecoderSettings
            // 
            this._menuPdfDecoderSettings.Name = "_menuPdfDecoderSettings";
            this._menuPdfDecoderSettings.Size = new System.Drawing.Size(185, 22);
            this._menuPdfDecoderSettings.Text = "&PDF decoder settings";
            this._menuPdfDecoderSettings.Click += new System.EventHandler(this.MenuPdfDecoderSettingsOnClick);
            // 
            // _menuHelp
            // 
            this._menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuAbout});
            this._menuHelp.Name = "_menuHelp";
            this._menuHelp.Size = new System.Drawing.Size(44, 20);
            this._menuHelp.Text = "&Help";
            // 
            // _menuAbout
            // 
            this._menuAbout.Name = "_menuAbout";
            this._menuAbout.Size = new System.Drawing.Size(119, 22);
            this._menuAbout.Text = "&About ...";
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
            this._menuPrint,
            this._fileMenuSplitter,
            this._exitButton});
            this._menuFile.Name = "_menuFile";
            this._menuFile.Size = new System.Drawing.Size(37, 20);
            this._menuFile.Text = "&File";
            // 
            // _menuOpen
            // 
            this._menuOpen.Image = ((System.Drawing.Image)(resources.GetObject("_menuOpen.Image")));
            this._menuOpen.Name = "_menuOpen";
            this._menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._menuOpen.Size = new System.Drawing.Size(158, 22);
            this._menuOpen.Text = "&Open";
            this._menuOpen.Click += new System.EventHandler(this.MenuOpenOnClick);
            // 
            // _menuSave
            // 
            this._menuSave.Name = "_menuSave";
            this._menuSave.Size = new System.Drawing.Size(158, 22);
            this._menuSave.Text = "&Save As";
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
            this._menuExtractImages.Text = "&Extract Images";
            this._menuExtractImages.Click += new System.EventHandler(this.MenuExtractImagesOnClick);
            // 
            // _menuGetInfo
            // 
            this._menuGetInfo.Name = "_menuGetInfo";
            this._menuGetInfo.Size = new System.Drawing.Size(158, 22);
            this._menuGetInfo.Text = "&Get Information";
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
            this._menuPrint.Text = "&Print ... ";
            this._menuPrint.Click += new System.EventHandler(this.MenuPrintOnClick);
            // 
            // _fileMenuSplitter
            // 
            this._fileMenuSplitter.Name = "_fileMenuSplitter";
            this._fileMenuSplitter.Size = new System.Drawing.Size(155, 6);
            // 
            // _exitButton
            // 
            this._exitButton.Name = "_exitButton";
            this._exitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._exitButton.Size = new System.Drawing.Size(158, 22);
            this._exitButton.Text = "E&xit";
            this._exitButton.Click += new System.EventHandler(this.MenuExitOnClick);
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
            // _toolStripContainer
            // 
            this._toolStripContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // _toolStripContainer.ContentPanel
            // 
            this._toolStripContainer.ContentPanel.Controls.Add(this._workspaceViewer);
            this._toolStripContainer.ContentPanel.Controls.Add(this._splitter);
            this._toolStripContainer.ContentPanel.Controls.Add(this._tabControl);
            this._toolStripContainer.ContentPanel.Size = new System.Drawing.Size(960, 620);
            this._toolStripContainer.Location = new System.Drawing.Point(0, 27);
            this._toolStripContainer.Name = "_toolStripContainer";
            this._toolStripContainer.Size = new System.Drawing.Size(960, 659);
            this._toolStripContainer.TabIndex = 6;
            this._toolStripContainer.Text = "toolStripContainer1";
            // 
            // _toolStripContainer.TopToolStripPanel
            // 
            this._toolStripContainer.TopToolStripPanel.Controls.Add(this._zoomToolStrip);
            this._toolStripContainer.TopToolStripPanel.Controls.Add(this._navigationToolStrip);
            this._toolStripContainer.TopToolStripPanel.Controls.Add(this._toolStripMenu);
            this._toolStripContainer.TopToolStripPanel.Controls.Add(this._mouseToolStripMenu);
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
            this._workspaceViewer.Size = new System.Drawing.Size(748, 620);
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
            this._splitter.Size = new System.Drawing.Size(6, 620);
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
            this._tabControl.Size = new System.Drawing.Size(206, 620);
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
            this._tabPages.Size = new System.Drawing.Size(163, 612);
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
            // 
            // _tabBookmarks
            // 
            this._tabBookmarks.Controls.Add(this._bookmarksLabel);
            this._tabBookmarks.Controls.Add(this._treeBookmarks);
            this._tabBookmarks.ImageIndex = 1;
            this._tabBookmarks.Location = new System.Drawing.Point(39, 4);
            this._tabBookmarks.Name = "_tabBookmarks";
            this._tabBookmarks.Padding = new System.Windows.Forms.Padding(3);
            this._tabBookmarks.Size = new System.Drawing.Size(163, 534);
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
            this._treeBookmarks.Size = new System.Drawing.Size(157, 508);
            this._treeBookmarks.TabIndex = 0;
            this._treeBookmarks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeBookmarksOnAfterSelect);
            // 
            // _toolStripMenu
            // 
            this._toolStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this._toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openButton,
            this._findButton,
            this._printButton});
            this._toolStripMenu.Location = new System.Drawing.Point(3, 0);
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
            // _mouseToolStripMenu
            // 
            this._mouseToolStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this._mouseToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._panButton,
            this._magnifierButton,
            this._zoomButton,
            this._zoomAreaButton});
            this._mouseToolStripMenu.Location = new System.Drawing.Point(480, 0);
            this._mouseToolStripMenu.Name = "_mouseToolStripMenu";
            this._mouseToolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._mouseToolStripMenu.Size = new System.Drawing.Size(187, 39);
            this._mouseToolStripMenu.TabIndex = 2;
            // 
            // _panButton
            // 
            this._panButton.CheckOnClick = true;
            this._panButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._panButton.Image = ((System.Drawing.Image)(resources.GetObject("_panButton.Image")));
            this._panButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._panButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._panButton.Name = "_panButton";
            this._panButton.Size = new System.Drawing.Size(36, 36);
            this._panButton.Tag = Atalasoft.Imaging.WinControls.MouseToolType.Pan;
            this._panButton.Text = "toolStripButton1";
            this._panButton.ToolTipText = "Pan";
            this._panButton.CheckedChanged += new System.EventHandler(this.MouseToolButtonsOnCheckedChanged);
            // 
            // _magnifierButton
            // 
            this._magnifierButton.CheckOnClick = true;
            this._magnifierButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._magnifierButton.Image = ((System.Drawing.Image)(resources.GetObject("_magnifierButton.Image")));
            this._magnifierButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._magnifierButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._magnifierButton.Name = "_magnifierButton";
            this._magnifierButton.Size = new System.Drawing.Size(36, 36);
            this._magnifierButton.Tag = Atalasoft.Imaging.WinControls.MouseToolType.Magnifier;
            this._magnifierButton.Text = "toolStripButton1";
            this._magnifierButton.ToolTipText = "Magnifier";
            this._magnifierButton.CheckedChanged += new System.EventHandler(this.MouseToolButtonsOnCheckedChanged);
            // 
            // _zoomButton
            // 
            this._zoomButton.CheckOnClick = true;
            this._zoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._zoomButton.Image = ((System.Drawing.Image)(resources.GetObject("_zoomButton.Image")));
            this._zoomButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._zoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._zoomButton.Name = "_zoomButton";
            this._zoomButton.Size = new System.Drawing.Size(36, 36);
            this._zoomButton.Tag = Atalasoft.Imaging.WinControls.MouseToolType.Zoom;
            this._zoomButton.Text = "toolStripButton1";
            this._zoomButton.ToolTipText = "Zoom";
            this._zoomButton.CheckedChanged += new System.EventHandler(this.MouseToolButtonsOnCheckedChanged);
            // 
            // _zoomAreaButton
            // 
            this._zoomAreaButton.CheckOnClick = true;
            this._zoomAreaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._zoomAreaButton.Image = ((System.Drawing.Image)(resources.GetObject("_zoomAreaButton.Image")));
            this._zoomAreaButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._zoomAreaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._zoomAreaButton.Name = "_zoomAreaButton";
            this._zoomAreaButton.Size = new System.Drawing.Size(36, 36);
            this._zoomAreaButton.Tag = Atalasoft.Imaging.WinControls.MouseToolType.ZoomArea;
            this._zoomAreaButton.Text = "toolStripButton1";
            this._zoomAreaButton.ToolTipText = "Zoom Area";
            this._zoomAreaButton.CheckedChanged += new System.EventHandler(this.MouseToolButtonsOnCheckedChanged);
            // 
            // _navigationToolStrip
            // 
            this._navigationToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._navigationToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._previousPageButton,
            this._nextPageButton,
            this._toolStripSeparator,
            this._currentPageBox,
            this._totalPageLabel});
            this._navigationToolStrip.Location = new System.Drawing.Point(123, 0);
            this._navigationToolStrip.Name = "_navigationToolStrip";
            this._navigationToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._navigationToolStrip.Size = new System.Drawing.Size(159, 39);
            this._navigationToolStrip.TabIndex = 3;
            // 
            // _previousPageButton
            // 
            this._previousPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._previousPageButton.Image = ((System.Drawing.Image)(resources.GetObject("_previousPageButton.Image")));
            this._previousPageButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._previousPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._previousPageButton.Name = "_previousPageButton";
            this._previousPageButton.Size = new System.Drawing.Size(36, 36);
            this._previousPageButton.Text = "toolStripButton1";
            this._previousPageButton.ToolTipText = "Previous Page";
            this._previousPageButton.Click += new System.EventHandler(this.PreviousPageButtonOnClick);
            // 
            // _nextPageButton
            // 
            this._nextPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._nextPageButton.Image = ((System.Drawing.Image)(resources.GetObject("_nextPageButton.Image")));
            this._nextPageButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._nextPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._nextPageButton.Name = "_nextPageButton";
            this._nextPageButton.Size = new System.Drawing.Size(36, 36);
            this._nextPageButton.Text = "toolStripButton2";
            this._nextPageButton.ToolTipText = "Next Page";
            this._nextPageButton.Click += new System.EventHandler(this.NextPageButtonOnClick);
            // 
            // _toolStripSeparator
            // 
            this._toolStripSeparator.Name = "_toolStripSeparator";
            this._toolStripSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // _currentPageBox
            // 
            this._currentPageBox.Name = "_currentPageBox";
            this._currentPageBox.Size = new System.Drawing.Size(40, 39);
            this._currentPageBox.Leave += new System.EventHandler(this.CurrentPageBoxOnLeave);
            this._currentPageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CurrentPageBoxOnKeyDown);
            this._currentPageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentPageBoxOnKeyPress);
            // 
            // _totalPageLabel
            // 
            this._totalPageLabel.Name = "_totalPageLabel";
            this._totalPageLabel.Size = new System.Drawing.Size(27, 36);
            this._totalPageLabel.Text = "of 0";
            // 
            // _zoomToolStrip
            // 
            this._zoomToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._zoomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fullSizeButton,
            this._fitWidthButton,
            this._bestFitButton,
            this.toolStripSeparator1,
            this._zoomInButton,
            this._zoomOutButton});
            this._zoomToolStrip.Location = new System.Drawing.Point(282, 0);
            this._zoomToolStrip.Name = "_zoomToolStrip";
            this._zoomToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._zoomToolStrip.Size = new System.Drawing.Size(198, 39);
            this._zoomToolStrip.TabIndex = 4;
            // 
            // _fullSizeButton
            // 
            this._fullSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._fullSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("_fullSizeButton.Image")));
            this._fullSizeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._fullSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._fullSizeButton.Name = "_fullSizeButton";
            this._fullSizeButton.Size = new System.Drawing.Size(36, 36);
            this._fullSizeButton.Tag = Atalasoft.Imaging.WinControls.AutoZoomMode.None;
            this._fullSizeButton.Text = "toolStripButton1";
            this._fullSizeButton.ToolTipText = "Full Size";
            this._fullSizeButton.Click += new System.EventHandler(this.MenuViewItemOnClick);
            // 
            // _fitWidthButton
            // 
            this._fitWidthButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._fitWidthButton.Image = ((System.Drawing.Image)(resources.GetObject("_fitWidthButton.Image")));
            this._fitWidthButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._fitWidthButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._fitWidthButton.Name = "_fitWidthButton";
            this._fitWidthButton.Size = new System.Drawing.Size(36, 36);
            this._fitWidthButton.Tag = Atalasoft.Imaging.WinControls.AutoZoomMode.FitToWidth;
            this._fitWidthButton.Text = "toolStripButton1";
            this._fitWidthButton.ToolTipText = "Fit to Width";
            this._fitWidthButton.Click += new System.EventHandler(this.MenuViewItemOnClick);
            // 
            // _bestFitButton
            // 
            this._bestFitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._bestFitButton.Image = ((System.Drawing.Image)(resources.GetObject("_bestFitButton.Image")));
            this._bestFitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._bestFitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._bestFitButton.Name = "_bestFitButton";
            this._bestFitButton.Size = new System.Drawing.Size(36, 36);
            this._bestFitButton.Tag = Atalasoft.Imaging.WinControls.AutoZoomMode.BestFit;
            this._bestFitButton.Text = "toolStripButton1";
            this._bestFitButton.ToolTipText = "Best Fit";
            this._bestFitButton.Click += new System.EventHandler(this.MenuViewItemOnClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // _zoomInButton
            // 
            this._zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._zoomInButton.Image = ((System.Drawing.Image)(resources.GetObject("_zoomInButton.Image")));
            this._zoomInButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._zoomInButton.Name = "_zoomInButton";
            this._zoomInButton.Size = new System.Drawing.Size(36, 36);
            this._zoomInButton.Text = "toolStripButton1";
            this._zoomInButton.ToolTipText = "Zoom In";
            this._zoomInButton.Click += new System.EventHandler(this.ZoomInButtonOnClick);
            // 
            // _zoomOutButton
            // 
            this._zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._zoomOutButton.Image = ((System.Drawing.Image)(resources.GetObject("_zoomOutButton.Image")));
            this._zoomOutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._zoomOutButton.Name = "_zoomOutButton";
            this._zoomOutButton.Size = new System.Drawing.Size(36, 36);
            this._zoomOutButton.Text = "toolStripButton1";
            this._zoomOutButton.ToolTipText = "Zoom Out";
            this._zoomOutButton.Click += new System.EventHandler(this.ZoomOutButtonOnClick);
            // 
            // _mainMenu
            // 
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
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(960, 708);
            this.Controls.Add(this._mainMenu);
            this.Controls.Add(this._toolStripContainer);
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
            this._toolStripMenu.ResumeLayout(false);
            this._toolStripMenu.PerformLayout();
            this._mouseToolStripMenu.ResumeLayout(false);
            this._mouseToolStripMenu.PerformLayout();
            this._navigationToolStrip.ResumeLayout(false);
            this._navigationToolStrip.PerformLayout();
            this._zoomToolStrip.ResumeLayout(false);
            this._zoomToolStrip.PerformLayout();
            this._mainMenu.ResumeLayout(false);
            this._mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.ToolTip _toolTip;
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
        private System.Windows.Forms.ToolStrip _mouseToolStripMenu;
        private System.Windows.Forms.ToolStripButton _panButton;
        private System.Windows.Forms.ToolStripButton _magnifierButton;
        private System.Windows.Forms.ToolStripButton _zoomButton;
        private System.Windows.Forms.ToolStripButton _zoomAreaButton;
        private System.Windows.Forms.ToolStripSeparator _fileMenuSplitter;
        private System.Windows.Forms.ToolStripMenuItem _exitButton;
        private System.Windows.Forms.ToolStrip _navigationToolStrip;
        private System.Windows.Forms.ToolStripButton _previousPageButton;
        private System.Windows.Forms.ToolStripButton _nextPageButton;
        private System.Windows.Forms.ToolStripSeparator _toolStripSeparator;
        private System.Windows.Forms.ToolStripTextBox _currentPageBox;
        private System.Windows.Forms.ToolStripLabel _totalPageLabel;
        private System.Windows.Forms.ToolStrip _zoomToolStrip;
        private System.Windows.Forms.ToolStripButton _fullSizeButton;
        private System.Windows.Forms.ToolStripButton _fitWidthButton;
        private System.Windows.Forms.ToolStripButton _bestFitButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _zoomInButton;
        private System.Windows.Forms.ToolStripButton _zoomOutButton;
	}
}

