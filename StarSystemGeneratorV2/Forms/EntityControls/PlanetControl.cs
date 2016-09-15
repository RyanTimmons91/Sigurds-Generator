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
	public partial class PlanetControl : UserControl
	{
		Planet planet;

		internal PlanetControl(Planet p)
		{
			InitializeComponent();

			planet = p;

			_sizeBox.Text = p.Size.ToString();
			_atmosphereBox.Text = p.entityAtmosphere + " was " + p.originalAtmosphere;
			_tempBox.Text = p.entityTemperature + " was " + p.originalTemperature;
			_ecologyBox.Text = p.entityEcology.ToString();

			_livingBox.Text = p.LivingCivilization.ToString();
			_lostBox.Text = p.LostCivilization.ToString() + " " + p.LostCivIntactPercentage + "% intact";

			foreach(UniquePlanetAspects UPA in p.UniquePlanetAspects)
			{
				_uniqueAspectBox.Items.Add(UPA);
			}

			foreach (Resource R in p.Resources)
			{
				_resourcesBox.Items.Add(R);
			}
		}
	}
}
