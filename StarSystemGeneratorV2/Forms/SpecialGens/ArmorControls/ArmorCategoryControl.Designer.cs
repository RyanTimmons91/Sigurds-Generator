namespace StarSystemGeneratorV2.Forms.SpecialGens.ArmorControls
{
	partial class ArmorCategoryControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._categoryText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// _categoryText
			// 
			this._categoryText.Dock = System.Windows.Forms.DockStyle.Fill;
			this._categoryText.Location = new System.Drawing.Point(0, 0);
			this._categoryText.Multiline = true;
			this._categoryText.Name = "_categoryText";
			this._categoryText.ReadOnly = true;
			this._categoryText.Size = new System.Drawing.Size(150, 150);
			this._categoryText.TabIndex = 0;
			// 
			// ArmorCategoryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._categoryText);
			this.Name = "ArmorCategoryControl";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _categoryText;
	}
}
