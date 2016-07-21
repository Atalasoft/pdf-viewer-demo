// ------------------------------------------------------------------------------------
// <copyright file="Parameters.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System.Windows.Forms;

namespace Atalasoft.Demo.PdfViewer
{
	public partial class Parameters : Form
	{
		public Parameters(string text, object selectedObject)
		{
			InitializeComponent();

			Text = text;
			_grid.SelectedObject = selectedObject;
        }
	}
}
