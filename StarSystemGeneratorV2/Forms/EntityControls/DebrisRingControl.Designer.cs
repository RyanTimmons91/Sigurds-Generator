namespace StarSystemGeneratorV2.EntityControls
{
	partial class DebrisRingControl
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
			this.label1 = new System.Windows.Forms.Label();
			this._resourceTypeBox = new System.Windows.Forms.TextBox();
			this._resourceOutput = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type:";
			// 
			// _resourceTypeBox
			// 
			this._resourceTypeBox.Location = new System.Drawing.Point(43, 3);
			this._resourceTypeBox.Name = "_resourceTypeBox";
			this._resourceTypeBox.Size = new System.Drawing.Size(179, 20);
			this._resourceTypeBox.TabIndex = 1;
			// 
			// _resourceOutput
			// 
			this._resourceOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._resourceOutput.Location = new System.Drawing.Point(3, 29);
			this._resourceOutput.Name = "_resourceOutput";
			this._resourceOutput.Size = new System.Drawing.Size(219, 230);
			this._resourceOutput.TabIndex = 2;
			// 
			// DebrisRing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._resourceOutput);
			this.Controls.Add(this._resourceTypeBox);
			this.Controls.Add(this.label1);
			this.Name = "DebrisRing";
			this.Size = new System.Drawing.Size(225, 262);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _resourceTypeBox;
		private System.Windows.Forms.TreeView _resourceOutput;
	}
}
