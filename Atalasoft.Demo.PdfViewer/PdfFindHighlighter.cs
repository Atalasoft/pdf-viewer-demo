// ------------------------------------------------------------------------------------
// <copyright file="PdfFindHighlighter.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System.Drawing;
using Atalasoft.Imaging.WinControls;
using Atalasoft.Annotate.UI;
using Atalasoft.Annotate;
using Atalasoft.Pdf.TextExtract;
using Atalasoft.Utils.Geometry;

namespace Atalasoft.Demo.PdfViewer
{
    /// <summary>
    /// Summary description for PdfFindHighlighter.
    /// </summary>
    public class PdfFindHighlighter
    {
        private readonly AnnotateViewer _viewer;
        private readonly ThumbnailView _thumbnailViewer;
        private Color _hiColor = Color.LightBlue;

        /// <summary>
        /// A class to highlight pdf documents that are in an annotation viewer and have a thumbnail viewer
        /// </summary>
        /// <param name="viewer">An annotation viewer with one layer for putting highlights on</param>
        /// <param name="thumbnailViewer">An optional thumbnail viewer (can be null)</param>
        public PdfFindHighlighter(AnnotateViewer viewer, ThumbnailView thumbnailViewer)
        {
            _viewer = viewer;
            _thumbnailViewer = thumbnailViewer;
        }

        /// <summary>
        /// The color to draw the highlights in (will be automatically made translucent)
        /// </summary>
        public Color HighlightColor
        {
            get { return _hiColor; }
            set { _hiColor = value; }
        }

        /// <summary>
        /// Highlights the found text on the PDF, makes sure the page is selected and the scroll
        /// position is set so that the highlight can be seen
        /// </summary>
        /// <param name="pdfPage">The PDF Page with the text on it</param>
        /// <param name="pageNum">The page number (0-based)</param>
        /// <param name="charIndex">The index of the first character to highlight</param>
        /// <param name="len">The length of the text to highlight</param>
        public void HighlightFoundText(PdfTextPage pdfPage, int pageNum, int charIndex, int len)
        {
            SelectThumb(_thumbnailViewer, pageNum);
            HighlightChars(_viewer, pdfPage, _hiColor, charIndex, len);
        }

        /// <summary>
        /// Select the given thumb
        /// </summary>
        /// <param name="tv">Thumbnail view.</param>
        /// <param name="page">A 0-based index to the page to select</param>
        private void SelectThumb(ThumbnailView tv, int page)
        {
            if (tv == null || tv.Items[page].Selected)
                return;
            tv.ClearSelection();
            tv.Items[page].Selected = true;
            tv.ScrollTo(page);
        }

        /// <summary>
        /// Puts an annotation over the characters in a PDF page
        /// </summary>
        /// <param name="v">Annotate viewer</param>
        /// <param name="p">A PDF Text page</param>
        /// <param name="hiColor">The highlight color</param>
        /// <param name="index">The index of the first character within the page</param>
        /// <param name="len">The number of characters to highlight</param>
        private void HighlightChars(AnnotateViewer v, PdfTextPage p, Color hiColor, int index, int len)
        {
            // take off all existing hilights
            LayerAnnotation layer = v.Annotations.CurrentLayer;
            layer.Items.Clear();

            // a single phrase can span a line and need more than one box to
            // highlight it
            QuadrilateralF[] pdfBoxes = p.GetBoxes(index, len);
            foreach (QuadrilateralF b in pdfBoxes)
            {
                HighlightPdfBox(p, v, layer, b.Bounds, hiColor, 2);
            }
        }

