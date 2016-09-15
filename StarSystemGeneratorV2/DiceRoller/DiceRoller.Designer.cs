namespace StarSystemGeneratorV2
{
	partial class DiceRollerForm
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
			this._rollD4 = new System.Windows.Forms.Button();
			this._rollD12 = new System.Windows.Forms.Button();
			this._rollD10 = new System.Windows.Forms.Button();
			this._rollD8 = new System.Windows.Forms.Button();
			this._rollD6 = new System.Windows.Forms.Button();
			this._rollD3 = new System.Windows.Forms.Button();
			this._rollDpercent = new System.Windows.Forms.Button();
			this._rollD20 = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this._addCustomRoles = new System.Windows.Forms.ToolStripMenuItem();
			this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this._outputTextbox = new System.Windows.Forms.TextBox();
			this._CustomDice = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// _rollD4
			// 
			this._rollD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rollD4.Location = new System.Drawing.Point(63, 27);
			this._rollD4.Name = "_rollD4";
			this._rollD4.Size = new System.Drawing.Size(55, 44);
			this._rollD4.TabIndex = 1;
			this._rollD4.Text = "D4";
			this._rollD4.UseVisualStyleBackColor = true;
			this._rollD4.Click += new System.EventHandler(this._rollD4_Click);
			// 
			// _rollD12
			// 
			this._rollD12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rollD12.Location = new System.Drawing.Point(307, 27);
			this._rollD12.Name = "_rollD12";
			this._rollD12.Size = new System.Drawing.Size(55, 44);
			this._rollD12.TabIndex = 2;
			this._rollD12.Text = "D12";
			this._rollD12.UseVisualStyleBackColor = true;
			this._rollD12.Click += new System.EventHandler(this._rollD12_Click);
			// 
			// _rollD10
			// 
			this._rollD10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rollD10.Location = new System.Drawing.Point(246, 27);
			this._rollD10.Name = "_rollD10";
			this._rollD10.Size = new System.Drawing.Size(55, 44);
			this._rollD10.TabIndex = 3;
			this._rollD10.Text = "D10";
			this._rollD10.UseVisualStyleBackColor = true;
			this._rollD10.Click += new System.EventHandler(this._rollD10_Click);
			// 
			// _rollD8
			// 
			this._rollD8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rollD8.Location = new System.Drawing.Point(185, 27);
			this._rollD8.Name = "_rollD8";
			this._rollD8.Size = new System.Drawing.Size(55, 44);
			this._rollD8.TabIndex = 4;
			this._rollD8.Text = "D8";
			this._rollD8.UseVisualStyleBackColor = true;
			this._rollD8.Click += new System.EventHandler(this._rollD8_Click);
			// 
			// _rollD6
			// 
			this._rollD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rollD6.Location = new System.Drawing.Point(124, 27);
			this._rollD6.Name = "_rollD6";
			this._rollD6.Size = new System.Drawing.Size(55, 44);
			this._rollD6.TabIndex = 5;
			this._rollD6.Text = "D6";
			this._rollD6.UseVisualStyleBackColor = true;
			this._rollD6.Click += new System.EventHandler(this._rollD6_Click);
			// 
			// _rollD3
			// 
			this._rollD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rollD3.Location = new System.Drawing.Point(3, 27);
			this._rollD3.Name = "_rollD3";
			this._rollD3.Size = new System.Drawing.Size(55, 44);
			this._rollD3.TabIndex = 6;
			this._rollD3.Text = "D3";
			this._rollD3.UseVisualStyleBackColor = true;
			this._rollD3.Click += new System.EventHandler(this._rollD3_Click);
			// 
			// _rollDpercent
			// 
			this._rollDpercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rollDpercent.Location = new System.Drawing.Point(429, 27);
			this._rollDpercent.Name = "_rollDpercent";
			this._rollDpercent.Size = new System.Drawing.Size(55, 44);
			this._rollDpercent.TabIndex = 7;
			this._rollDpercent.Text = "D%";
			this._rollDpercent.UseVisualStyleBackColor = true;
			this._rollDpercent.Click += new System.EventHandler(this._rollDpercent_Click);
			// 
			// _rollD20
			// 
			this._rollD20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rollD20.Location = new System.Drawing.Point(368, 27);
			this._rollD20.Name = "_rollD20";
			this._rollD20.Size = new System.Drawing.Size(55, 44);
			this._rollD20.TabIndex = 8;
			this._rollD20.Text = "D20";
			this._rollD20.UseVisualStyleBackColor = true;
			this._rollD20.Click += new System.EventHandler(this._rollD20_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this._rollDpercent);
			this.splitContainer1.Panel1.Controls.Add(this._rollD20);
			this.splitContainer1.Panel1.Controls.Add(this._rollD12);
			this.splitContainer1.Panel1.Controls.Add(this._rollD10);
			this.splitContainer1.Panel1.Controls.Add(this._rollD8);
			this.splitContainer1.Panel1.Controls.Add(this._rollD6);
			this.splitContainer1.Panel1.Controls.Add(this._rollD4);
			this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
			this.splitContainer1.Panel1.Controls.Add(this._rollD3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(492, 316);
			this.splitContainer1.SplitterDistance = 74;
			this.splitContainer1.TabIndex = 9;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addCustomRoles,
            this.clearOutputToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(492, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// _addCustomRoles
			// 
			this._addCustomRoles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
			this._addCustomRoles.Name = "_addCustomRoles";
			this._addCustomRoles.Size = new System.Drawing.Size(86, 20);
			this._addCustomRoles.Text = "Add Custom";
			// 
			// createToolStripMenuItem
			// 
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.createToolStripMenuItem.Text = "Create";
			this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
			// 
			// clearOutputToolStripMenuItem
			// 
			this.clearOutputToolStripMenuItem.Name = "clearOutputToolStripMenuItem";
			this.clearOutputToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.clearOutputToolStripMenuItem.Text = "Clear Output";
			this.clearOutputToolStripMenuItem.Click += new System.EventHandler(this.clearOutputToolStripMenuItem_Click);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this._outputTextbox);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.AutoScroll = true;
			this.splitContainer2.Panel2.Controls.Add(this._CustomDice);
			this.splitContainer2.Size = new System.Drawing.Size(492, 238);
			this.splitContainer2.SplitterDistance = 150;
			this.splitContainer2.TabIndex = 0;
			// 
			// _outputTextbox
			// 
			this._outputTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._outputTextbox.Location = new System.Drawing.Point(0, 0);
			this._outputTextbox.Multiline = true;
			this._outputTextbox.Name = "_outputTextbox";
			this._outputTextbox.ReadOnly = true;
			this._outputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._outputTextbox.Size = new System.Drawing.Size(492, 150);
			this._outputTextbox.TabIndex = 0;
			// 
			// _CustomDice
			// 
			this._CustomDice.AutoScroll = true;
			this._CustomDice.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CustomDice.Location = new System.Drawing.Point(0, 0);
			this._CustomDice.Name = "_CustomDice";
			this._CustomDice.Size = new System.Drawing.Size(492, 84);
			this._CustomDice.TabIndex = 0;
			// 
			// DiceRollerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 316);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(503, 330);
			this.Name = "DiceRollerForm";
			this.Text = "DiceRollerForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiceRollerForm_FormClosing);
			this.Load += new System.EventHandler(this.DiceRollerForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _rollD4;
		private System.Windows.Forms.Button _rollD12;
		private System.Windows.Forms.Button _rollD10;
		private System.Windows.Forms.Button _rollD8;
		private System.Windows.Forms.Button _rollD6;
		private System.Windows.Forms.Button _rollD3;
		private System.Windows.Forms.Button _rollDpercent;
		private System.Windows.Forms.Button _rollD20;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.FlowLayoutPanel _CustomDice;
		private System.Windows.Forms.ToolStripMenuItem _addCustomRoles;
		private System.Windows.Forms.ToolStripMenuItem clearOutputToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
		internal System.Windows.Forms.TextBox _outputTextbox;
	}
}