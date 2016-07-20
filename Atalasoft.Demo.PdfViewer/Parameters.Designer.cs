// ------------------------------------------------------------------------------------
// <copyright file="Parameters.Designer.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

namespace Atalasoft.Demo.PdfViewer
{
	partial class Parameters
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Parameters));
			this._grid = new System.Windows.Forms.PropertyGrid();
			this._okButton = new System.Windows.Forms.Button();
			this._cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Grid
			// 
			this._grid.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				| System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right);
			this._grid.CommandsVisibleIfAvailable = true;
			this._grid.LargeButtons = false;
			this._grid.LineColor = System.Drawing.SystemColors.ScrollBar;
			this._grid.Name = "_grid";
			this._grid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this._grid.Size = new System.Drawing.Size(290, 208);
			this._grid.TabIndex = 0;
			this._grid.Text = "propertyGrid1";
			this._grid.ToolbarVisible = false;
			this._grid.ViewBackColor = System.Drawing.SystemColors.Window;
			this._grid.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// btnOk
			// 
			this._okButton.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._okButton.Location = new System.Drawing.Point(49, 216);
			this._okButton.Name = "_okButton";
			this._okButton.Size = new System.Drawing.Size(80, 24);
			this._okButton.TabIndex = 1;
			this._okButton.Text = "&OK";
			this._okButton.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this._cancelButton.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._cancelButton.Location = new System.Drawing.Point(161, 216);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(80, 24);
			this._cancelButton.TabIndex = 2;
			this._cancelButton.Text = "&Cancel";
			// 
			// Parameters
			// 
			this.AcceptButton = this._okButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this._cancelButton;
			this.ClientSize = new System.Drawing.Size(290, 248);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._cancelButton,
																		  this._okButton,
																		  this._grid});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Parameters";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Parameters";
			this.Load += new System.EventHandler(this.Parameters_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _okButton;
		private System.Windows.Forms.PropertyGrid _grid;
	}
}