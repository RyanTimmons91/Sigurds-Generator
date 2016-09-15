namespace StarSystemGeneratorV2
{
	partial class ResourceCalc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceCalc));
			this._resourceType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this._planetSize = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._resourceAmount = new System.Windows.Forms.ComboBox();
			this._output = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._perTrack = new System.Windows.Forms.TrackBar();
			this._percentage = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this._modifiedOutput = new System.Windows.Forms.TextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this._perTrack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// _resourceType
			// 
			this._resourceType.FormattingEnabled = true;
			this._resourceType.Items.AddRange(new object[] {
            "Iron",
            "Copper",
            "Silver",
            "Gold",
            "Platinum",
            "Palladium",
            "Rhodium h.Metal",
            "Titanium p.Metal",
            "Chromium (GemStones)",
            "Other Minerals (zinc)",
            "Lithium ",
            "M-Chryst"});
			this._resourceType.Location = new System.Drawing.Point(97, 12);
			this._resourceType.Name = "_resourceType";
			this._resourceType.Size = new System.Drawing.Size(250, 21);
			this._resourceType.TabIndex = 0;
			this._resourceType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Resource:";
			// 
			// _planetSize
			// 
			this._planetSize.FormattingEnabled = true;
			this._planetSize.Items.AddRange(new object[] {
            "Small Asteroid",
            "Medium Asteroid",
            "Large Asteroid",
            "Luna Planet",
            "Small Planet",
            "Medium Planet",
            "Large Planet",
            "Giant Planet"});
			this._planetSize.Location = new System.Drawing.Point(97, 39);
			this._planetSize.Name = "_planetSize";
			this._planetSize.Size = new System.Drawing.Size(250, 21);
			this._planetSize.TabIndex = 2;
			this._planetSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Resource Size:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Planet Size:";
			// 
			// _resourceAmount
			// 
			this._resourceAmount.FormattingEnabled = true;
			this._resourceAmount.Items.AddRange(new object[] {
            "Minor",
            "Moderate",
            "Major",
            "Extreme"});
			this._resourceAmount.Location = new System.Drawing.Point(97, 66);
			this._resourceAmount.Name = "_resourceAmount";
			this._resourceAmount.Size = new System.Drawing.Size(250, 21);
			this._resourceAmount.TabIndex = 5;
			this._resourceAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// _output
			// 
			this._output.Location = new System.Drawing.Point(97, 123);
			this._output.Name = "_output";
			this._output.ReadOnly = true;
			this._output.Size = new System.Drawing.Size(250, 20);
			this._output.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Output:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(353, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "GSC";
			// 
			// _perTrack
			// 
			this._perTrack.Location = new System.Drawing.Point(97, 151);
			this._perTrack.Maximum = 100;
			this._perTrack.Minimum = 1;
			this._perTrack.Name = "_perTrack";
			this._perTrack.Size = new System.Drawing.Size(195, 45);
			this._perTrack.TabIndex = 9;
			this._perTrack.Value = 100;
			this._perTrack.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// _percentage
			// 
			this._percentage.AutoSize = true;
			this._percentage.Location = new System.Drawing.Point(26, 151);
			this._percentage.Name = "_percentage";
			this._percentage.Size = new System.Drawing.Size(65, 13);
			this._percentage.TabIndex = 10;
			this._percentage.Text = "Percentage:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(353, 205);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "GSC";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(44, 205);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 12;
			this.label10.Text = "Modifier:";
			// 
			// _modifiedOutput
			// 
			this._modifiedOutput.Location = new System.Drawing.Point(97, 202);
			this._modifiedOutput.Name = "_modifiedOutput";
			this._modifiedOutput.ReadOnly = true;
			this._modifiedOutput.Size = new System.Drawing.Size(250, 20);
			this._modifiedOutput.TabIndex = 11;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 8;
			this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDown1.Location = new System.Drawing.Point(298, 151);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            524288});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(84, 20);
			this.numericUpDown1.TabIndex = 14;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// ResourceCalc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 235);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label10);
			this.Controls.Add(this._modifiedOutput);
			this.Controls.Add(this._percentage);
			this.Controls.Add(this._perTrack);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._output);
			this.Controls.Add(this._resourceAmount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._planetSize);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._resourceType);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ResourceCalc";
			this.Text = "ResourceCalc";
			((System.ComponentModel.ISupportInitialize)(this._perTrack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _resourceType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox _planetSize;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox _resourceAmount;
		private System.Windows.Forms.TextBox _output;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TrackBar _perTrack;
		private System.Windows.Forms.Label _percentage;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox _modifiedOutput;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}