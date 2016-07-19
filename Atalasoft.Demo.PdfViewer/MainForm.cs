// ------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using Atalasoft.Annotate.UI;
using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec;
using Atalasoft.Imaging.Codec.Pdf;
using Atalasoft.Imaging.WinControls;
using Atalasoft.PdfDoc;

namespace Atalasoft.Demo.PdfViewer
{
	public partial class MainForm : Form
	{
		private PdfDecoder _pdf;
		private bool _extractedImages = false;

		private string _currentFile = null;
		private int _currentResolution = -1;

		// members to control text search
		private FindDialog _findDialog;
		private PdfDocumentSearch _pdfDocSearch;

		public MainForm()
		{
			InitializeComponent();

			try
			{
				_pdf = new PdfDecoder();
				_pdf.Resolution = 150;
				_pdf.RenderSettings = new RenderSettings() { AnnotationSettings = AnnotationRenderSettings.RenderNone };

				//add the PDF Rasterizer as a decoder
				RegisteredDecoders.Decoders.Insert(0, _pdf);
			}
			catch (Atalasoft.Imaging.AtalasoftLicenseException)
			{
				this.menuFile.Enabled = false;
				ShowLicenseMessage("PdfRasterizer");
			}

			this.workspaceViewer1.ImageBorderPen = new Atalasoft.Imaging.Drawing.AtalaPen(Color.Black, 1);
			workspaceViewer1.Annotations.Layers.Add(new LayerAnnotation());
		}

		private void ShowLicenseMessage(string product)
		{
			if (MessageBox.Show("This demo requires a " + product + " license.\r\nAn evaluation license can be requested with our activation utility.\r\n\r\nWould you like to run this utility now?", product + " License Required", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
			{
				string activationUtil = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\Atalasoft\\DotImage ";

				// Use reflection to find out which version of DotImage we are using.
				System.Reflection.AssemblyName[] assemblies = System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies();
				foreach (System.Reflection.AssemblyName name in assemblies)
				{
					if (name.Name == "Atalasoft.dotImage")
					{
						activationUtil += name.Version.ToString(2);
						break;
					}
				}

				activationUtil += "\\AtalasoftToolkitActivation.exe";

				if (System.IO.File.Exists(activationUtil))
					System.Diagnostics.Process.Start(activationUtil);
				else
					MessageBox.Show("We were unable to location the activation utility on this system.\r\nPlease run it from the start menu.", "AtalasoftToolkitActivation.exe Not Found");
			}
		}

		private void menuOpen_Click(object sender, System.EventArgs e)
		{

			if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				string file = this.openFileDialog1.FileName;
				int frameCount = RegisteredDecoders.GetImageInfo(file, 0).FrameCount;

				//set decoder properties
				Form frm = new Parameters("PDF DEcoder Properties", _pdf);
				if (frm.ShowDialog(this) == DialogResult.OK)
				{
					this.thumbnailView1.Items.Cancel();
					this.thumbnailView1.Items.Clear();

					//reset progress bar
					this.progressBar1.Maximum = frameCount;
					this.progressBar1.Value = 0;

					// Create the Thumbnail objects and pass them into the ThumbnailView all at once.
					Thumbnail[] thumbs = new Thumbnail[frameCount];
					for (int i = 0; i < frameCount; i++)
					{
						thumbs[i] = new Thumbnail(file, i, "", "");
					}
					this.thumbnailView1.Items.AddRange(thumbs);

					//open the first full size page
					this.workspaceViewer1.Open(file, 0);

					_extractedImages = false;
					_currentFile = file;
					_currentResolution = _pdf.Resolution;
					this.workspaceViewer1.Annotations.CurrentLayer.Items.Clear();
					menuItemFind.Enabled = true;

					LoadPdfBookmarks(file);
				}
			}
		}

		private void menuGetInfo_Click(object sender, System.EventArgs e)
		{
			if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				FileStream fs = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
				ImageInfo info = _pdf.GetImageInfo(fs);
				PdfImageInfo pdfInfo = (PdfImageInfo)info;
				Form frm = new Parameters("PDF Image Information", info);
				frm.ShowDialog();
				frm.Dispose();
			}

		}

		private void menuExtractImages_Click(object sender, System.EventArgs e)
		{
			if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				this.workspaceViewer1.Images.Clear();
				this.thumbnailView1.Items.Cancel();
				this.thumbnailView1.Items.Clear();

				FileStream fs = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);

