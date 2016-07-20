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
		public delegate void FindNextHandler(string text, bool matchCase, bool wholeWord);
		public event FindNextHandler FindNext;

		public FindDialog()
		{
			InitializeComponent();
		}

		private void NextButtonOnClick(object sender, EventArgs e)
		{
			var handle = FindNext;
			if (handle != null)
				handle(_findTextBox.Text, _matchCaseCheckBox.Checked, _wholeWordCheckBox.Checked);
		}
	}
}