        /// <summary>
        /// Puts a highlight rectangle over the box which is expressed in PDF coordinate space
        /// </summary>
        /// <param name="p">A PDF Text page</param>
        /// <param name="v">The viewer to put the annotation on</param>
        /// <param name="layer">The layer to put the annotation on</param>
        /// <param name="pdfBox">The box to highlight in PDF coordinate space</param>
        /// <param name="hiColor">The color to highlight with</param>
        /// <param name="padding">Extra padding around the box in pixels</param>
        private void HighlightPdfBox(PdfTextPage p, AnnotateViewer v, LayerAnnotation layer, RectangleF pdfBox, Color hiColor, int padding)
        {
            RectangleF imageBox = p.ConvertPdfUnitsToPixels(new QuadrilateralF(pdfBox), v.Image.Resolution).Bounds;
            imageBox.X = imageBox.X - padding;
            imageBox.Y = imageBox.Y - padding;
            imageBox.Width = imageBox.Width + 2 * padding;
            imageBox.Height = imageBox.Height + 2 * padding;
            HighlightImageBox(v, layer, imageBox, hiColor);
        }

        /// <summary>
        /// Puts a highlight rectangle over the box which is expressed in the image's coordinate space
        /// </summary>
        /// <param name="layer">The layer to put the annotation on</param>
        /// <param name="imageBox">The box to highlight in Image coordinate space</param>
        /// <param name="hiColor">The color to highlight with</param>
        private void HighlightImageBox(AnnotateViewer v, LayerAnnotation layer, RectangleF imageBox, Color hiColor)
        {
            CreateHighlightAnnotation(layer, imageBox, hiColor);
            EnsureAreaIsVisible(v, imageBox);
        }

        /// <summary>
        /// Put an annotation on the layer that highlights the rectangle in the color passed in
        /// </summary>
        /// <param name="layer">The layer on which to put the annotation</param>
        /// <param name="imageBox">The bounds of the annotation</param>
        /// <param name="hiColor">The color of the annotation</param>
        private void CreateHighlightAnnotation(LayerAnnotation layer, RectangleF imageBox, Color hiColor)
        {
            RectangleAnnotation ra = new RectangleAnnotation(imageBox, new AnnotationBrush(hiColor), null)
            {
                Translucent = true
            };
            ra.Data.CanMove = false;
            ra.Data.CanResize = false;
            ra.Data.CanSelect = false;
            ra.Data.CanRotate = false;
            layer.Items.Add(ra);
        }

        /// <summary>
        /// Scrolls the image to make sure that the box is visible
        /// </summary>
        /// <param name="v">Annotate viewer</param>
        /// <param name="imageBox">The box to make sure is visible</param>
        private void EnsureAreaIsVisible(AnnotateViewer v, RectangleF imageBox)
        {
            Point sp = v.ScrollPosition;

            int x = GetAdjustedScrollPos(sp.X, imageBox.Left, imageBox.Right, v.ClientSize.Width, v.Zoom);
            int y = GetAdjustedScrollPos(sp.Y, imageBox.Top, imageBox.Bottom, v.ClientSize.Height, v.Zoom);

            v.ScrollPosition = new Point(x, y);
        }

        /// <summary>
        /// Figures out the new scroll position based on the current scroll and the area that should be shown.
        /// If the area is shown under the current position, it is not adjusted.
        /// </summary>
        /// <param name="clientScrollPos">The current scroll, in display pixels.  If the area is shown with this scroll, it is not adjusted</param>
        /// <param name="min">The minimum position to be visible, in image pixels</param>
        /// <param name="max">The maximum position to be visible, in image pixels</param>
        /// <param name="clientSize">The size of the client window in display pixels</param>
        /// <param name="zoomLevel">The zoom level of the viewer</param>
        /// <returns>The new scroll position adjusted if necessary</returns>
        private int GetAdjustedScrollPos(int clientScrollPos, float min, float max, int clientSize, double zoomLevel)
        {
            int clientMin = (int)(min * zoomLevel);
            int clientMax = (int)(max * zoomLevel);
            if (clientMin < -clientScrollPos)
            {
                clientScrollPos = -clientMin;
            }
            else if (clientMax > -clientScrollPos + clientSize)
            {
                clientScrollPos = -clientMin;
            }
            return clientScrollPos;
        }
    }
}
