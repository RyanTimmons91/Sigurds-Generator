namespace StarSystemGeneratorV2.Forms.SpecialGens.ArmorControls
{
	partial class ArmorEquipmentSingleLevel
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._cost = new System.Windows.Forms.TextBox();
			this._weight = new System.Windows.Forms.TextBox();
			this._ItemDescription = new System.Windows.Forms.TextBox();
			this._isInstalled = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Cost:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Weight:";
			// 
			// _cost
			// 
			this._cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._cost.Location = new System.Drawing.Point(53, 175);
			this._cost.Name = "_cost";
			this._cost.ReadOnly = true;
			this._cost.Size = new System.Drawing.Size(100, 20);
			this._cost.TabIndex = 14;
			// 
			// _weight
			// 
			this._weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._weight.Location = new System.Drawing.Point(53, 149);
			this._weight.Name = "_weight";
			this._weight.ReadOnly = true;
			this._weight.Size = new System.Drawing.Size(100, 20);
			this._weight.TabIndex = 13;
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
			this._ItemDescription.Size = new System.Drawing.Size(406, 140);
			this._ItemDescription.TabIndex = 9;
			this._ItemDescription.Text = "_description";
			// 
			// _isInstalled
			// 
			this._isInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._isInstalled.AutoSize = true;
			this._isInstalled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._isInstalled.Location = new System.Drawing.Point(3, 201);
			this._isInstalled.Name = "_isInstalled";
			this._isInstalled.Size = new System.Drawing.Size(65, 17);
			this._isInstalled.TabIndex = 17;
			this._isInstalled.Text = "Installed";
			this._isInstalled.UseVisualStyleBackColor = true;
			// 
			// ArmorEquipmentSingleLevel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._isInstalled);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._cost);
			this.Controls.Add(this._weight);
			this.Controls.Add(this._ItemDescription);
			this.Name = "ArmorEquipmentSingleLevel";
			this.Size = new System.Drawing.Size(412, 227);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox _cost;
		internal System.Windows.Forms.TextBox _weight;
		internal System.Windows.Forms.TextBox _ItemDescription;
		internal System.Windows.Forms.CheckBox _isInstalled;
	}
}
