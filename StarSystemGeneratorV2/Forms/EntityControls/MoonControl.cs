using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StarSystemGeneratorV2.Entity;

namespace StarSystemGeneratorV2.EntityControls
{
	public partial class MoonControl : UserControl
	{
		Moon moon;

		internal MoonControl(Entity.Moon m)
		{
			InitializeComponent();

			moon = m;

			_sizeBox.Text = m.Size.ToString();
			_atmosphereBox.Text = m.entityAtmosphere + " was " + m.originalAtmosphere;
			_tempBox.Text = m.entityTemperature + " was " + m.originalTemperature;
			_ecologyBox.Text = m.entityEcology.ToString();

			_livingBox.Text = m.LivingCivilization.ToString();
			_lostBox.Text = m.LostCivilization.ToString() + " " + m.LostCivIntactPercentage + "% intact";

			foreach (Resource R in m.Resources)
			{
				_resourcesBox.Items.Add(R);
			}

		}
	}
}
