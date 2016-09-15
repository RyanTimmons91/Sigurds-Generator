namespace StarSystemGeneratorV2.EntityControls
{
	partial class GasGiantControl
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
			this._sizeBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._gasGiantType = new System.Windows.Forms.TextBox();
			this._otherAtmospheres = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this._lostCivBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Size:";
			// 
			// _sizeBox
			// 
			this._sizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._sizeBox.Location = new System.Drawing.Point(60, 3);
			this._sizeBox.Name = "_sizeBox";
			this._sizeBox.Size = new System.Drawing.Size(204, 20);
			this._sizeBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Type:";
			// 
			// _gasGiantType
			// 
			this._gasGiantType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._gasGiantType.Location = new System.Drawing.Point(60, 29);
			this._gasGiantType.Name = "_gasGiantType";
			this._gasGiantType.Size = new System.Drawing.Size(204, 20);
			this._gasGiantType.TabIndex = 3;
			// 
			// _otherAtmospheres
			// 
			this._otherAtmospheres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._otherAtmospheres.FormattingEnabled = true;
			this._otherAtmospheres.IntegralHeight = false;
			this._otherAtmospheres.Location = new System.Drawing.Point(3, 81);
			this._otherAtmospheres.Name = "_otherAtmospheres";
			this._otherAtmospheres.Size = new System.Drawing.Size(261, 47);
			this._otherAtmospheres.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Lost Civ.:";
			// 
			// _lostCivBox
			// 
			this._lostCivBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._lostCivBox.Location = new System.Drawing.Point(60, 55);
			this._lostCivBox.Name = "_lostCivBox";
			this._lostCivBox.Size = new System.Drawing.Size(204, 20);
			this._lostCivBox.TabIndex = 6;
			// 
			// GasGiantControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._lostCivBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._otherAtmospheres);
			this.Controls.Add(this._gasGiantType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._sizeBox);
			this.Controls.Add(this.label1);
			this.Name = "GasGiantControl";
			this.Size = new System.Drawing.Size(267, 131);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _sizeBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _gasGiantType;
		private System.Windows.Forms.ListBox _otherAtmospheres;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _lostCivBox;
	}
}
