// ------------------------------------------------------------------------------------
// <copyright file="FindDialog.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace Atalasoft.Demo.PdfViewer
{
	public partial class FindDialog : Form
	{
		public delegate void FindNextHandler(String text, bool matchCase, bool wholeWord);
		public event FindNextHandler OnFindNext;

		public FindDialog()
		{
			InitializeComponent();
		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			var handle = OnFindNext;
			if (handle != null)
				handle(txtFind.Text, cbMatchCase.Checked, cbWholeWord.Checked);
		}
	}
}
