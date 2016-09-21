using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarSystemGeneratorV2
{
	public partial class LogF : Form
	{
		internal static LogF instance;

		public LogF()
		{
			instance = this;

			InitializeComponent();

		}

		internal static void WriteLine(string s)
		{
			instance._logOutput.AppendText(s + Environment.NewLine);
		}

		private void LogF_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_logOutput.Text = "";
		}
	}
}
