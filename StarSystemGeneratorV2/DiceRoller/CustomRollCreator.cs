using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.DiceRoller
{
	public partial class CustomRollCreator : Form
	{
		public CustomRollCreator()
		{
			InitializeComponent();
		}

		private void CustomRollCreator_Load(object sender, EventArgs e)
		{

		}

		private void _test_Click(object sender, EventArgs e)
		{
			Test();
		}

		private void _cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void _save_Click(object sender, EventArgs e)
		{
			Test();

			CustomRoll.AddCustomRoll(_rollName.Text, _rollFormula.Text);
			CustomRoll.SaveAll();
			this.Close();
		}

		bool Test()
		{
			DiceRoller.CustomRollData CRD = new CustomRollData(_rollFormula.Text);
			_testOutput.Text = "" + CRD.Roll();

			return true;
		}
	}
}
