namespace StarSystemGeneratorV2.Forms.SpecialGens
{
	partial class NPCEncounterGen
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label3 = new System.Windows.Forms.Label();
			this._enemyCount = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this._npcLvlSpread = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this._avgPlayer = new System.Windows.Forms.NumericUpDown();
			this._singleLevel = new System.Windows.Forms.CheckBox();
			this._singleRace = new System.Windows.Forms.CheckBox();
			this._randomAll = new System.Windows.Forms.Button();
			this._npcGrid = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._enemyCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._npcLvlSpread)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._avgPlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._npcGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this._enemyCount);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this._npcLvlSpread);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this._avgPlayer);
			this.splitContainer1.Panel1.Controls.Add(this._singleLevel);
			this.splitContainer1.Panel1.Controls.Add(this._singleRace);
			this.splitContainer1.Panel1.Controls.Add(this._randomAll);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this._npcGrid);
			this.splitContainer1.Size = new System.Drawing.Size(857, 295);
			this.splitContainer1.SplitterDistance = 226;
			this.splitContainer1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Enemy Count";
			// 
			// _enemyCount
			// 
			this._enemyCount.Location = new System.Drawing.Point(96, 46);
			this._enemyCount.Name = "_enemyCount";
			this._enemyCount.Size = new System.Drawing.Size(120, 20);
			this._enemyCount.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Lvl.Variation";
			// 
			// _npcLvlSpread
			// 
			this._npcLvlSpread.Location = new System.Drawing.Point(96, 98);
			this._npcLvlSpread.Name = "_npcLvlSpread";
			this._npcLvlSpread.Size = new System.Drawing.Size(120, 20);
			this._npcLvlSpread.TabIndex = 5;
			this._npcLvlSpread.ValueChanged += new System.EventHandler(this._npcLvlSpread_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Avg.Player Lvl.";
			// 
			// _avgPlayer
			// 
			this._avgPlayer.Location = new System.Drawing.Point(96, 72);
			this._avgPlayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this._avgPlayer.Name = "_avgPlayer";
			this._avgPlayer.Size = new System.Drawing.Size(120, 20);
			this._avgPlayer.TabIndex = 3;
			this._avgPlayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this._avgPlayer.ValueChanged += new System.EventHandler(this._avgPlayer_ValueChanged);
			// 
			// _singleLevel
			// 
			this._singleLevel.AutoSize = true;
			this._singleLevel.Location = new System.Drawing.Point(132, 147);
			this._singleLevel.Name = "_singleLevel";
			this._singleLevel.Size = new System.Drawing.Size(84, 17);
			this._singleLevel.TabIndex = 2;
			this._singleLevel.Text = "Single Level";
			this._singleLevel.UseVisualStyleBackColor = true;
			// 
			// _singleRace
			// 
			this._singleRace.AutoSize = true;
			this._singleRace.Location = new System.Drawing.Point(132, 124);
			this._singleRace.Name = "_singleRace";
			this._singleRace.Size = new System.Drawing.Size(84, 17);
			this._singleRace.TabIndex = 1;
			this._singleRace.Text = "Single Race";
			this._singleRace.UseVisualStyleBackColor = true;
			// 
			// _randomAll
			// 
			this._randomAll.Location = new System.Drawing.Point(12, 12);
			this._randomAll.Name = "_randomAll";
			this._randomAll.Size = new System.Drawing.Size(107, 23);
			this._randomAll.TabIndex = 0;
			this._randomAll.Text = "Randomize All";
			this._randomAll.UseVisualStyleBackColor = true;
			this._randomAll.Click += new System.EventHandler(this._randomAll_Click);
			// 
			// _npcGrid
			// 
			this._npcGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._npcGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column7});
			this._npcGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this._npcGrid.Location = new System.Drawing.Point(0, 0);
			this._npcGrid.Name = "_npcGrid";
			this._npcGrid.Size = new System.Drawing.Size(627, 295);
			this._npcGrid.TabIndex = 0;
			this._npcGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this._npcGrid_CellValueChanged);
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "Race";
			this.Column1.Items.AddRange(new object[] {
            "Human",
            "Dwuervan",
            "Elharnian",
            "Halfarn",
            "Ngorm",
            "Orlanc",
            "Yettin"});
			this.Column1.Name = "Column1";
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText = "Lvl";
			this.Column6.Name = "Column6";
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "Weapon";
			this.Column3.Items.AddRange(new object[] {
            "Assault Rifle",
            "Axe",
            "Knife",
            "Machine Gun",
            "Pistol",
            "Shotgun",
            "SMG",
            "Sniper Rifle",
            "Sword"});
			this.Column3.Name = "Column3";
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "HP";
			this.Column2.Name = "Column2";
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "Atk.Bonus";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "Def.Bonus";
			this.Column5.Name = "Column5";
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle1.NullValue = "0";
			this.Column8.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column8.HeaderText = "DMG.Taken";
			this.Column8.Name = "Column8";
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.HeaderText = "Curr.HP";
			this.Column7.Name = "Column7";
			// 
			// NPCEncounterGen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 295);
			this.Controls.Add(this.splitContainer1);
			this.Name = "NPCEncounterGen";
			this.Text = "NPCEncounterGen";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._enemyCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._npcLvlSpread)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._avgPlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._npcGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView _npcGrid;
		private System.Windows.Forms.Button _randomAll;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown _npcLvlSpread;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown _avgPlayer;
		private System.Windows.Forms.CheckBox _singleLevel;
		private System.Windows.Forms.CheckBox _singleRace;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown _enemyCount;
		private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
	}
}