// ------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Atalasoft.Annotate.UI;
using Atalasoft.Demo.PdfViewer.Properties;
using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec;
using Atalasoft.Imaging.Codec.Pdf;
using Atalasoft.Imaging.Drawing;
using Atalasoft.Imaging.WinControls;
using Atalasoft.PdfDoc;

namespace Atalasoft.Demo.PdfViewer
{
    public partial class MainForm : Form
    {
        #region Fields

        private Document _docToPrint;
        private Pages _imagesToPrint;
        private int _current;

        private readonly PdfDecoder _pdfDecoder;
        private bool _extractedImages;

        private string _currentFile;

        // members to control text search
        private FindDialog _findDialog;
        private PdfDocumentSearch _pdfDocSearch;

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            try
            {
                _pdfDecoder = new PdfDecoder
                {
                    Resolution = 150,
                    RenderSettings = new RenderSettings { AnnotationSettings = AnnotationRenderSettings.RenderNone }
                };

                //add the PDF Rasterizer as a decoder
                RegisteredDecoders.Decoders.Insert(0, _pdfDecoder);
            }
            catch (AtalasoftLicenseException)
            {
                _menuFile.Enabled = false;
                ShowLicenseMessage("PdfRasterizer");
            }

            _workspaceViewer.ImageBorderPen = new AtalaPen(Color.Black, 1);
            _workspaceViewer.Annotations.Layers.Add(new LayerAnnotation());
        }

        #endregion
        
        #region Event handlers

        #region Menu event handlers

        private void MenuOpenOnClick(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            var file = _openFileDialog.FileName;
            var frameCount = RegisteredDecoders.GetImageInfo(file, 0).FrameCount;
            
            _thumbnailView.Items.Cancel();
            _thumbnailView.Items.Clear();

            //reset progress bar
            _progressBar.Maximum = frameCount;
            _progressBar.Value = 0;

            // Create the Thumbnail objects and pass them into the ThumbnailView all at once.
            var thumbs = new Thumbnail[frameCount];
            for (var i = 0; i < frameCount; i++)
            {
                thumbs[i] = new Thumbnail(file, i, "", "");
            }
            _thumbnailView.Items.AddRange(thumbs);

            //open the first full size page
            _workspaceViewer.Open(file, 0);

            _extractedImages = false;
            _currentFile = file;
            _workspaceViewer.Annotations.CurrentLayer.Items.Clear();
            _menuItemFind.Enabled = true;

            LoadPdfBookmarks(file);
        }

