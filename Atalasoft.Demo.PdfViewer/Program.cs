// ------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using Atalasoft.Demo.PdfViewer.Properties;
using Squirrel;

namespace Atalasoft.Demo.PdfViewer
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            try
            {
                using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/Atalasoft/pdf-viewer-demo"))
                {
                    mgr.Result.UpdateApp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.UpgradeErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
