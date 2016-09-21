namespace StarSystemGeneratorV2
{
	partial class SystemGeneratorForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemGeneratorForm));
			this._GenerateButton = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this._systemTreeView = new System.Windows.Forms.TreeView();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this._globalSystemNumber = new System.Windows.Forms.TextBox();
			this._dynamicPanel = new System.Windows.Forms.Panel();
			this._seedBox = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._diceRoller = new System.Windows.Forms.ToolStripMenuItem();
			this.specialGeneratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.armorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.handheldWeaponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mechaWeightCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.missileLaunchersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nPCEncountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resourceCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.weaponCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._0SystemNumber = new System.Windows.Forms.Button();
			this._versionGen = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this._highlightComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._seedBox)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._versionGen)).BeginInit();
			this.SuspendLayout();
			// 
			// _GenerateButton
			// 
			this._GenerateButton.Location = new System.Drawing.Point(12, 27);
			this._GenerateButton.Name = "_GenerateButton";
			this._GenerateButton.Size = new System.Drawing.Size(100, 23);
			this._GenerateButton.TabIndex = 0;
			this._GenerateButton.Text = "Generate System";
			this._GenerateButton.UseVisualStyleBackColor = true;
			this._GenerateButton.Click += new System.EventHandler(this._GenerateButton_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 56);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this._systemTreeView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(509, 377);
			this.splitContainer1.SplitterDistance = 199;
			this.splitContainer1.TabIndex = 3;
			// 
			// _systemTreeView
			// 
			this._systemTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._systemTreeView.Location = new System.Drawing.Point(0, 0);
			this._systemTreeView.Name = "_systemTreeView";
			this._systemTreeView.Size = new System.Drawing.Size(199, 377);
			this._systemTreeView.TabIndex = 0;
			this._systemTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._systemTreeView_AfterSelect);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label1);
			this.splitContainer2.Panel1.Controls.Add(this._globalSystemNumber);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this._dynamicPanel);
			this.splitContainer2.Size = new System.Drawing.Size(306, 377);
			this.splitContainer2.SplitterDistance = 58;
			this.splitContainer2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "System Number:";
			// 
			// _globalSystemNumber
			// 
			this._globalSystemNumber.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._globalSystemNumber.Location = new System.Drawing.Point(109, 3);
			this._globalSystemNumber.Name = "_globalSystemNumber";
			this._globalSystemNumber.ReadOnly = true;
			this._globalSystemNumber.Size = new System.Drawing.Size(194, 51);
			this._globalSystemNumber.TabIndex = 0;
			// 
			// _dynamicPanel
			// 
			this._dynamicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._dynamicPanel.Location = new System.Drawing.Point(0, 0);
			this._dynamicPanel.Name = "_dynamicPanel";
			this._dynamicPanel.Size = new System.Drawing.Size(306, 315);
			this._dynamicPanel.TabIndex = 0;
			// 
			// _seedBox
			// 
			this._seedBox.Location = new System.Drawing.Point(118, 30);
			this._seedBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this._seedBox.Name = "_seedBox";
			this._seedBox.Size = new System.Drawing.Size(120, 20);
			this._seedBox.TabIndex = 4;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.clearToolStripMenuItem,
            this._diceRoller,
            this.specialGeneratorsToolStripMenuItem,
            this.logToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(533, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.infoToolStripMenuItem.Text = "Change Log";
			this.infoToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// _diceRoller
			// 
			this._diceRoller.Name = "_diceRoller";
			this._diceRoller.Size = new System.Drawing.Size(75, 20);
			this._diceRoller.Text = "Dice Roller";
			this._diceRoller.Click += new System.EventHandler(this._diceRoller_Click);
			// 
			// specialGeneratorsToolStripMenuItem
			// 
			this.specialGeneratorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.armorToolStripMenuItem,
            this.handheldWeaponsToolStripMenuItem,
            this.mechaWeightCostToolStripMenuItem,
            this.missileLaunchersToolStripMenuItem,
            this.nPCEncountersToolStripMenuItem,
            this.resourceCostToolStripMenuItem,
            this.shipsToolStripMenuItem,
            this.weaponCostToolStripMenuItem});
			this.specialGeneratorsToolStripMenuItem.Name = "specialGeneratorsToolStripMenuItem";
			this.specialGeneratorsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
			this.specialGeneratorsToolStripMenuItem.Text = "Special Generators";
			// 
			// armorToolStripMenuItem
			// 
			this.armorToolStripMenuItem.Name = "armorToolStripMenuItem";
			this.armorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.armorToolStripMenuItem.Text = "Armor";
			this.armorToolStripMenuItem.Click += new System.EventHandler(this.armorToolStripMenuItem_Click);
			// 
			// handheldWeaponsToolStripMenuItem
			// 
			this.handheldWeaponsToolStripMenuItem.Name = "handheldWeaponsToolStripMenuItem";
			this.handheldWeaponsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.handheldWeaponsToolStripMenuItem.Text = "Handheld Weapons";
			this.handheldWeaponsToolStripMenuItem.Click += new System.EventHandler(this.handheldWeaponsToolStripMenuItem_Click);
			// 
			// mechaWeightCostToolStripMenuItem
			// 
			this.mechaWeightCostToolStripMenuItem.Name = "mechaWeightCostToolStripMenuItem";
			this.mechaWeightCostToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.mechaWeightCostToolStripMenuItem.Text = "Mecha Weight Cost";
			this.mechaWeightCostToolStripMenuItem.Click += new System.EventHandler(this.mechaWeightCostToolStripMenuItem_Click);
			// 
			// missileLaunchersToolStripMenuItem
			// 
			this.missileLaunchersToolStripMenuItem.Name = "missileLaunchersToolStripMenuItem";
			this.missileLaunchersToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.missileLaunchersToolStripMenuItem.Text = "Missile Launchers";
			this.missileLaunchersToolStripMenuItem.Click += new System.EventHandler(this.missileLaunchersToolStripMenuItem_Click);
			// 
			// nPCEncountersToolStripMenuItem
			// 
			this.nPCEncountersToolStripMenuItem.Name = "nPCEncountersToolStripMenuItem";
			this.nPCEncountersToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.nPCEncountersToolStripMenuItem.Text = "NPC Encounters";
			this.nPCEncountersToolStripMenuItem.Click += new System.EventHandler(this.nPCEncountersToolStripMenuItem_Click);
			// 
			// resourceCostToolStripMenuItem
			// 
			this.resourceCostToolStripMenuItem.Name = "resourceCostToolStripMenuItem";
			this.resourceCostToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.resourceCostToolStripMenuItem.Text = "Resource Cost";
			this.resourceCostToolStripMenuItem.Click += new System.EventHandler(this.resourceCostToolStripMenuItem_Click);
			// 
			// shipsToolStripMenuItem
			// 
			this.shipsToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
			this.shipsToolStripMenuItem.Name = "shipsToolStripMenuItem";
			this.shipsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.shipsToolStripMenuItem.Text = "(NYI) Ships";
			this.shipsToolStripMenuItem.Click += new System.EventHandler(this.shipsToolStripMenuItem_Click);
			// 
			// weaponCostToolStripMenuItem
			// 
			this.weaponCostToolStripMenuItem.Name = "weaponCostToolStripMenuItem";
			this.weaponCostToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.weaponCostToolStripMenuItem.Text = "Vehicle Weapon Cost";
			this.weaponCostToolStripMenuItem.Click += new System.EventHandler(this.weaponCostToolStripMenuItem_Click);
			// 
			// logToolStripMenuItem
			// 
			this.logToolStripMenuItem.Name = "logToolStripMenuItem";
			this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.logToolStripMenuItem.Text = "Log";
			this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
			// 
			// _0SystemNumber
			// 
			this._0SystemNumber.Location = new System.Drawing.Point(305, 27);
			this._0SystemNumber.Name = "_0SystemNumber";
			this._0SystemNumber.Size = new System.Drawing.Size(22, 23);
			this._0SystemNumber.TabIndex = 8;
			this._0SystemNumber.Text = "0";
			this._0SystemNumber.UseVisualStyleBackColor = true;
			this._0SystemNumber.Click += new System.EventHandler(this._0SystemNumber_Click);
			// 
			// _versionGen
			// 
			this._versionGen.Location = new System.Drawing.Point(263, 30);
			this._versionGen.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this._versionGen.Name = "_versionGen";
			this._versionGen.Size = new System.Drawing.Size(36, 20);
			this._versionGen.TabIndex = 10;
			this._versionGen.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(244, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "--";
			// 
			// _highlightComboBox
			// 
			this._highlightComboBox.FormattingEnabled = true;
			this._highlightComboBox.Items.AddRange(new object[] {
            "None",
            "Ready for Colonization",
            "Lost Civilizations"});
			this._highlightComboBox.Location = new System.Drawing.Point(400, 29);
			this._highlightComboBox.Name = "_highlightComboBox";
			this._highlightComboBox.Size = new System.Drawing.Size(121, 21);
			this._highlightComboBox.TabIndex = 12;
			this._highlightComboBox.Text = "FEATURE NYI";
			this._highlightComboBox.SelectedIndexChanged += new System.EventHandler(this._highlightComboBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(343, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Highlight:";
			// 
			// SystemGeneratorForm
			// 
			this.AcceptButton = this._GenerateButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 445);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._highlightComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._versionGen);
			this.Controls.Add(this._0SystemNumber);
			this.Controls.Add(this._seedBox);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this._GenerateButton);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SystemGeneratorForm";
			this.Text = "Sigurds Universe Generator System";
			this.Load += new System.EventHandler(this.SystemGeneratorForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._seedBox)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._versionGen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _GenerateButton;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView _systemTreeView;
		private System.Windows.Forms.NumericUpDown _seedBox;
		private System.Windows.Forms.Panel _dynamicPanel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.Button _0SystemNumber;
		private System.Windows.Forms.ToolStripMenuItem _diceRoller;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _globalSystemNumber;
		private System.Windows.Forms.ToolStripMenuItem specialGeneratorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem weaponCostToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resourceCostToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mechaWeightCostToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem handheldWeaponsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem armorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem missileLaunchersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nPCEncountersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shipsToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown _versionGen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox _highlightComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
	}
}

