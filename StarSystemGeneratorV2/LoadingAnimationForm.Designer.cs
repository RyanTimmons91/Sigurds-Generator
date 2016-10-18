namespace StarSystemGeneratorV2
{
	partial class LoadingAnimationForm
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
            this.components = new System.ComponentModel.Container();
            this._animationTimer = new System.Windows.Forms.Timer(this.components);
            this._loadingLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _animationTimer
            // 
            this._animationTimer.Enabled = true;
            this._animationTimer.Interval = 16;
            this._animationTimer.Tick += new System.EventHandler(this._animationTimer_Tick);
            // 
            // _loadingLabel
            // 
            this._loadingLabel.AutoSize = true;
            this._loadingLabel.ForeColor = System.Drawing.Color.White;
            this._loadingLabel.Location = new System.Drawing.Point(12, 9);
            this._loadingLabel.Name = "_loadingLabel";
            this._loadingLabel.Size = new System.Drawing.Size(118, 13);
            this._loadingLabel.TabIndex = 0;
            this._loadingLabel.Text = "Loading Animation Test";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadingAnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(601, 601);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this._loadingLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingAnimationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingAnimationForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoadingAnimationForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer _animationTimer;
		private System.Windows.Forms.Label _loadingLabel;
		private System.Windows.Forms.Button button1;
	}
}