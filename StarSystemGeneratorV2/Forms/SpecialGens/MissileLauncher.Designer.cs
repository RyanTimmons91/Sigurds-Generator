namespace StarSystemGeneratorV2.Forms.SpecialGens
{
	partial class MissileLauncher
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
			this._cost = new System.Windows.Forms.TextBox();
			this._weight = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._tubeType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._magSize = new System.Windows.Forms.NumericUpDown();
			this._magType = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._magSize)).BeginInit();
			this.SuspendLayout();
			// 
			// _cost
			// 
			this._cost.Location = new System.Drawing.Point(111, 92);
			this._cost.Name = "_cost";
			this._cost.ReadOnly = true;
			this._cost.Size = new System.Drawing.Size(100, 20);
			this._cost.TabIndex = 0;
			this._cost.TabStop = false;
			// 
			// _weight
			// 
			this._weight.Location = new System.Drawing.Point(111, 118);
			this._weight.Name = "_weight";
			this._weight.ReadOnly = true;
			this._weight.Size = new System.Drawing.Size(100, 20);
			this._weight.TabIndex = 1;
			this._weight.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(77, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cost";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(64, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Weight";
			// 
			// _tubeType
			// 
			this._tubeType.FormattingEnabled = true;
			this._tubeType.Items.AddRange(new object[] {
            "Hard Point",
            "Short Range Rocket Tube",
            "Medium Range Rocket Tube",
            "Long Range Rocket Tube",
            "Heavy Rocket Tube",
            "Short Range Missile Tube",
            "Medium Range Missile Tube",
            "Long Range Misile Tube",
            "Heavy Missile Tube"});
			this._tubeType.Location = new System.Drawing.Point(90, 12);
			this._tubeType.Name = "_tubeType";
			this._tubeType.Size = new System.Drawing.Size(121, 21);
			this._tubeType.TabIndex = 0;
			this._tubeType.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tube Type";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Mag Size";
			// 
			// _magSize
			// 
			this._magSize.Location = new System.Drawing.Point(90, 39);
			this._magSize.Name = "_magSize";
			this._magSize.Size = new System.Drawing.Size(121, 20);
			this._magSize.TabIndex = 1;
			this._magSize.ValueChanged += new System.EventHandler(this.ValueChanged);
			// 
			// _magType
			// 
			this._magType.FormattingEnabled = true;
			this._magType.Items.AddRange(new object[] {
            "Single Hard Point",
            "MER Hard Point",
            "AMER Hard Point",
            "Short Range Rocket Magazine",
            "Medium Range Rocket Magazine",
            "Long Range Rocket Magazine",
            "Heavy Rocket Magazine",
            "Short Range Missile Magazine",
            "Medium Range Missile Magazine",
            "Long Range Misile Magazine",
            "Heavy Missile Magazine"});
			this._magType.Location = new System.Drawing.Point(90, 65);
			this._magType.Name = "_magType";
			this._magType.Size = new System.Drawing.Size(121, 21);
			this._magType.TabIndex = 2;
			this._magType.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Mag Type";
			// 
			// MissileLauncher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(219, 151);
			this.Controls.Add(this.label5);
			this.Controls.Add(this._magType);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._magSize);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._tubeType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._weight);
			this.Controls.Add(this._cost);
			this.Name = "MissileLauncher";
			this.Text = "MissileLauncher";
			((System.ComponentModel.ISupportInitialize)(this._magSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _cost;
		private System.Windows.Forms.TextBox _weight;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox _tubeType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown _magSize;
		private System.Windows.Forms.ComboBox _magType;
		private System.Windows.Forms.Label label5;
	}
}