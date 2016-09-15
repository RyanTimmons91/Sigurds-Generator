namespace StarSystemGeneratorV2
{
	partial class Options
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
			this._generatorVersion = new System.Windows.Forms.ComboBox();
			this._save = new System.Windows.Forms.Button();
			this._cancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _generatorVersion
			// 
			this._generatorVersion.FormattingEnabled = true;
			this._generatorVersion.Items.AddRange(new object[] {
            "25",
            "24",
            "23",
            "22",
            "21",
            "20",
            "19",
            "18",
            "17",
            "16",
            "15",
            "14"});
			this._generatorVersion.Location = new System.Drawing.Point(113, 12);
			this._generatorVersion.Name = "_generatorVersion";
			this._generatorVersion.Size = new System.Drawing.Size(159, 21);
			this._generatorVersion.TabIndex = 0;
			// 
			// _save
			// 
			this._save.Location = new System.Drawing.Point(197, 226);
			this._save.Name = "_save";
			this._save.Size = new System.Drawing.Size(75, 23);
			this._save.TabIndex = 1;
			this._save.Text = "Save";
			this._save.UseVisualStyleBackColor = true;
			this._save.Click += new System.EventHandler(this._save_Click);
			// 
			// _cancel
			// 
			this._cancel.Location = new System.Drawing.Point(12, 226);
			this._cancel.Name = "_cancel";
			this._cancel.Size = new System.Drawing.Size(75, 23);
			this._cancel.TabIndex = 2;
			this._cancel.Text = "Cancel";
			this._cancel.UseVisualStyleBackColor = true;
			this._cancel.Click += new System.EventHandler(this._cancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Generator Version:";
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._save);
			this.Controls.Add(this._generatorVersion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Options";
			this.ShowInTaskbar = false;
			this.Text = "Options";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Options_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _generatorVersion;
		private System.Windows.Forms.Button _save;
		private System.Windows.Forms.Button _cancel;
		private System.Windows.Forms.Label label1;
	}
}