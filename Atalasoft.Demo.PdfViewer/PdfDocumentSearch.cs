// ------------------------------------------------------------------------------------
// <copyright file="PdfDocumentSearch.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System.IO;
using System.Windows.Forms;
using Atalasoft.Demo.PdfViewer.Properties;
using Atalasoft.Pdf.TextExtract;

namespace Atalasoft.Demo.PdfViewer
{
    /// <summary>
    /// Summary description for PdfDocumentSearch.
    /// </summary>
    public class PdfDocumentSearch
    {
        public delegate void FindTextHandler(PdfTextPage pdfPage, int pageNum, int charIndex, int len);

        private int _currentFindPos;
        private int _currentFindPage;

        /// <summary>
        /// Starts a PDF document search on the given page.
        /// </summary>
        /// <param name="startPage">The page to start on</param>
        public PdfDocumentSearch(int startPage)
        {
            _currentFindPage = startPage;
        }

        /// <summary>
        /// Finds the next instance of the text in the stream representing a PDF
        /// </summary>
        /// <param name="stream">A stream with a PDF in it</param>
        /// <param name="findText">The text to find</param>
        /// <param name="matchCase">true if the search should match the case of the text</param>
        /// <param name="wholeWord">true if only whole words should be found</param>
        /// <param name="onFindText">A delegate to call when text is found</param>
        /// <returns>true if the text was found, false otherwise</returns>
        public bool FindNext(Stream stream, string findText, bool matchCase, bool wholeWord, FindTextHandler onFindText)
        {
            var findPage = _currentFindPage;

            // Document objects must be disposed.  
            // This makes sure it happens even if there is an exception
            using (var document = new PdfTextDocument(stream))
            {
                var found = false;
                var loopedToBeginning = false;
                while (!found)
                {
                    var p = document.GetPage(findPage);
                    if (p.CharCount > 0)
                    {
                        using (var srchRes = p.Search(_currentFindPos, findText, matchCase, wholeWord))
                        {
                            srchRes.FindNext();

                            // if you found something, tell the delegate where it is
                            if (srchRes.HasResults)
                            {
                                onFindText(p, findPage, srchRes.StartIndex, srchRes.CharCount);
                                _currentFindPos = srchRes.StartIndex + 1;
                                _currentFindPage = findPage;
                                found = true;
                            }
                            // if we are back at the start page, then the text is not in the doc
                            else if (loopedToBeginning)
                            {
                                break;
                            }
                            // otherwise go to the next page
                            else
                            {
                                findPage = (findPage + 1) % document.PageCount;
                                _currentFindPos = 0;
                                if (findPage == _currentFindPage)
                                {
                                    loopedToBeginning = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(Resources.NoTextDataMessage, Resources.TitleNoTextDataMessage);
                        break;
                    }
                }
                return found;
            }
        }
    }
}
