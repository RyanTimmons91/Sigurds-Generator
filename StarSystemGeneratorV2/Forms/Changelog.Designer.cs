namespace StarSystemGeneratorV2
{
	partial class Changelog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changelog));
			this._changeLog = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// _changeLog
			// 
			this._changeLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this._changeLog.Location = new System.Drawing.Point(0, 0);
			this._changeLog.Multiline = true;
			this._changeLog.Name = "_changeLog";
			this._changeLog.ReadOnly = true;
			this._changeLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._changeLog.Size = new System.Drawing.Size(577, 261);
			this._changeLog.TabIndex = 0;
			this._changeLog.TabStop = false;
			// 
			// Changelog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 261);
			this.Controls.Add(this._changeLog);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Changelog";
			this.Text = "Changelog";
			this.Load += new System.EventHandler(this.Changelog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _changeLog;
	}
}