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
	public partial class PlanetControl : UserControl
	{
		Planet planet;

		internal PlanetControl(SystemEntity se)
		{
			InitializeComponent();

			Planet planet = (Planet)se;

			_sizeBox.Text = planet.Size.ToString();
			_atmosphereBox.Text = planet.entityAtmosphere_Final.ToString();
			_tempBox.Text = planet.entityTemperature_Final.ToString();
			_ecologyBox.Text = planet.entityEcology.ToString();

			//_livingBox.Text = p.LivingCivilization.ToString();
			//_lostBox.Text = p.LostCivilization.ToString() + " " + p.LostCivIntactPercentage + "% intact";

			//foreach(UniquePlanetAspects UPA in p.UniquePlanetAspects)
			//{
			//	_uniqueAspectBox.Items.Add(UPA);
			//}

			//foreach (Resource R in p.Resources)
			//{
			//	_resourcesBox.Items.Add(R);
			//}
		}
	}
}
