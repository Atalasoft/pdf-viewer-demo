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
            this._workspaceViewer = new Atalasoft.Annotate.UI.AnnotateViewer();
            this._mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this._menuFile = new System.Windows.Forms.MenuItem();
            this._menuOpen = new System.Windows.Forms.MenuItem();
            this._menuSave = new System.Windows.Forms.MenuItem();
            this._menuItemFind = new System.Windows.Forms.MenuItem();
            this._menuExtractImages = new System.Windows.Forms.MenuItem();
            this._menuGetInfo = new System.Windows.Forms.MenuItem();
            this._menuItemSplitter = new System.Windows.Forms.MenuItem();
            this._menuPrint = new System.Windows.Forms.MenuItem();
            this._menuView = new System.Windows.Forms.MenuItem();
            this._menuViewFullSize = new System.Windows.Forms.MenuItem();
            this._menuViewFitWidth = new System.Windows.Forms.MenuItem();
            this._menuViewBestFit = new System.Windows.Forms.MenuItem();
            this._menuHelp = new System.Windows.Forms.MenuItem();
            this._menuAbout = new System.Windows.Forms.MenuItem();
            this._menuOptions = new System.Windows.Forms.MenuItem();
            this._menuPdfDecoderSettings = new System.Windows.Forms.MenuItem();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this._statusBar = new System.Windows.Forms.StatusBar();
            this._statusBarPanel = new System.Windows.Forms.StatusBarPanel();
            this._statusProgress = new System.Windows.Forms.StatusBarPanel();
            this._thumbnailView = new Atalasoft.Imaging.WinControls.ThumbnailView();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPages = new System.Windows.Forms.TabPage();
            this._tabBookmarks = new System.Windows.Forms.TabPage();
            this._treeBookmarks = new System.Windows.Forms.TreeView();
            this._splitter = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this._statusBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusProgress)).BeginInit();
            this._tabControl.SuspendLayout();
            this._tabPages.SuspendLayout();
            this._tabBookmarks.SuspendLayout();
            this.SuspendLayout();
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
            this._workspaceViewer.Location = new System.Drawing.Point(175, 0);
            this._workspaceViewer.Magnifier.BackColor = System.Drawing.Color.White;
            this._workspaceViewer.Magnifier.BorderColor = System.Drawing.Color.Black;
            this._workspaceViewer.Magnifier.Size = new System.Drawing.Size(100, 100);
            this._workspaceViewer.MouseWheelScrolling = true;
            this._workspaceViewer.Name = "_workspaceViewer";
            this._workspaceViewer.OutputProfile = null;
            this._workspaceViewer.RotationSnapInterval = 0F;
            this._workspaceViewer.RotationSnapThreshold = 0F;
            this._workspaceViewer.Selection = null;
            this._workspaceViewer.Size = new System.Drawing.Size(785, 686);
            this._workspaceViewer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this._workspaceViewer.TabIndex = 0;
            this._workspaceViewer.Text = "workspaceViewer1";
            this._workspaceViewer.ToolTip = null;
            this._workspaceViewer.UndoManager.Levels = 0;
            this._workspaceViewer.ProcessError += new Atalasoft.Imaging.ExceptionEventHandler(this.WorkspaceViewerOnProcessError);
            this._workspaceViewer.ImageChanged += new Atalasoft.Imaging.ImageEventHandler(this.WorkspaceViewerOnChangedImage);
            // 
            // _mainMenu
            // 
            this._mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuFile,
            this._menuView,
            this._menuOptions,
            this._menuHelp});
            // 
            // _menuFile
            // 
            this._menuFile.Index = 0;
            this._menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuOpen,
            this._menuSave,
            this._menuItemFind,
            this._menuExtractImages,
            this._menuGetInfo,
            this._menuItemSplitter,
            this._menuPrint});
            this._menuFile.Text = "File";
            // 
            // _menuOpen
            // 
            this._menuOpen.Index = 0;
            this._menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this._menuOpen.Text = "Open";
            this._menuOpen.Click += new System.EventHandler(this.MenuOpenOnClick);
            // 
            // _menuSave
            // 
            this._menuSave.Index = 1;
            this._menuSave.Text = "Save As";
            this._menuSave.Click += new System.EventHandler(this.MenuSaveOnClick);
            // 
            // _menuItemFind
            // 
            this._menuItemFind.Enabled = false;
            this._menuItemFind.Index = 2;
            this._menuItemFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this._menuItemFind.Text = "Find ...";
            this._menuItemFind.Click += new System.EventHandler(this.MenuItemFindOnClick);
            // 
            // _menuExtractImages
            // 
            this._menuExtractImages.Index = 3;
            this._menuExtractImages.Text = "Extract Images";
            this._menuExtractImages.Click += new System.EventHandler(this.MenuExtractImagesOnClick);
            // 
            // _menuGetInfo
            // 
            this._menuGetInfo.Index = 4;
            this._menuGetInfo.Text = "Get Information";
            this._menuGetInfo.Click += new System.EventHandler(this.MenuGetInfoOnClick);
            // 
            // _menuItemSplitter
            // 
            this._menuItemSplitter.Index = 5;
            this._menuItemSplitter.Text = "-";
            // 
            // _menuPrint
            // 
            this._menuPrint.Index = 6;
            this._menuPrint.Text = "Print ... ";
            this._menuPrint.Click += new System.EventHandler(this.MenuPrintOnClick);
            // 
            // _menuView
            // 
            this._menuView.Index = 1;
            this._menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuViewFullSize,
            this._menuViewFitWidth,
            this._menuViewBestFit});
            this._menuView.Text = "View";
            this._menuView.Click += new System.EventHandler(this.MenuViewOnClick);
            // 
            // _menuViewFullSize
            // 
            this._menuViewFullSize.Index = 0;
            this._menuViewFullSize.Text = "Full Size";
            this._menuViewFullSize.Click += new System.EventHandler(this.MenuViewFullSizeOnClick);
            // 
            // _menuViewFitWidth
            // 
            this._menuViewFitWidth.Index = 1;
            this._menuViewFitWidth.Text = "Fit To Width";
            this._menuViewFitWidth.Click += new System.EventHandler(this.MenuViewFitWidthOnClick);
            // 
            // _menuViewBestFit
            // 
            this._menuViewBestFit.Index = 2;
            this._menuViewBestFit.Text = "Best Fit";
            this._menuViewBestFit.Click += new System.EventHandler(this.MenuViewBestFitOnClick);
            // 
            // _menuHelp
            // 
            this._menuHelp.Index = 3;
            this._menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuAbout});
            this._menuHelp.Text = "Help";
            // 
            // _menuAbout
            // 
            this._menuAbout.Index = 0;
            this._menuAbout.Text = "About ...";
            this._menuAbout.Click += new System.EventHandler(this.MenuAboutOnClick);
            // 
            // _menuOptions
            // 
            this._menuOptions.Index = 2;
            this._menuOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuPdfDecoderSettings});
            this._menuOptions.Text = "Options";
            // 
            // _menuPdfDecoderSettings
            // 
            this._menuPdfDecoderSettings.Index = 0;
            this._menuPdfDecoderSettings.Text = "PDF decoder settings";
            this._menuPdfDecoderSettings.Click += new System.EventHandler(this.MenuPdfDecoderSettingsOnClick);
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
            // _thumbnailView
            // 
            this._thumbnailView.BackColor = System.Drawing.Color.Gray;
            this._thumbnailView.CaptionLines = 0;
            this._thumbnailView.DisplayText = Atalasoft.Imaging.WinControls.ThumbViewAttribute.None;
            this._thumbnailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._thumbnailView.DragSelectionColor = System.Drawing.Color.Red;
            this._thumbnailView.ForeColor = System.Drawing.SystemColors.WindowText;
            this._thumbnailView.HighlightBackgroundColor = System.Drawing.SystemColors.Highlight;
            this._thumbnailView.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            this._thumbnailView.LoadErrorMessage = "";
            this._thumbnailView.LoadMethod = Atalasoft.Imaging.WinControls.ThumbLoadMethod.EntireFolder;
            this._thumbnailView.Location = new System.Drawing.Point(3, 3);
            this._thumbnailView.Margins = new Atalasoft.Imaging.WinControls.Margin(4, 4, 4, 4);
            this._thumbnailView.Name = "_thumbnailView";
            this._thumbnailView.SelectionRectangleBackColor = System.Drawing.Color.Transparent;
            this._thumbnailView.SelectionRectangleDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this._thumbnailView.SelectionRectangleLineColor = System.Drawing.Color.Black;
            this._thumbnailView.Size = new System.Drawing.Size(155, 654);
            this._thumbnailView.TabIndex = 2;
            this._thumbnailView.Text = "thumbnailView1";
            this._thumbnailView.ThumbnailBackground = null;
            this._thumbnailView.ThumbnailOffset = new System.Drawing.Point(0, 0);
            this._thumbnailView.ThumbnailSize = new System.Drawing.Size(100, 100);
            this._thumbnailView.SelectedIndexChanged += new System.EventHandler(this.ThumbnailViewOnSelectedIndexChanged);
            this._thumbnailView.ThumbnailCreated += new Atalasoft.Imaging.WinControls.ThumbnailEventHandler(this.ThumbnailViewOnThumbnailLoad);
            // 
            // _progressBar
            // 
            this._progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._progressBar.Location = new System.Drawing.Point(646, 688);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(300, 20);
            this._progressBar.TabIndex = 3;
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPages);
            this._tabControl.Controls.Add(this._tabBookmarks);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(169, 686);
            this._tabControl.TabIndex = 4;
            // 
            // _tabPages
            // 
            this._tabPages.Controls.Add(this._thumbnailView);
            this._tabPages.Location = new System.Drawing.Point(4, 22);
            this._tabPages.Name = "_tabPages";
            this._tabPages.Padding = new System.Windows.Forms.Padding(3);
            this._tabPages.Size = new System.Drawing.Size(161, 660);
            this._tabPages.TabIndex = 0;
            this._tabPages.Text = "Pages";
            this._tabPages.UseVisualStyleBackColor = true;
            // 
            // _tabBookmarks
            // 
            this._tabBookmarks.Controls.Add(this._treeBookmarks);
            this._tabBookmarks.Location = new System.Drawing.Point(4, 22);
            this._tabBookmarks.Name = "_tabBookmarks";
            this._tabBookmarks.Padding = new System.Windows.Forms.Padding(3);
            this._tabBookmarks.Size = new System.Drawing.Size(161, 660);
            this._tabBookmarks.TabIndex = 1;
            this._tabBookmarks.Text = "Bookmarks";
            this._tabBookmarks.UseVisualStyleBackColor = true;
            // 
            // _treeBookmarks
            // 
            this._treeBookmarks.BackColor = System.Drawing.Color.Gray;
            this._treeBookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeBookmarks.ForeColor = System.Drawing.Color.White;
            this._treeBookmarks.Location = new System.Drawing.Point(3, 3);
            this._treeBookmarks.Name = "_treeBookmarks";
            this._treeBookmarks.Size = new System.Drawing.Size(155, 654);
            this._treeBookmarks.TabIndex = 0;
            this._treeBookmarks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeBookmarksOnAfterSelect);
            // 
            // _splitter
            // 
            this._splitter.Location = new System.Drawing.Point(169, 0);
            this._splitter.Name = "_splitter";
            this._splitter.Size = new System.Drawing.Size(6, 686);
            this._splitter.TabIndex = 5;
            this._splitter.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(960, 708);
            this.Controls.Add(this._workspaceViewer);
            this.Controls.Add(this._splitter);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._statusBar);
            this.Menu = this._mainMenu;
            this.Name = "MainForm";
            this.Text = "Atalasoft PDF Viewer Demo";
            ((System.ComponentModel.ISupportInitialize)(this._statusBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusProgress)).EndInit();
            this._tabControl.ResumeLayout(false);
            this._tabPages.ResumeLayout(false);
            this._tabBookmarks.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Atalasoft.Annotate.UI.AnnotateViewer _workspaceViewer;
		private Atalasoft.Imaging.WinControls.ThumbnailView _thumbnailView;
		private System.Windows.Forms.Splitter _splitter;
		private System.Windows.Forms.TabPage _tabPages;
		private System.Windows.Forms.TabPage _tabBookmarks;
		private System.Windows.Forms.TreeView _treeBookmarks;
		private System.Windows.Forms.TabControl _tabControl;
		private System.Windows.Forms.ToolTip _toolTip;
		private System.Windows.Forms.ProgressBar _progressBar;
		private System.Windows.Forms.StatusBarPanel _statusProgress;
		private System.Windows.Forms.StatusBarPanel _statusBarPanel;
		private System.Windows.Forms.StatusBar _statusBar;
		private System.Windows.Forms.SaveFileDialog _saveFileDialog;
		private System.Windows.Forms.OpenFileDialog _openFileDialog;
		private System.Windows.Forms.MenuItem _menuHelp;
		private System.Windows.Forms.MenuItem _menuAbout;
		private System.Windows.Forms.MenuItem _menuViewBestFit;
		private System.Windows.Forms.MenuItem _menuViewFitWidth;
		private System.Windows.Forms.MenuItem _menuViewFullSize;
		private System.Windows.Forms.MenuItem _menuView;
		private System.Windows.Forms.MenuItem _menuPrint;
		private System.Windows.Forms.MenuItem _menuItemSplitter;
		private System.Windows.Forms.MenuItem _menuGetInfo;
		private System.Windows.Forms.MenuItem _menuExtractImages;
		private System.Windows.Forms.MenuItem _menuItemFind;
		private System.Windows.Forms.MenuItem _menuSave;
		private System.Windows.Forms.MenuItem _menuOpen;
		private System.Windows.Forms.MenuItem _menuFile;
		private System.Windows.Forms.MainMenu _mainMenu;
        private System.Windows.Forms.MenuItem _menuOptions;
        private System.Windows.Forms.MenuItem _menuPdfDecoderSettings;
	}
}

