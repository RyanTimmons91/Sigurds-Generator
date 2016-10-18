namespace StarSystemGeneratorV2.Forms
{
	partial class WeaponCost
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponCost));
			this._semiAuto = new System.Windows.Forms.CheckBox();
			this._burstFire = new System.Windows.Forms.CheckBox();
			this._fullAuto = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._capacity = new System.Windows.Forms.NumericUpDown();
			this._radius = new System.Windows.Forms.NumericUpDown();
			this._damage = new System.Windows.Forms.NumericUpDown();
			this._range = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this._weaponValue = new System.Windows.Forms.TextBox();
			this._close = new System.Windows.Forms.Button();
			this._weight = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this._gravRadio = new System.Windows.Forms.RadioButton();
			this._caselessRadio = new System.Windows.Forms.RadioButton();
			this._ballisticRadio = new System.Windows.Forms.RadioButton();
			this._energyRadio = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._capacity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._radius)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._damage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._range)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// _semiAuto
			// 
			this._semiAuto.AutoSize = true;
			this._semiAuto.Location = new System.Drawing.Point(6, 19);
			this._semiAuto.Name = "_semiAuto";
			this._semiAuto.Size = new System.Drawing.Size(98, 17);
			this._semiAuto.TabIndex = 0;
			this._semiAuto.Text = "Semi-automatic";
			this._semiAuto.UseVisualStyleBackColor = true;
			this._semiAuto.CheckedChanged += new System.EventHandler(this.ValueChanged);
			// 
			// _burstFire
			// 
			this._burstFire.AutoSize = true;
			this._burstFire.Location = new System.Drawing.Point(6, 42);
			this._burstFire.Name = "_burstFire";
			this._burstFire.Size = new System.Drawing.Size(70, 17);
			this._burstFire.TabIndex = 1;
			this._burstFire.Text = "Burst Fire";
			this._burstFire.UseVisualStyleBackColor = true;
			this._burstFire.CheckedChanged += new System.EventHandler(this.ValueChanged);
			// 
			// _fullAuto
			// 
			this._fullAuto.AutoSize = true;
			this._fullAuto.Location = new System.Drawing.Point(6, 65);
			this._fullAuto.Name = "_fullAuto";
			this._fullAuto.Size = new System.Drawing.Size(92, 17);
			this._fullAuto.TabIndex = 2;
			this._fullAuto.Text = "Full Automatic";
			this._fullAuto.UseVisualStyleBackColor = true;
			this._fullAuto.CheckedChanged += new System.EventHandler(this.ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._semiAuto);
			this.groupBox1.Controls.Add(this._fullAuto);
			this.groupBox1.Controls.Add(this._burstFire);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(163, 112);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Selective Fire";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this._capacity);
			this.groupBox2.Controls.Add(this._radius);
			this.groupBox2.Controls.Add(this._damage);
			this.groupBox2.Controls.Add(this._range);
			this.groupBox2.Location = new System.Drawing.Point(12, 130);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(163, 139);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Weapon Details";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Radius";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Damage";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Capacity";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Range";
			// 
			// _capacity
			// 
			this._capacity.Location = new System.Drawing.Point(60, 97);
			this._capacity.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
			this._capacity.Name = "_capacity";
			this._capacity.Size = new System.Drawing.Size(89, 20);
			this._capacity.TabIndex = 3;
			this._capacity.ValueChanged += new System.EventHandler(this.ValueChanged);
			// 
			// _radius
			// 
			this._radius.Location = new System.Drawing.Point(60, 45);
			this._radius.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
			this._radius.Name = "_radius";
			this._radius.Size = new System.Drawing.Size(89, 20);
			this._radius.TabIndex = 1;
			this._radius.ValueChanged += new System.EventHandler(this.ValueChanged);
			// 
			// _damage
			// 
			this._damage.Location = new System.Drawing.Point(60, 71);
			this._damage.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
			this._damage.Name = "_damage";
			this._damage.Size = new System.Drawing.Size(89, 20);
			this._damage.TabIndex = 2;
			this._damage.ValueChanged += new System.EventHandler(this.ValueChanged);
			// 
			// _range
			// 
			this._range.Location = new System.Drawing.Point(60, 19);
			this._range.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
			this._range.Name = "_range";
			this._range.Size = new System.Drawing.Size(89, 20);
			this._range.TabIndex = 0;
			this._range.ValueChanged += new System.EventHandler(this.ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(181, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Weapon Value:";
			// 
			// _weaponValue
			// 
			this._weaponValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._weaponValue.Location = new System.Drawing.Point(181, 203);
			this._weaponValue.Name = "_weaponValue";
			this._weaponValue.ReadOnly = true;
			this._weaponValue.Size = new System.Drawing.Size(147, 26);
			this._weaponValue.TabIndex = 2;
			// 
			// _close
			// 
			this._close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._close.Location = new System.Drawing.Point(253, 246);
			this._close.Name = "_close";
			this._close.Size = new System.Drawing.Size(75, 23);
			this._close.TabIndex = 7;
			this._close.Text = "Close";
			this._close.UseVisualStyleBackColor = true;
			this._close.Click += new System.EventHandler(this._close_Click);
			// 
			// _weight
			// 
			this._weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._weight.Location = new System.Drawing.Point(181, 158);
			this._weight.Name = "_weight";
			this._weight.ReadOnly = true;
			this._weight.Size = new System.Drawing.Size(147, 26);
			this._weight.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(181, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Weapon Weight:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this._gravRadio);
			this.groupBox3.Controls.Add(this._caselessRadio);
			this.groupBox3.Controls.Add(this._ballisticRadio);
			this.groupBox3.Controls.Add(this._energyRadio);
			this.groupBox3.Location = new System.Drawing.Point(181, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(147, 112);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// _gravRadio
			// 
			this._gravRadio.AutoSize = true;
			this._gravRadio.Location = new System.Drawing.Point(6, 65);
			this._gravRadio.Name = "_gravRadio";
			this._gravRadio.Size = new System.Drawing.Size(118, 17);
			this._gravRadio.TabIndex = 3;
			this._gravRadio.TabStop = true;
			this._gravRadio.Text = "Grav/Mag Weapon";
			this._gravRadio.UseVisualStyleBackColor = true;
			this._gravRadio.CheckedChanged += new System.EventHandler(this._damageType_SelectedIndexChanged);
			// 
			// _caselessRadio
			// 
			this._caselessRadio.AutoSize = true;
			this._caselessRadio.Location = new System.Drawing.Point(6, 88);
			this._caselessRadio.Name = "_caselessRadio";
			this._caselessRadio.Size = new System.Drawing.Size(111, 17);
			this._caselessRadio.TabIndex = 2;
			this._caselessRadio.TabStop = true;
			this._caselessRadio.Text = "Caseless Weapon";
			this._caselessRadio.UseVisualStyleBackColor = true;
			this._caselessRadio.CheckedChanged += new System.EventHandler(this._damageType_SelectedIndexChanged);
			// 
			// _ballisticRadio
			// 
			this._ballisticRadio.AutoSize = true;
			this._ballisticRadio.Location = new System.Drawing.Point(6, 42);
			this._ballisticRadio.Name = "_ballisticRadio";
			this._ballisticRadio.Size = new System.Drawing.Size(104, 17);
			this._ballisticRadio.TabIndex = 1;
			this._ballisticRadio.TabStop = true;
			this._ballisticRadio.Text = "Ballistic Weapon";
			this._ballisticRadio.UseVisualStyleBackColor = true;
			this._ballisticRadio.CheckedChanged += new System.EventHandler(this._damageType_SelectedIndexChanged);
			// 
			// _energyRadio
			// 
			this._energyRadio.AutoSize = true;
			this._energyRadio.Location = new System.Drawing.Point(6, 19);
			this._energyRadio.Name = "_energyRadio";
			this._energyRadio.Size = new System.Drawing.Size(102, 17);
			this._energyRadio.TabIndex = 0;
			this._energyRadio.TabStop = true;
			this._energyRadio.Text = "Energy Weapon";
			this._energyRadio.UseVisualStyleBackColor = true;
			this._energyRadio.CheckedChanged += new System.EventHandler(this._damageType_SelectedIndexChanged);
			// 
			// WeaponCost
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._close;
			this.ClientSize = new System.Drawing.Size(340, 281);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this._weight);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._close);
			this.Controls.Add(this._weaponValue);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WeaponCost";
			this.Text = "VehicleWeapon";
			this.Load += new System.EventHandler(this.WeaponCost_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._capacity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._radius)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._damage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._range)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox _semiAuto;
		private System.Windows.Forms.CheckBox _burstFire;
		private System.Windows.Forms.CheckBox _fullAuto;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown _capacity;
		private System.Windows.Forms.NumericUpDown _radius;
		private System.Windows.Forms.NumericUpDown _damage;
		private System.Windows.Forms.NumericUpDown _range;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox _weaponValue;
		private System.Windows.Forms.Button _close;
		private System.Windows.Forms.TextBox _weight;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton _gravRadio;
		private System.Windows.Forms.RadioButton _caselessRadio;
		private System.Windows.Forms.RadioButton _ballisticRadio;
		private System.Windows.Forms.RadioButton _energyRadio;
	}
}