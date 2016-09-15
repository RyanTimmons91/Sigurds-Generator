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
	public partial class Options : Form
	{
		public Options()
		{
			InitializeComponent();
		}

		private void _cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void _save_Click(object sender, EventArgs e)
		{
			Save();
		}
		internal void Save()
		{
			if(_generatorVersion.SelectedIndex == -1)
			{
				MessageBox.Show("Invalid Generator Version Selection! Settings have not been saved!");
				return;
			}
			Properties.Settings.Default.GeneratorVersion = int.Parse((string)_generatorVersion.SelectedItem);
			Properties.Settings.Default.Save();
			this.Close();
		}

		private void Options_Load(object sender, EventArgs e)
		{
			_generatorVersion.SelectedIndex = FindIndex(Properties.Settings.Default.GeneratorVersion);
		}

		int FindIndex(int version)
		{
			for(int i = 0; i<_generatorVersion.Items.Count; i++)
			{
				if ((string)_generatorVersion.Items[i] == (version + "").Trim())
					return i;
			}
			return 0;
		}
	}
}
