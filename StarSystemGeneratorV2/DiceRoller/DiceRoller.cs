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
    public partial class DiceRollerForm: Form
    {
		DiceHelper Dice = new DiceHelper();

        public DiceRollerForm()
        {
            InitializeComponent();
        }

		private void clearOutputToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_outputTextbox.Clear();
		}

		private void _rollD3_Click(object sender, EventArgs e)
		{
			AddLine(Dice.D3() + "");
		}
		private void _rollD4_Click(object sender, EventArgs e)
		{
			AddLine(Dice.D4() + "");
		}
		private void _rollD6_Click(object sender, EventArgs e)
		{
			AddLine(Dice.D6() + "");
		}
		private void _rollD8_Click(object sender, EventArgs e)
		{
			AddLine(Dice.D8() + "");
		}
		private void _rollD10_Click(object sender, EventArgs e)
		{
			AddLine(Dice.D10() + "");
		}
		private void _rollD12_Click(object sender, EventArgs e)
		{
			AddLine(Dice.D12() + "");
		}
		private void _rollD20_Click(object sender, EventArgs e)
		{
			AddLine(Dice.D20() + "");
		}
		private void _rollDpercent_Click(object sender, EventArgs e)
		{
			AddLine(Dice.Percentage() + "%");
		}

		internal void AddLine(string s)
		{
			_outputTextbox.AppendText(s + Environment.NewLine);
		}

		private void createToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new DiceRoller.CustomRollCreator().ShowDialog();
			LoadCustomDieRolls();
		}

		void LoadCustomDieRolls()
		{
			_CustomDice.Controls.Clear();

			foreach (KeyValuePair<string, DiceRoller.CustomRollData> kv in DiceRoller.CustomRoll.CustomRolls)
			{
				Button b = new Button();

				b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				b.Size = new System.Drawing.Size(55, 44);
				b.Text = kv.Key;
				b.UseVisualStyleBackColor = true;
				b.Click += new System.EventHandler(DiceRoller.CustomRoll.CustomRolls[kv.Key].Roll);

				_CustomDice.Controls.Add(b);
			}
		}

		private void DiceRollerForm_Load(object sender, EventArgs e)
		{
			LoadCustomDieRolls();

			this.Hide();
		}

		private void DiceRollerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;
		}
	}
}
