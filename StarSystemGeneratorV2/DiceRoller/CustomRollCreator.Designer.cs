namespace StarSystemGeneratorV2.DiceRoller
{
	partial class CustomRollCreator
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
			this.label1 = new System.Windows.Forms.Label();
			this._rollName = new System.Windows.Forms.TextBox();
			this._rollFormula = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._test = new System.Windows.Forms.Button();
			this._testOutput = new System.Windows.Forms.TextBox();
			this._save = new System.Windows.Forms.Button();
			this._cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Roll Name:";
			// 
			// _rollName
			// 
			this._rollName.Location = new System.Drawing.Point(77, 12);
			this._rollName.Name = "_rollName";
			this._rollName.Size = new System.Drawing.Size(195, 20);
			this._rollName.TabIndex = 1;
			// 
			// _rollFormula
			// 
			this._rollFormula.Location = new System.Drawing.Point(77, 38);
			this._rollFormula.Multiline = true;
			this._rollFormula.Name = "_rollFormula";
			this._rollFormula.Size = new System.Drawing.Size(195, 137);
			this._rollFormula.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Formula:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Test:";
			// 
			// _test
			// 
			this._test.Location = new System.Drawing.Point(77, 181);
			this._test.Name = "_test";
			this._test.Size = new System.Drawing.Size(52, 23);
			this._test.TabIndex = 5;
			this._test.Text = "Test";
			this._test.UseVisualStyleBackColor = true;
			this._test.Click += new System.EventHandler(this._test_Click);
			// 
			// _testOutput
			// 
			this._testOutput.Location = new System.Drawing.Point(135, 183);
			this._testOutput.Name = "_testOutput";
			this._testOutput.ReadOnly = true;
			this._testOutput.Size = new System.Drawing.Size(137, 20);
			this._testOutput.TabIndex = 6;
			this._testOutput.Text = "Test Results";
			// 
			// _save
			// 
			this._save.Location = new System.Drawing.Point(197, 226);
			this._save.Name = "_save";
			this._save.Size = new System.Drawing.Size(75, 23);
			this._save.TabIndex = 7;
			this._save.Text = "Save";
			this._save.UseVisualStyleBackColor = true;
			this._save.Click += new System.EventHandler(this._save_Click);
			// 
			// _cancel
			// 
			this._cancel.Location = new System.Drawing.Point(12, 226);
			this._cancel.Name = "_cancel";
			this._cancel.Size = new System.Drawing.Size(75, 23);
			this._cancel.TabIndex = 8;
			this._cancel.Text = "Cancel";
			this._cancel.UseVisualStyleBackColor = true;
			this._cancel.Click += new System.EventHandler(this._cancel_Click);
			// 
			// CustomRollCreator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._save);
			this.Controls.Add(this._testOutput);
			this.Controls.Add(this._test);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._rollFormula);
			this.Controls.Add(this._rollName);
			this.Controls.Add(this.label1);
			this.Name = "CustomRollCreator";
			this.Text = "CustomRollCreator";
			this.Load += new System.EventHandler(this.CustomRollCreator_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _rollName;
		private System.Windows.Forms.TextBox _rollFormula;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _test;
		private System.Windows.Forms.TextBox _testOutput;
		private System.Windows.Forms.Button _save;
		private System.Windows.Forms.Button _cancel;
	}
}