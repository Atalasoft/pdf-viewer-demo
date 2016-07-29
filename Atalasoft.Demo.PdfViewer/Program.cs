// ------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
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
		    Task.Run(async () =>
		    {
		        try
		        {
		            using (var manager = await UpdateManager.GitHubUpdateManager("https://github.com/Atalasoft/pdf-viewer-demo"))
		            {
		                if (manager != null)
		                {
		                    var result = await manager.UpdateApp();
		                    if (result != null)
		                    {
		                        if (MessageBox.Show(Resources.UpdateAvailableQuestion, Resources.UpdateAvailable, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		                        {
		                            UpdateManager.RestartApp();
		                        }
		                    }
		                }
		            }
		        }

		        catch (Exception ex)
		        {
		            MessageBox.Show(ex.Message, Resources.UpgradeErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		        }
		    });          

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
