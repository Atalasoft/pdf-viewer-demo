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
			this.workspaceViewer1 = new Atalasoft.Annotate.UI.AnnotateViewer();
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuOpen = new System.Windows.Forms.MenuItem();
			this.menuSave = new System.Windows.Forms.MenuItem();
			this.menuItemFind = new System.Windows.Forms.MenuItem();
			this.menuExtractImages = new System.Windows.Forms.MenuItem();
			this.menuGetInfo = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuPrint = new System.Windows.Forms.MenuItem();
			this.menuView = new System.Windows.Forms.MenuItem();
			this.menuViewFullSize = new System.Windows.Forms.MenuItem();
			this.menuViewFitWidth = new System.Windows.Forms.MenuItem();
			this.menuViewBestFit = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusProgress = new System.Windows.Forms.StatusBarPanel();
			this.thumbnailView1 = new Atalasoft.Imaging.WinControls.ThumbnailView();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPages = new System.Windows.Forms.TabPage();
			this.tabBookmarks = new System.Windows.Forms.TabPage();
			this.treeBookmarks = new System.Windows.Forms.TreeView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusProgress)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPages.SuspendLayout();
			this.tabBookmarks.SuspendLayout();
			this.SuspendLayout();
			// 
			// workspaceViewer1
			// 
			this.workspaceViewer1.AntialiasDisplay = Atalasoft.Imaging.WinControls.AntialiasDisplayMode.ReductionOnly;
			this.workspaceViewer1.Asynchronous = true;
			this.workspaceViewer1.BackColor = System.Drawing.SystemColors.Control;
			this.workspaceViewer1.Centered = true;
			this.workspaceViewer1.DefaultSecurity = null;
			this.workspaceViewer1.DisplayProfile = null;
			this.workspaceViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.workspaceViewer1.Location = new System.Drawing.Point(175, 0);
			this.workspaceViewer1.Magnifier.BackColor = System.Drawing.Color.White;
			this.workspaceViewer1.Magnifier.BorderColor = System.Drawing.Color.Black;
			this.workspaceViewer1.Magnifier.Size = new System.Drawing.Size(100, 100);
			this.workspaceViewer1.MouseWheelScrolling = true;
			this.workspaceViewer1.Name = "workspaceViewer1";
			this.workspaceViewer1.OutputProfile = null;
			this.workspaceViewer1.RotationSnapInterval = 0F;
			this.workspaceViewer1.RotationSnapThreshold = 0F;
			this.workspaceViewer1.Selection = null;
			this.workspaceViewer1.Size = new System.Drawing.Size(785, 686);
			this.workspaceViewer1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
			this.workspaceViewer1.TabIndex = 0;
			this.workspaceViewer1.Text = "workspaceViewer1";
			this.workspaceViewer1.ToolTip = null;
			this.workspaceViewer1.UndoManager.Levels = 0;
			this.workspaceViewer1.ImageChanged += new Atalasoft.Imaging.ImageEventHandler(this.workspaceViewer1_ChangedImage);
			this.workspaceViewer1.ProcessError += new Atalasoft.Imaging.ExceptionEventHandler(this.workspaceViewer1_ProcessError);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuView,
            this.menuItem1});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOpen,
            this.menuSave,
            this.menuItemFind,
            this.menuExtractImages,
            this.menuGetInfo,
            this.menuItem7,
            this.menuPrint});
			this.menuFile.Text = "File";
			// 
			// menuOpen
			// 
			this.menuOpen.Index = 0;
			this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuOpen.Text = "Open";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			// 
			// menuSave
			// 
			this.menuSave.Index = 1;
			this.menuSave.Text = "Save As";
			this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
			// 
			// menuItemFind
			// 
			this.menuItemFind.Enabled = false;
			this.menuItemFind.Index = 2;
			this.menuItemFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.menuItemFind.Text = "Find ...";
			this.menuItemFind.Click += new System.EventHandler(this.menuItemFind_Click);
			// 
			// menuExtractImages
			// 
			this.menuExtractImages.Index = 3;
			this.menuExtractImages.Text = "Extract Images";
			this.menuExtractImages.Click += new System.EventHandler(this.menuExtractImages_Click);
			// 
			// menuGetInfo
			// 
			this.menuGetInfo.Index = 4;
			this.menuGetInfo.Text = "Get Information";
			this.menuGetInfo.Click += new System.EventHandler(this.menuGetInfo_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "-";
			// 
			// menuPrint
			// 
			this.menuPrint.Index = 6;
			this.menuPrint.Text = "Print ... ";
			this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
			// 
			// menuView
			// 
			this.menuView.Index = 1;
			this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuViewFullSize,
            this.menuViewFitWidth,
            this.menuViewBestFit});
			this.menuView.Text = "View";
			this.menuView.Click += new System.EventHandler(this.menuView_Click);
			// 
			// menuViewFullSize
			// 
			this.menuViewFullSize.Index = 0;
			this.menuViewFullSize.Text = "Full Size";
			this.menuViewFullSize.Click += new System.EventHandler(this.menuViewFullSize_Click);
			// 
			// menuViewFitWidth
			// 
			this.menuViewFitWidth.Index = 1;
			this.menuViewFitWidth.Text = "Fit To Width";
			this.menuViewFitWidth.Click += new System.EventHandler(this.menuViewFitWidth_Click);
			// 
			// menuViewBestFit
			// 
			this.menuViewBestFit.Index = 2;
			this.menuViewBestFit.Text = "Best Fit";
			this.menuViewBestFit.Click += new System.EventHandler(this.menuViewBestFit_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6});
			this.menuItem1.Text = "Help";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.Text = "About ...";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "pdf";
			this.openFileDialog1.Filter = "PDF Files|*.pdf|All Files|*.*";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "pdf";
			this.saveFileDialog1.Filter = "PDF File(*.pdf)|*.pdf|TIFF File(*tif)|*.tif|JPEG File(*.jpg)|*.jpg";
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 686);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusProgress});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(960, 22);
			this.statusBar1.TabIndex = 1;
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel1.Name = "statusBarPanel1";
			this.statusBarPanel1.Width = 643;
			// 
			// statusProgress
			// 
			this.statusProgress.Name = "statusProgress";
			this.statusProgress.Width = 300;
			// 
			// thumbnailView1
			// 
			this.thumbnailView1.BackColor = System.Drawing.Color.Gray;
			this.thumbnailView1.CaptionLines = 0;
			this.thumbnailView1.DisplayText = Atalasoft.Imaging.WinControls.ThumbViewAttribute.None;
			this.thumbnailView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.thumbnailView1.DragSelectionColor = System.Drawing.Color.Red;
			this.thumbnailView1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.thumbnailView1.HighlightBackgroundColor = System.Drawing.SystemColors.Highlight;
			this.thumbnailView1.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
			this.thumbnailView1.LoadErrorMessage = "";
			this.thumbnailView1.LoadMethod = Atalasoft.Imaging.WinControls.ThumbLoadMethod.EntireFolder;
			this.thumbnailView1.Location = new System.Drawing.Point(3, 3);
			this.thumbnailView1.Margins = new Atalasoft.Imaging.WinControls.Margin(4, 4, 4, 4);
			this.thumbnailView1.SelectionMode = Atalasoft.Imaging.WinControls.ThumbnailSelectionMode.SingleSelect;
			this.thumbnailView1.Name = "thumbnailView1";
			this.thumbnailView1.SelectionRectangleBackColor = System.Drawing.Color.Transparent;
			this.thumbnailView1.SelectionRectangleDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this.thumbnailView1.SelectionRectangleLineColor = System.Drawing.Color.Black;
			this.thumbnailView1.Size = new System.Drawing.Size(155, 654);
			this.thumbnailView1.TabIndex = 2;
			this.thumbnailView1.Text = "thumbnailView1";
			this.thumbnailView1.ThumbnailBackground = null;
			this.thumbnailView1.ThumbnailOffset = new System.Drawing.Point(0, 0);
			this.thumbnailView1.ThumbnailSize = new System.Drawing.Size(100, 100);
			this.thumbnailView1.SelectedIndexChanged += new System.EventHandler(this.thumbnailView1_SelectedIndexChanged);
			this.thumbnailView1.ThumbnailCreated += new Atalasoft.Imaging.WinControls.ThumbnailEventHandler(this.thumbnailView1_ThumbnailLoad);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(646, 688);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(300, 20);
			this.progressBar1.TabIndex = 3;
			// 
			// menuItem2
			// 
			this.menuItem2.Index = -1;
			this.menuItem2.Text = "10";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = -1;
			this.menuItem3.Text = "75";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = -1;
			this.menuItem4.Text = "200";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = -1;
			this.menuItem5.Text = "300";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPages);
			this.tabControl1.Controls.Add(this.tabBookmarks);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(169, 686);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPages
			// 
			this.tabPages.Controls.Add(this.thumbnailView1);
			this.tabPages.Location = new System.Drawing.Point(4, 22);
			this.tabPages.Name = "tabPages";
			this.tabPages.Padding = new System.Windows.Forms.Padding(3);
			this.tabPages.Size = new System.Drawing.Size(161, 660);
			this.tabPages.TabIndex = 0;
			this.tabPages.Text = "Pages";
			this.tabPages.UseVisualStyleBackColor = true;
			// 
			// tabBookmarks
			// 
			this.tabBookmarks.Controls.Add(this.treeBookmarks);
			this.tabBookmarks.Location = new System.Drawing.Point(4, 22);
			this.tabBookmarks.Name = "tabBookmarks";
			this.tabBookmarks.Padding = new System.Windows.Forms.Padding(3);
			this.tabBookmarks.Size = new System.Drawing.Size(161, 660);
			this.tabBookmarks.TabIndex = 1;
			this.tabBookmarks.Text = "Bookmarks";
			this.tabBookmarks.UseVisualStyleBackColor = true;
			// 
			// treeBookmarks
			// 
			this.treeBookmarks.BackColor = System.Drawing.Color.Gray;
			this.treeBookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeBookmarks.ForeColor = System.Drawing.Color.White;
			this.treeBookmarks.Location = new System.Drawing.Point(3, 3);
			this.treeBookmarks.Name = "treeBookmarks";
			this.treeBookmarks.Size = new System.Drawing.Size(155, 654);
			this.treeBookmarks.TabIndex = 0;
			this.treeBookmarks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeBookmarks_AfterSelect);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(169, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(6, 686);
			this.splitter1.TabIndex = 5;
			this.splitter1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(960, 708);
			this.Controls.Add(this.workspaceViewer1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.statusBar1);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "PDF Demo";
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusProgress)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPages.ResumeLayout(false);
			this.tabBookmarks.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Atalasoft.Annotate.UI.AnnotateViewer workspaceViewer1;
		private Atalasoft.Imaging.WinControls.ThumbnailView thumbnailView1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.TabPage tabPages;
		private System.Windows.Forms.TabPage tabBookmarks;
		private System.Windows.Forms.TreeView treeBookmarks;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.StatusBarPanel statusProgress;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuViewBestFit;
		private System.Windows.Forms.MenuItem menuViewFitWidth;
		private System.Windows.Forms.MenuItem menuViewFullSize;
		private System.Windows.Forms.MenuItem menuView;
		private System.Windows.Forms.MenuItem menuPrint;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuGetInfo;
		private System.Windows.Forms.MenuItem menuExtractImages;
		private System.Windows.Forms.MenuItem menuItemFind;
		private System.Windows.Forms.MenuItem menuSave;
		private System.Windows.Forms.MenuItem menuOpen;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MainMenu mainMenu1;
	}
}

