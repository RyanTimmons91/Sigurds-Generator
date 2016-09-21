namespace StarSystemGeneratorV2
{
	partial class LogF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogF));
			this._logOutput = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _logOutput
			// 
			resources.ApplyResources(this._logOutput, "_logOutput");
			this._logOutput.Name = "_logOutput";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// LogF
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._logOutput);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "LogF";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogF_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _logOutput;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
	}
}