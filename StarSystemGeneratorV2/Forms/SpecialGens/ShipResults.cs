using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Forms.SpecialGens
{
	public partial class ShipResults : Form
	{
		Entity.Ship ship;

		public ShipResults(Entity.Ship ship)
		{
			InitializeComponent();
			this.ship = ship;
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			UpdateOutput();
		}

		internal void UpdateOutput()
		{
			_output.Rows.Clear();

			List<object[]> Rows = ship.BuildDataGrid();
			foreach(object[] row in Rows)
			{
				_output.Rows.Add(row);
			}
		}

		private void toggleAutoRefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(timer1.Enabled)
			{
				toggleAutoRefreshToolStripMenuItem.BackColor = Color.Salmon;
				timer1.Enabled = false;
			}
			else
			{
				toggleAutoRefreshToolStripMenuItem.BackColor = Color.LimeGreen;
				timer1.Enabled = true;
			}
		}
	}
}
