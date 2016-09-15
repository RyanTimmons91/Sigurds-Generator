namespace StarSystemGeneratorV2.Forms.SpecialGens
{
	partial class HandheldWeapons
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandheldWeapons));
			this._weaponType = new System.Windows.Forms.ComboBox();
			this._damageType = new System.Windows.Forms.ComboBox();
			this._accesories = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._condition = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._range = new System.Windows.Forms.NumericUpDown();
			this._capacity = new System.Windows.Forms.NumericUpDown();
			this._damage = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this._bfCheck = new System.Windows.Forms.CheckBox();
			this._saCheck = new System.Windows.Forms.CheckBox();
			this._ssCheck = new System.Windows.Forms.CheckBox();
			this._faCheck = new System.Windows.Forms.CheckBox();
			this._totalCost = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this._availability = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._radius = new System.Windows.Forms.NumericUpDown();
			this._picRails = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this._superior = new System.Windows.Forms.CheckBox();
			this._lightweight = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this._totalWeight = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this._range)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._capacity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._damage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._availability)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._radius)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._picRails)).BeginInit();
			this.SuspendLayout();
			// 
			// _weaponType
			// 
			this._weaponType.FormattingEnabled = true;
			this._weaponType.Location = new System.Drawing.Point(93, 12);
			this._weaponType.Name = "_weaponType";
			this._weaponType.Size = new System.Drawing.Size(121, 21);
			this._weaponType.TabIndex = 0;
			this._weaponType.SelectedIndexChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// _damageType
			// 
			this._damageType.FormattingEnabled = true;
			this._damageType.Location = new System.Drawing.Point(93, 39);
			this._damageType.Name = "_damageType";
			this._damageType.Size = new System.Drawing.Size(121, 21);
			this._damageType.TabIndex = 12;
			this._damageType.SelectedIndexChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// _accesories
			// 
			this._accesories.FormattingEnabled = true;
			this._accesories.IntegralHeight = false;
			this._accesories.Location = new System.Drawing.Point(220, 12);
			this._accesories.Name = "_accesories";
			this._accesories.Size = new System.Drawing.Size(169, 231);
			this._accesories.TabIndex = 13;
			this._accesories.Click += new System.EventHandler(this.FormValueChanged);
			this._accesories.SelectedValueChanged += new System.EventHandler(this.FormValueChanged);
			this._accesories.KeyUp += new System.Windows.Forms.KeyEventHandler(this._accesories_KeyUp);
			this._accesories.MouseUp += new System.Windows.Forms.MouseEventHandler(this._accesories_MouseUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Weapon Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Damage Type";
			// 
			// _condition
			// 
			this._condition.FormattingEnabled = true;
			this._condition.Location = new System.Drawing.Point(93, 66);
			this._condition.Name = "_condition";
			this._condition.Size = new System.Drawing.Size(121, 21);
			this._condition.TabIndex = 17;
			this._condition.SelectedIndexChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Availability";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 19;
			this.label4.Text = "Condition";
			// 
			// _range
			// 
			this._range.Location = new System.Drawing.Point(93, 171);
			this._range.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this._range.Name = "_range";
			this._range.Size = new System.Drawing.Size(121, 20);
			this._range.TabIndex = 21;
			this._range.ValueChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// _capacity
			// 
			this._capacity.Location = new System.Drawing.Point(93, 145);
			this._capacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this._capacity.Name = "_capacity";
			this._capacity.Size = new System.Drawing.Size(121, 20);
			this._capacity.TabIndex = 22;
			this._capacity.ValueChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// _damage
			// 
			this._damage.Location = new System.Drawing.Point(93, 119);
			this._damage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this._damage.Name = "_damage";
			this._damage.Size = new System.Drawing.Size(121, 20);
			this._damage.TabIndex = 23;
			this._damage.ValueChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 173);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 25;
			this.label6.Text = "Range";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 147);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 13);
			this.label7.TabIndex = 26;
			this.label7.Text = "Capacity";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 13);
			this.label8.TabIndex = 27;
			this.label8.Text = "Damage";
			// 
			// _bfCheck
			// 
			this._bfCheck.AutoSize = true;
			this._bfCheck.Location = new System.Drawing.Point(6, 42);
			this._bfCheck.Name = "_bfCheck";
			this._bfCheck.Size = new System.Drawing.Size(70, 17);
			this._bfCheck.TabIndex = 30;
			this._bfCheck.Text = "Burst Fire";
			this._bfCheck.UseVisualStyleBackColor = true;
			this._bfCheck.CheckedChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// _saCheck
			// 
			this._saCheck.AutoSize = true;
			this._saCheck.Location = new System.Drawing.Point(95, 19);
			this._saCheck.Name = "_saCheck";
			this._saCheck.Size = new System.Drawing.Size(99, 17);
			this._saCheck.TabIndex = 31;
			this._saCheck.Text = "Semi-Automatic";
			this._saCheck.UseVisualStyleBackColor = true;
			this._saCheck.CheckedChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// _ssCheck
			// 
			this._ssCheck.AutoSize = true;
			this._ssCheck.Location = new System.Drawing.Point(6, 19);
			this._ssCheck.Name = "_ssCheck";
			this._ssCheck.Size = new System.Drawing.Size(80, 17);
			this._ssCheck.TabIndex = 32;
			this._ssCheck.Text = "Single Shot";
			this._ssCheck.UseVisualStyleBackColor = true;
			this._ssCheck.CheckedChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// _faCheck
			// 
			this._faCheck.AutoSize = true;
			this._faCheck.Location = new System.Drawing.Point(95, 42);
			this._faCheck.Name = "_faCheck";
			this._faCheck.Size = new System.Drawing.Size(67, 17);
			this._faCheck.TabIndex = 33;
			this._faCheck.Text = "Full Auto";
			this._faCheck.UseVisualStyleBackColor = true;
			this._faCheck.CheckedChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// _totalCost
			// 
			this._totalCost.Location = new System.Drawing.Point(220, 274);
			this._totalCost.Name = "_totalCost";
			this._totalCost.ReadOnly = true;
			this._totalCost.Size = new System.Drawing.Size(169, 20);
			this._totalCost.TabIndex = 34;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(217, 258);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 13);
			this.label10.TabIndex = 35;
			this.label10.Text = "Total Cost:";
			// 
			// _availability
			// 
			this._availability.Location = new System.Drawing.Point(93, 93);
			this._availability.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this._availability.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this._availability.Name = "_availability";
			this._availability.Size = new System.Drawing.Size(121, 20);
			this._availability.TabIndex = 36;
			this._availability.ValueChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._ssCheck);
			this.groupBox1.Controls.Add(this._saCheck);
			this.groupBox1.Controls.Add(this._bfCheck);
			this.groupBox1.Controls.Add(this._faCheck);
			this.groupBox1.Location = new System.Drawing.Point(12, 269);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 64);
			this.groupBox1.TabIndex = 37;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "R.O.F.";
			// 
			// _radius
			// 
			this._radius.Location = new System.Drawing.Point(93, 197);
			this._radius.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this._radius.Name = "_radius";
			this._radius.Size = new System.Drawing.Size(121, 20);
			this._radius.TabIndex = 20;
			this._radius.ValueChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// _picRails
			// 
			this._picRails.Location = new System.Drawing.Point(93, 223);
			this._picRails.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this._picRails.Name = "_picRails";
			this._picRails.Size = new System.Drawing.Size(121, 20);
			this._picRails.TabIndex = 38;
			this._picRails.ValueChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 197);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 24;
			this.label5.Text = "Radius";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 225);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 13);
			this.label9.TabIndex = 39;
			this.label9.Text = "ACC. Rails";
			// 
			// _superior
			// 
			this._superior.AutoSize = true;
			this._superior.Location = new System.Drawing.Point(12, 249);
			this._superior.Name = "_superior";
			this._superior.Size = new System.Drawing.Size(65, 17);
			this._superior.TabIndex = 34;
			this._superior.Text = "Superior";
			this._superior.UseVisualStyleBackColor = true;
			this._superior.CheckedChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// _lightweight
			// 
			this._lightweight.AutoSize = true;
			this._lightweight.Location = new System.Drawing.Point(93, 249);
			this._lightweight.Name = "_lightweight";
			this._lightweight.Size = new System.Drawing.Size(120, 17);
			this._lightweight.TabIndex = 34;
			this._lightweight.Text = "Lightweight Material";
			this._lightweight.UseVisualStyleBackColor = true;
			this._lightweight.CheckedChanged += new System.EventHandler(this.FormValueChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(217, 297);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 13);
			this.label11.TabIndex = 41;
			this.label11.Text = "Total Weight:";
			// 
			// _totalWeight
			// 
			this._totalWeight.Location = new System.Drawing.Point(220, 313);
			this._totalWeight.Name = "_totalWeight";
			this._totalWeight.ReadOnly = true;
			this._totalWeight.Size = new System.Drawing.Size(169, 20);
			this._totalWeight.TabIndex = 40;
			// 
			// HandheldWeapons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 365);
			this.Controls.Add(this.label11);
			this.Controls.Add(this._totalWeight);
			this.Controls.Add(this._lightweight);
			this.Controls.Add(this._superior);
			this.Controls.Add(this.label9);
			this.Controls.Add(this._picRails);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this._availability);
			this.Controls.Add(this.label10);
			this.Controls.Add(this._totalCost);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this._damage);
			this.Controls.Add(this._capacity);
			this.Controls.Add(this._range);
			this.Controls.Add(this._radius);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._condition);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._accesories);
			this.Controls.Add(this._damageType);
			this.Controls.Add(this._weaponType);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HandheldWeapons";
			this.Text = "HandheldWeapons";
			this.Load += new System.EventHandler(this.HandheldWeapons_Load);
			((System.ComponentModel.ISupportInitialize)(this._range)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._capacity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._damage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._availability)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._radius)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._picRails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _weaponType;
		private System.Windows.Forms.ComboBox _damageType;
		private System.Windows.Forms.CheckedListBox _accesories;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox _condition;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown _range;
		private System.Windows.Forms.NumericUpDown _capacity;
		private System.Windows.Forms.NumericUpDown _damage;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox _bfCheck;
		private System.Windows.Forms.CheckBox _saCheck;
		private System.Windows.Forms.CheckBox _ssCheck;
		private System.Windows.Forms.CheckBox _faCheck;
		private System.Windows.Forms.TextBox _totalCost;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown _availability;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown _radius;
		private System.Windows.Forms.NumericUpDown _picRails;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox _superior;
		private System.Windows.Forms.CheckBox _lightweight;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox _totalWeight;
	}
}