				// Document objects must be disposed.  This makes sure it happens even if there
				// is an exception
				using (Document document = new Document(fs))
				{
					//reset progress bar, estimate one image per page
					this.progressBar1.Maximum = 0;
					this.progressBar1.Value = 0;


					for (int i = 0; i < document.Pages.Count; i++)
					{

						ExtractedImageInfo[] extractedImages = document.Pages[i].ExtractImages();
						// check progressbar
						this.progressBar1.Maximum += extractedImages.Length;
						foreach (ExtractedImageInfo info in extractedImages)
						{
							this.workspaceViewer1.Images.Add((AtalaImage)info.Image.Clone());
							this.thumbnailView1.Items.Add(info.Image, "");
						}
					}
				}
				_extractedImages = true;
				fs.Close();
			}
		}

		private void thumbnailView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.thumbnailView1.SelectedItems.Count > 0)
			{
				this.workspaceViewer1.ScrollPosition = new Point(0, 0);

				if (_extractedImages)
					this.workspaceViewer1.Image = this.workspaceViewer1.Images[this.thumbnailView1.SelectedIndices[0]];
				else
				{
					this.workspaceViewer1.Open(this.openFileDialog1.FileName, this.thumbnailView1.SelectedIndices[0]);
					this.workspaceViewer1.Annotations.CurrentLayer.Items.Clear();
				}
			}
		}

		private void menuSave_Click(object sender, System.EventArgs e)
		{
			if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				ImageEncoder encoder = null;
				switch (this.saveFileDialog1.FilterIndex)
				{
					case 1:
						//for more control over saving, use the PdfCollection and PdfImage classes
						encoder = new PdfEncoder();
						break;
					case 2:
						encoder = new TiffEncoder();
						break;
					case 3:
						encoder = new JpegEncoder();
						break;
				}
				this.workspaceViewer1.Save(this.saveFileDialog1.FileName, encoder);
			}
		}

		private void workspaceViewer1_ChangedImage(object sender, Atalasoft.Imaging.ImageEventArgs e)
		{
			if (e.Image != null)
				this.statusBar1.Panels[0].Text = e.Image.ToString();
		}

		private void workspaceViewer1_ProcessError(object sender, Atalasoft.Imaging.ExceptionEventArgs e)
		{
			MessageBox.Show(this, e.Exception.ToString());
		}

		private void menuView_Click(object sender, System.EventArgs e)
		{
			switch (this.workspaceViewer1.AutoZoom)
			{
				case AutoZoomMode.FitToWidth:
					menuViewFitWidth.Checked = true;
					menuViewFullSize.Checked = false;
					menuViewBestFit.Checked = false;
					break;
				case AutoZoomMode.BestFit:
					menuViewFitWidth.Checked = false;
					menuViewFullSize.Checked = false;
					menuViewBestFit.Checked = true;
					break;
				default:
					menuViewFitWidth.Checked = false;
					menuViewFullSize.Checked = true;
					menuViewBestFit.Checked = false;
					break;
			}
		}

		private void menuViewFullSize_Click(object sender, System.EventArgs e)
		{
			this.workspaceViewer1.AutoZoom = AutoZoomMode.None;
			this.workspaceViewer1.Zoom = 1.0;
		}

		private void menuViewFitWidth_Click(object sender, System.EventArgs e)
		{
			this.workspaceViewer1.AutoZoom = AutoZoomMode.FitToWidth;
		}

		private void menuViewBestFit_Click(object sender, System.EventArgs e)
		{
			this.workspaceViewer1.AutoZoom = AutoZoomMode.BestFit;
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			About aboutBox = new About("About Atalasoft DotImage PDF Demo",
				"DotImage PDF Demo");
			aboutBox.Description = @"Demonstrates how to view and save PDF files with DotImage and DotImage PDFRasterizer.  Rasterizers a small thumbnail of each page in the PDF asynchronously while loading the first page in the PDF.  Demonstrates use of the ThumbnailView control.

";
			aboutBox.ShowDialog();

		}

		private void thumbnailView1_ThumbnailLoad(object sender, Atalasoft.Imaging.WinControls.ThumbnailEventArgs e)
		{
			// update the progressbar for every thumbnail load.
			this.progressBar1.Value += 1;
			if (this.progressBar1.Value == this.progressBar1.Maximum)
				this.progressBar1.Value = 0;
		}

		#region Printing

		private Document docToPrint = null;
		private Pages imagesToPrint = null;
		private int current = 0;

		private void menuPrint_Click(object sender, System.EventArgs e)
		{
			if (this.openFileDialog1.FileName == "") // make sure an image is loaded
				return;

			FileStream fs = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
			docToPrint = new Document(fs);
			this.imagesToPrint = docToPrint.Pages;
			// Use System.Drawing.Print.PrintDocument 
			PrintDocument thePrintDoc = new PrintDocument();
			thePrintDoc.PrintPage += new PrintPageEventHandler(thePrintDoc_PrintPage);
			this.current = 0;
			thePrintDoc.Print();
			fs.Close();
		}

		private void thePrintDoc_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = true;
			Page p = imagesToPrint[current++];
			// fit to page, only when image is too large. 
			float newX = (float)(e.PageBounds.Width / p.Width);
			float newY = (float)(e.PageBounds.Height / p.Height);
			if (!(newX > 1 && newY > 1))
				e.Graphics.ScaleTransform(newX, newY);
			// Draw pdf image onto graphics object here.
			RenderSettings rs = new RenderSettings();
			rs.AnnotationSettings = AnnotationRenderSettings.RenderAll;
			p.Draw(e.Graphics, PageBoundary.Default, rs, 500);
			if (current >= imagesToPrint.Count)
			{
				e.HasMorePages = false;
				docToPrint.Dispose(); // make sure to dispose
				docToPrint = null;
			}
		}

		#endregion

		private void menuItemFind_Click(object sender, System.EventArgs e)
		{
			if (_findDialog == null && _currentFile != null)
			{
				_pdfDocSearch = new PdfDocumentSearch(GetCurrentPage());
				_findDialog = new FindDialog();
				_findDialog.Closed += new EventHandler(findDialog_Closed);
				_findDialog.OnFindNext += new FindDialog.FindNextHandler(findDialog_OnFindNext);
				_findDialog.Show();
			}
		}

		private void findDialog_Closed(object sender, EventArgs e)
		{
			_findDialog = null;
		}

		private int GetCurrentPage()
		{
			if (this.thumbnailView1.SelectedIndices.Length > 0)
			{
				return this.thumbnailView1.SelectedIndices[0];
			}
			return 0;
		}


		/// <summary>
		/// This is called when the next button is clicked on the find dialog
		/// </summary>
		/// <param name="text">The text in the find dialog</param>
		/// <param name="matchCase">true if the search should match case</param>
		/// <param name="wholeWord">true if the search should only find whole words</param>
		private void findDialog_OnFindNext(String findText, bool matchCase, bool wholeWord)
		{
			// find and highlight the text
			bool found = false;
			if (_currentFile != null)
			{
				PdfFindHighlighter findHighlighter = new PdfFindHighlighter(workspaceViewer1, thumbnailView1, _currentResolution);
				using (FileStream fs = new FileStream(_currentFile, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					found = _pdfDocSearch.FindNext(fs, findText, matchCase, wholeWord, new PdfDocumentSearch.FindTextHandler(findHighlighter.HighlightFoundText));
				}
				if (!found)
				{
					MessageBox.Show("The specified text was not found.", "PDF Viewer Search", MessageBoxButtons.OK);
				}
			}
		}

		#region Bookmark Code

		// When a bookmark is selected, load the page and scroll to the bookmark position.
		private void treeBookmarks_AfterSelect(object sender, TreeViewEventArgs e)
		{
			PdfBookmark bm = e.Node.Tag as PdfBookmark;
			if (bm != null && bm.ClickAction.Count > 0)
			{
				PdfAction action = bm.ClickAction[0];
				if (action.ActionType == PdfActionType.GoToView)
				{
					PdfGoToViewAction gotoView = action as PdfGoToViewAction;
					if (gotoView != null && gotoView.Destination != null && gotoView.Destination.Page != null)
					{
						PdfIndexedPageReference page = gotoView.Destination.Page as PdfIndexedPageReference;
						if (page != null)
						{
							if (page.PageIndex >= 0 && page.PageIndex < this.thumbnailView1.Items.Count)
							{
								// Selecting the thumbnail will load the page.
								int pageIndex = GetCurrentPage();
								if (pageIndex != page.PageIndex)
								{
									this.thumbnailView1.ClearSelection();
									this.thumbnailView1.Items[page.PageIndex].Selected = true;
									this.thumbnailView1.ScrollTo(page.PageIndex);
								}

								/*
									The bookmark coordinates are in PDF page coordinates.
									(0,0) is the lower left corner, increases up and to the right
									Units are 1/72”
								*/
								int y = (gotoView.Destination.Top.HasValue ? Convert.ToInt32((gotoView.Destination.Top.Value / 72.0) * this.workspaceViewer1.Image.Resolution.Y) : 0);
								y = this.workspaceViewer1.Image.Height - y;
								this.workspaceViewer1.ScrollPosition = new Point(0, -y);
							}
						}
					}
				}
			}
		}

		private void LoadPdfBookmarks(string fileName)
		{
			this.treeBookmarks.Nodes.Clear();

			PdfDocument doc = new PdfDocument(fileName);
			if (doc.BookmarkTree != null)
			{
				foreach (PdfBookmark bookmark in doc.BookmarkTree.Bookmarks)
				{
					AddBookMark(null, bookmark);
				}
			}
		}

		private void AddBookMark(TreeNode parent, PdfBookmark bookMark)
		{
			TreeNode node = new TreeNode(bookMark.Text);
			node.ForeColor = bookMark.Color;
			node.Tag = bookMark;

			if (parent == null)
				this.treeBookmarks.Nodes.Add(node);
			else
				parent.Nodes.Add(node);

			if (bookMark.Children != null)
			{
				foreach (PdfBookmark bm in bookMark.Children)
				{
					AddBookMark(node, bm);
				}
			}
		}

		#endregion
	}
}
