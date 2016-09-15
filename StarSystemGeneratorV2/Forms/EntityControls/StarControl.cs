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
	public partial class StarControl : UserControl
	{
		Star star;

		internal StarControl(Star st)
		{
			InitializeComponent();

			star = st;

			int HE3 = 0;
			int Planets = 0;
			int OxygenPlanets = 0;
			int OxyMethPlanets = 0;

			Planets += st.Planets.Length; //All Planets

			foreach (Planet p in st.Planets)
			{
				if (p.isGasGiant)
				{
					//IS A GAS GIANT
					if (p.GasGiantAtmospheres.Contains(AtmosphereTypes.HE3))
					{
						HE3++; //ALL HE3
					}
				}
				else
				{
					//NOT A GAS GIANT
					if (p.entityAtmosphere == AtmosphereTypes.Oxygen) OxygenPlanets++; //OXYGEN ATMO
					if (p.entityAtmosphere == AtmosphereTypes.OxygenMethane) OxyMethPlanets++; //OXYMETH ATMO
				}

				foreach (Moon m in p.Moons)
				{
					if (m.entityAtmosphere == AtmosphereTypes.Oxygen) OxygenPlanets++; //OXYGEN ATMO
					if (m.entityAtmosphere == AtmosphereTypes.OxygenMethane) OxyMethPlanets++; //OXYMETH ATMO
				}
			}

			_HE3CountBox.Text = HE3.ToString();
			_oxygenCountBox.Text = OxygenPlanets.ToString();
			_methoxyBox.Text = OxyMethPlanets.ToString();
			_planetCountBox.Text = Planets.ToString();

		}
	}
}
