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
	public partial class MissileLauncher : Form
	{
		public MissileLauncher()
		{
			InitializeComponent();
		}

		private void ValueChanged(object sender, EventArgs e)
		{
			decimal TotalCost = 0;
			decimal TotalWeight = 0;

			switch (_tubeType.SelectedIndex)
			{
				case 0:
					TotalCost += 100;
					TotalWeight += .005m;
					break;
				case 1:
					TotalCost += 25;
					TotalWeight += 0.1m;
					break;
				case 2:
					TotalCost += 50;
					TotalWeight += 0.15m;
					break;
				case 3:
					TotalCost += 75;
					TotalWeight += 0.2m;
					break;
				case 4:
					TotalCost += 100;
					TotalWeight += 0.25m;
					break;
				case 5:
					TotalCost += 250;
					TotalWeight += 0.3m;
					break;
				case 6:
					TotalCost += 500;
					TotalWeight += 0.35m;
					break;
				case 7:
					TotalCost += 750;
					TotalWeight += 0.4m;
					break;
				case 8:
					TotalCost += 1000;
					TotalWeight += 0.45m;
					break;
			};

			switch (_magType.SelectedIndex)
			{
				case 0:
					TotalCost += 0;
					TotalWeight += 0;
					break;
				case 1:
					TotalCost += 25 * _magSize.Value;
					TotalWeight += 0.25m * _magSize.Value;
					break;
				case 2:
					TotalCost += 50 * _magSize.Value;
					TotalWeight += 0.5m * _magSize.Value;
					break;
				case 3:
					TotalCost += 2.5m * _magSize.Value;
					TotalWeight += 0.01m * _magSize.Value;
					break;
				case 4:
					TotalCost += 5 * _magSize.Value;
					TotalWeight += 0.02m * _magSize.Value;
					break;
				case 5:
					TotalCost += 7.5m * _magSize.Value;
					TotalWeight += 0.03m * _magSize.Value;
					break;
				case 6:
					TotalCost += 10 * _magSize.Value;
					TotalWeight += 0.04m * _magSize.Value;
					break;
				case 7:
					TotalCost += 25 * _magSize.Value;
					TotalWeight += 0.05m * _magSize.Value;
					break;
				case 8:
					TotalCost += 50 * _magSize.Value;
					TotalWeight += 0.06m * _magSize.Value;
					break;
				case 9:
					TotalCost += 75 * _magSize.Value;
					TotalWeight += 0.07m * _magSize.Value;
					break;
				case 10:
					TotalCost += 100 * _magSize.Value;
					TotalWeight += 008m * _magSize.Value;
					break;
			};

			_weight.Text = TotalWeight + " Metric Tons";
			_cost.Text = TotalCost + " Credits";
		}
	}
}
