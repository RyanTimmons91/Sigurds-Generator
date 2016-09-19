using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarSystemGeneratorV2.Entity.StarSystems;

namespace StarSystemGeneratorV2.EntityControls
{
	public partial class MoonControl : UserControl
	{
		Moon moon;

		internal MoonControl(SystemEntity se)
		{
			InitializeComponent();

			Moon moon = (Moon)se;

			_sizeBox.Text = moon.Size.ToString();
			_atmosphereBox.Text = moon.entityAtmosphere_Final.ToString();
			_tempBox.Text = moon.entityTemperature_Final.ToString();
			_ecologyBox.Text = moon.entityEcology.ToString();

			//_livingBox.Text = m.LivingCivilization.ToString();
			//_lostBox.Text = m.LostCivilization.ToString() + " " + m.LostCivIntactPercentage + "% intact";

			//foreach (Resource R in m.Resources)
			//{
			//	_resourcesBox.Items.Add(R);
			//}

		}
	}
}
