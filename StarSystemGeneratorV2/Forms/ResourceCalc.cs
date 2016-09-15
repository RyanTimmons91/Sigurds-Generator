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
	public partial class ResourceCalc : Form
	{
		double CurrentValue = 0;

		List<double> PlanetSizeValues = new List<double>()
			{
				/*
				 * Small As
				 * 785398 Total cubic KM
				 * 4330684572 MT
				 * 
				 * Medium As
				 * 1767145 Total cubic KM
				 * 9744037530 MT
				 * 
				 * Large As
				 * 4908738 Total cubic KM
				 * 27066781332 MT
				 * 
				 * Luna Planet
				 * 19634954 Total cubic KM
				 * 108267136356 MT
				 * 
				 * Small Planet
				 * 176714586 Total cubic KM
				 * 974404227204 MT
				 * 
				 * Medium
				 * 1963495408 Total cubic KM
				 * 10826713679712 MT
				 * 
				 * Large
				 * 17671458676 Total cubic KM
				 * 97440423139464 MT
				 * 
				 * Giant
				 * 70685834705 Total cubic KM
				 * 389761692563370 MT
				 * 
				 */
				//SA
				2887123647385220d,
				//MA
				9744042309925110d,
				//LA
				45111306990394000d,
				//LU
				360890455923152000d,
				//SP
				9744042309925110000d,
				//MP
				360890455923152000000d,
				//LP
				9744042309925110000000d,
				//GP
				77952338479400900000000d
			};
		List<double> ResourceValues = new List<double>()
			{
				9,
				5,
				640,
				50000,
				70548,
				20000,
				321507,
				130,
				1,
				2,
				7.5,
				500000
			};
		List<double> ResourceSizes = new List<double>()
			{
				.005,
				.01,
				.025,
				.05
			};


		public ResourceCalc()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Recalculate();
		}


		void Recalculate()
		{
			if(_resourceType.SelectedIndex != -1 && _planetSize.SelectedIndex != -1 && _resourceAmount.SelectedIndex != -1)
			{
				CurrentValue = PlanetSizeValues[_planetSize.SelectedIndex] * ResourceSizes[_resourceAmount.SelectedIndex] * ResourceValues[_resourceType.SelectedIndex];

				_output.Text = CurrentValue.ToString("C");

				_modifiedOutput.Text = (CurrentValue * (double)numericUpDown1.Value).ToString("C");
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			numericUpDown1.Value = ((decimal)_perTrack.Value / 100);
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			Recalculate();
		}
	}
}
