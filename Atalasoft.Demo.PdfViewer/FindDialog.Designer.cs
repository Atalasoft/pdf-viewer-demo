// ------------------------------------------------------------------------------------
// <copyright file="FindDialog.Designer.cs" company="Atalasoft">
//     (c) 2000-2016 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

namespace Atalasoft.Demo.PdfViewer
{
	partial class FindDialog
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
            this._findTextBox = new System.Windows.Forms.TextBox();
            this._nextButton = new System.Windows.Forms.Button();
            this._matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this._wholeWordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _findTextBox
            // 
            this._findTextBox.Location = new System.Drawing.Point(8, 9);
            this._findTextBox.Name = "_findTextBox";
            this._findTextBox.Size = new System.Drawing.Size(168, 20);
            this._findTextBox.TabIndex = 0;
            // 
            // _nextButton
            // 
            this._nextButton.Location = new System.Drawing.Point(188, 7);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(64, 24);
            this._nextButton.TabIndex = 1;
            this._nextButton.Text = "Next";
            this._nextButton.Click += new System.EventHandler(this.NextButtonOnClick);
            // 
            // _matchCaseCheckBox
            // 
            this._matchCaseCheckBox.Location = new System.Drawing.Point(8, 32);
            this._matchCaseCheckBox.Name = "_matchCaseCheckBox";
            this._matchCaseCheckBox.Size = new System.Drawing.Size(96, 24);
            this._matchCaseCheckBox.TabIndex = 2;
            this._matchCaseCheckBox.Text = "Match &Case";
            // 
            // _wholeWordCheckBox
            // 
            this._wholeWordCheckBox.Location = new System.Drawing.Point(104, 32);
            this._wholeWordCheckBox.Name = "_wholeWordCheckBox";
            this._wholeWordCheckBox.Size = new System.Drawing.Size(104, 24);
            this._wholeWordCheckBox.TabIndex = 3;
            this._wholeWordCheckBox.Text = "&Whole Word";
            // 
            // FindDialog
            // 
            this.AcceptButton = this._nextButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(264, 62);
            this.Controls.Add(this._wholeWordCheckBox);
            this.Controls.Add(this._matchCaseCheckBox);
            this.Controls.Add(this._nextButton);
            this.Controls.Add(this._findTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(272, 72);
            this.Name = "FindDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Text";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		
		private System.Windows.Forms.CheckBox _wholeWordCheckBox;
		private System.Windows.Forms.CheckBox _matchCaseCheckBox;
		private System.Windows.Forms.Button _nextButton;
		private System.Windows.Forms.TextBox _findTextBox;
	}
}