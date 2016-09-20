namespace StarSystemGeneratorV2.Forms.SpecialGens.ArmorControls
{
	partial class ArmorEquipmentMultiLevelControl
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
			this._ItemDescription = new System.Windows.Forms.TextBox();
			this._level = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this._bonusBox = new System.Windows.Forms.TextBox();
			this._weight = new System.Windows.Forms.TextBox();
			this._cost = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._level)).BeginInit();
			this.SuspendLayout();
			// 
			// _ItemDescription
			// 
			this._ItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._ItemDescription.Location = new System.Drawing.Point(3, 3);
			this._ItemDescription.Multiline = true;
			this._ItemDescription.Name = "_ItemDescription";
			this._ItemDescription.ReadOnly = true;
			this._ItemDescription.Size = new System.Drawing.Size(389, 140);
			this._ItemDescription.TabIndex = 0;
			this._ItemDescription.Text = "_description";
			// 
			// _level
			// 
			this._level.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._level.Location = new System.Drawing.Point(292, 201);
			this._level.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this._level.Name = "_level";
			this._level.Size = new System.Drawing.Size(100, 20);
			this._level.TabIndex = 2;
			this._level.ValueChanged += new System.EventHandler(this._level_ValueChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(242, 203);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Level:";
			// 
			// _bonusBox
			// 
			this._bonusBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._bonusBox.Location = new System.Drawing.Point(3, 149);
			this._bonusBox.Multiline = true;
			this._bonusBox.Name = "_bonusBox";
			this._bonusBox.ReadOnly = true;
			this._bonusBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this._bonusBox.Size = new System.Drawing.Size(193, 125);
			this._bonusBox.TabIndex = 4;
			// 
			// _weight
			// 
			this._weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._weight.Location = new System.Drawing.Point(292, 149);
			this._weight.Name = "_weight";
			this._weight.ReadOnly = true;
			this._weight.Size = new System.Drawing.Size(100, 20);
			this._weight.TabIndex = 5;
			// 
			// _cost
			// 
			this._cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cost.Location = new System.Drawing.Point(292, 175);
			this._cost.Name = "_cost";
			this._cost.ReadOnly = true;
			this._cost.Size = new System.Drawing.Size(100, 20);
			this._cost.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(242, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Weight:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(242, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Cost:";
			// 
			// ArmorEquipmentMultiLevelControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._cost);
			this.Controls.Add(this._weight);
			this.Controls.Add(this._bonusBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._level);
			this.Controls.Add(this._ItemDescription);
			this.Name = "ArmorEquipmentMultiLevelControl";
			this.Size = new System.Drawing.Size(395, 277);
			((System.ComponentModel.ISupportInitialize)(this._level)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.NumericUpDown _level;
		internal System.Windows.Forms.TextBox _bonusBox;
		internal System.Windows.Forms.TextBox _weight;
		internal System.Windows.Forms.TextBox _cost;
		internal System.Windows.Forms.TextBox _ItemDescription;
	}
}
