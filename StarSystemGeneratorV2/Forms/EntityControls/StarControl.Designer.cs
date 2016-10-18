namespace StarSystemGeneratorV2.EntityControls
{
	partial class StarControl
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._methoxyBox = new System.Windows.Forms.TextBox();
            this._oxygenCountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._HE3CountBox = new System.Windows.Forms.TextBox();
            this._planetCountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Oxygen Atmo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "OxyMeth Atmo:";
            // 
            // _methoxyBox
            // 
            this._methoxyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._methoxyBox.Location = new System.Drawing.Point(98, 81);
            this._methoxyBox.Name = "_methoxyBox";
            this._methoxyBox.Size = new System.Drawing.Size(190, 20);
            this._methoxyBox.TabIndex = 20;
            // 
            // _oxygenCountBox
            // 
            this._oxygenCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._oxygenCountBox.Location = new System.Drawing.Point(98, 55);
            this._oxygenCountBox.Name = "_oxygenCountBox";
            this._oxygenCountBox.Size = new System.Drawing.Size(190, 20);
            this._oxygenCountBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "HE3 Atmo Count:";
            // 
            // _HE3CountBox
            // 
            this._HE3CountBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._HE3CountBox.Location = new System.Drawing.Point(98, 29);
            this._HE3CountBox.Name = "_HE3CountBox";
            this._HE3CountBox.Size = new System.Drawing.Size(190, 20);
            this._HE3CountBox.TabIndex = 15;
            // 
            // _planetCountBox
            // 
            this._planetCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._planetCountBox.Location = new System.Drawing.Point(98, 3);
            this._planetCountBox.Name = "_planetCountBox";
            this._planetCountBox.Size = new System.Drawing.Size(190, 20);
            this._planetCountBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Planet Count:";
            // 
            // StarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._methoxyBox);
            this.Controls.Add(this._oxygenCountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._HE3CountBox);
            this.Controls.Add(this._planetCountBox);
            this.Controls.Add(this.label1);
            this.Name = "StarControl";
            this.Size = new System.Drawing.Size(291, 115);
            this.Load += new System.EventHandler(this.StarControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox _methoxyBox;
		private System.Windows.Forms.TextBox _oxygenCountBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _HE3CountBox;
		private System.Windows.Forms.TextBox _planetCountBox;
		private System.Windows.Forms.Label label1;

	}
}