        private void MenuGetInfoOnClick(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            using (var fs = new FileStream(_openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var info = _pdfDecoder.GetImageInfo(fs);

                using (Form frm = new Parameters("PDF Image Information", info))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void MenuExtractImagesOnClick(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog(this) != DialogResult.OK) return;
            _workspaceViewer.Images.Clear();
            _thumbnailView.Items.Cancel();
            _thumbnailView.Items.Clear();

            using (var fs = new FileStream(_openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var document = new Document(fs))
                {
                    //reset progress bar, estimate one image per page
                    _progressBar.Maximum = 0;
                    _progressBar.Value = 0;


                    for (var i = 0; i < document.Pages.Count; i++)
                    {

                        var extractedImages = document.Pages[i].ExtractImages();
                        // check progressbar
                        _progressBar.Maximum += extractedImages.Length;
                        foreach (var info in extractedImages)
                        {
                            _workspaceViewer.Images.Add((AtalaImage)info.Image.Clone());
                            _thumbnailView.Items.Add(info.Image, "");
                        }
                    }
                }
                _extractedImages = true;
            }
        }

        private void MenuSaveOnClick(object sender, EventArgs e)
        {
            if (_saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;
            ImageEncoder encoder = null;
            switch (_saveFileDialog.FilterIndex)
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
            _workspaceViewer.Save(_saveFileDialog.FileName, encoder);
        }

        private void MenuViewOnClick(object sender, EventArgs e)
        {
            switch (_workspaceViewer.AutoZoom)
            {
                case AutoZoomMode.FitToWidth:
                    _menuViewFitWidth.Checked = true;
                    _menuViewFullSize.Checked = false;
                    _menuViewBestFit.Checked = false;
                    break;
                case AutoZoomMode.BestFit:
                    _menuViewFitWidth.Checked = false;
                    _menuViewFullSize.Checked = false;
                    _menuViewBestFit.Checked = true;
                    break;
                case AutoZoomMode.None:
                    break;
                case AutoZoomMode.BestFitShrinkOnly:
                    break;
                case AutoZoomMode.FitToHeight:
                    break;
                default:
                    _menuViewFitWidth.Checked = false;
                    _menuViewFullSize.Checked = true;
                    _menuViewBestFit.Checked = false;
                    break;
            }
        }

        private void MenuViewFullSizeOnClick(object sender, EventArgs e)
        {
            _workspaceViewer.AutoZoom = AutoZoomMode.None;
            _workspaceViewer.Zoom = 1.0;
        }

        private void MenuViewFitWidthOnClick(object sender, EventArgs e)
        {
            _workspaceViewer.AutoZoom = AutoZoomMode.FitToWidth;
        }

        private void MenuViewBestFitOnClick(object sender, EventArgs e)
        {
            _workspaceViewer.AutoZoom = AutoZoomMode.BestFit;
        }

        private void MenuAboutOnClick(object sender, EventArgs e)
        {
            var aboutBox = new About(Resources.TitleAboutForm,
                Resources.ProjectName)
            {
                Description =
                    Resources.ProjectDescription
            };
            aboutBox.ShowDialog();

        }

        private void MenuItemFindOnClick(object sender, EventArgs e)
        {
            if (_findDialog != null || _currentFile == null)
                return;
            _pdfDocSearch = new PdfDocumentSearch(GetCurrentPage());
            _findDialog = new FindDialog();
            _findDialog.Closed += FindDialogOnClosed;
            _findDialog.FindNext += FindDialogOnFindNext;
            _findDialog.Show();
        }

        #endregion

        private void ThumbnailViewOnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_thumbnailView.SelectedItems.Count <= 0)
                return;
            _workspaceViewer.ScrollPosition = new Point(0, 0);

            if (_extractedImages)
                _workspaceViewer.Image = _workspaceViewer.Images[_thumbnailView.SelectedIndices[0]];
            else
            {
                _workspaceViewer.Open(_openFileDialog.FileName, _thumbnailView.SelectedIndices[0]);
                _workspaceViewer.Annotations.CurrentLayer.Items.Clear();
            }
        }

        private void WorkspaceViewerOnChangedImage(object sender, ImageEventArgs e)
        {
            if (e.Image != null)
                _statusBar.Panels[0].Text = e.Image.ToString();
        }

        private void WorkspaceViewerOnProcessError(object sender, ExceptionEventArgs e)
        {
            MessageBox.Show(this, e.Exception.ToString());
        }

        private void ThumbnailViewOnThumbnailLoad(object sender, ThumbnailEventArgs e)
        {
            // update the progressbar for every thumbnail load.
            _progressBar.Value += 1;
            if (_progressBar.Value == _progressBar.Maximum)
                _progressBar.Value = 0;
        }

        #region Printing


        private void MenuPrintOnClick(object sender, EventArgs e)
        {
            if (_openFileDialog.FileName == "") // make sure an image is loaded
                return;

            using (var fs = new FileStream(_openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                _docToPrint = new Document(fs);
                _imagesToPrint = _docToPrint.Pages;
                // Use System.Drawing.Print.PrintDocument 
                var printDoc = new PrintDocument();
                printDoc.PrintPage += PrintDocOnPrintPage;
                _current = 0;
                printDoc.Print();
            }
        }

        private void PrintDocOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.HasMorePages = true;
            var p = _imagesToPrint[_current++];
            // fit to page, only when image is too large. 
            var newX = (float)(e.PageBounds.Width / p.Width);
            var newY = (float)(e.PageBounds.Height / p.Height);
            if (!(newX > 1 && newY > 1))
                e.Graphics.ScaleTransform(newX, newY);
            // Draw pdf image onto graphics object here.
            var rs = new RenderSettings { AnnotationSettings = AnnotationRenderSettings.RenderAll };
            p.Draw(e.Graphics, PageBoundary.Default, rs, 500);
            if (_current < _imagesToPrint.Count)
                return;
            e.HasMorePages = false;
            _docToPrint.Dispose(); // make sure to dispose
            _docToPrint = null;
        }

        #endregion

        private void FindDialogOnClosed(object sender, EventArgs e)
        {
            _findDialog = null;
        }

        /// <summary>
        /// This is called when the next button is clicked on the find dialog
        /// </summary>
        /// <param name="findText">The text in the find dialog</param>
        /// <param name="matchCase">true if the search should match case</param>
        /// <param name="wholeWord">true if the search should only find whole words</param>
        private void FindDialogOnFindNext(string findText, bool matchCase, bool wholeWord)
        {
            // find and highlight the text
            if (_currentFile == null)
                return;
            var findHighlighter = new PdfFindHighlighter(_workspaceViewer, _thumbnailView);
            bool found;
            using (var fs = new FileStream(_currentFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                found = _pdfDocSearch.FindNext(fs, findText, matchCase, wholeWord, findHighlighter.HighlightFoundText);
            }
            if (!found)
            {
                MessageBox.Show(Resources.TextNotFoundMessage, Resources.TitleSearchMessage, MessageBoxButtons.OK);
            }
        }
        
        private void MenuPdfDecoderSettingsOnClick(object sender, EventArgs e)
        {
            //set decoder properties
            using (Form frm = new Parameters("PDF Decoder Properties", _pdfDecoder))
            {
                frm.ShowDialog(this);
            }
        }

        #endregion

        private int GetCurrentPage()
        {
            return _thumbnailView.SelectedIndices.Length > 0 ? _thumbnailView.SelectedIndices[0] : 0;
        }

        private void ShowLicenseMessage(string product)
        {
            var dialogResult = MessageBox.Show(
                string.Format(Resources.RequiresLicenseMessage, product),
                string.Format(Resources.TitleRequiresLicenseMessage, product),
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult != DialogResult.Yes)
                return;

            var activationUtil = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                "Atalasoft", "DotImage ");

            // Use reflection to find out which version of DotImage we are using.
            var assemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
            foreach (var name in assemblies)
            {
                if (name.Name != "Atalasoft.dotImage")
                    continue;
                activationUtil += name.Version.ToString(2);
                break;
            }

            activationUtil = Path.Combine(activationUtil, "AtalasoftToolkitActivation.exe");

            if (File.Exists(activationUtil))
                Process.Start(activationUtil);
            else
                MessageBox.Show(Resources.ActivationToolkitNotFoundMessage, Resources.TitleActivationToolkitNotFoundMessage);
        }

        #region Bookmark Code

        // When a bookmark is selected, load the page and scroll to the bookmark position.
        private void TreeBookmarksOnAfterSelect(object sender, TreeViewEventArgs e)
        {
            var bm = e.Node.Tag as PdfBookmark;
            if (bm == null || bm.ClickAction.Count <= 0)
                return;
            var action = bm.ClickAction[0];
            if (action.ActionType != PdfActionType.GoToView)
                return;
            var gotoView = action as PdfGoToViewAction;
            if (gotoView == null || gotoView.Destination == null || gotoView.Destination.Page == null)
                return;
            var page = gotoView.Destination.Page as PdfIndexedPageReference;
            if (page == null)
                return;
            if (page.PageIndex < 0 || page.PageIndex >= _thumbnailView.Items.Count)
                return;
            // Selecting the thumbnail will load the page.
            var pageIndex = GetCurrentPage();
            if (pageIndex != page.PageIndex)
            {
                _thumbnailView.ClearSelection();
                _thumbnailView.Items[page.PageIndex].Selected = true;
                _thumbnailView.ScrollTo(page.PageIndex);
            }

            // The bookmark coordinates are in PDF page coordinates.
            // (0,0) is the lower left corner, increases up and to the right
            // Units are 1/72”

            var y = gotoView.Destination.Top.HasValue
                ? Convert.ToInt32(gotoView.Destination.Top.Value/72.0*_workspaceViewer.Image.Resolution.Y)
                : 0;
            y = _workspaceViewer.Image.Height - y;
            _workspaceViewer.ScrollPosition = new Point(0, -y);
        }

        private void LoadPdfBookmarks(string fileName)
        {
            _treeBookmarks.Nodes.Clear();

            var doc = new PdfDocument(fileName);
            if (doc.BookmarkTree == null) 
                return;
            foreach (var bookmark in doc.BookmarkTree.Bookmarks)
            {
                AddBookMark(null, bookmark);
            }
        }

        private void AddBookMark(TreeNode parent, PdfBookmark bookMark)
        {
            var node = new TreeNode(bookMark.Text)
            {
                ForeColor = bookMark.Color,
                Tag = bookMark
            };

            if (parent == null)
                _treeBookmarks.Nodes.Add(node);
            else
                parent.Nodes.Add(node);

            if (bookMark.Children == null) return;
            foreach (var bm in bookMark.Children)
            {
                AddBookMark(node, bm);
            }
        }

        #endregion
    }
}
