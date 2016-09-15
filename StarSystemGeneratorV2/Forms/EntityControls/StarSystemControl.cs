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
	public partial class StarSystemControl : UserControl
	{
		internal StarSystemControl(SystemEntity s)
		{
			InitializeComponent();

			int HE3 = 0;
			int Planets = 0;
			int OxygenPlanets = 0;
			int OxyMethPlanets = 0;

			_starSystemBox.Text = s.SystemNumber.ToString();

			foreach(SystemEntity se in s.ChildEntities)
			{
				if(se.EntityType == Entity.EntityTypes.HyperspaceGate)
				{
					_HSGBox.Text = ((HyperspaceGate)se).GateType.ToString();
				}
				else if(se.EntityType == Entity.EntityTypes.Star)
				{
					//Planets += st.Planets.Length; //All Planets

					//foreach(Planet p in st.Planets)
					//{
					//	if(p.isGasGiant)
					//	{
					//		//IS A GAS GIANT
					//		if (p.GasGiantAtmospheres.Contains(AtmosphereTypes.HE3))
					//		{
					//			HE3++; //ALL HE3
					//		}
					//	}
					//	else
					//	{
					//		//NOT A GAS GIANT
					//		if (p.entityAtmosphere == AtmosphereTypes.Oxygen) OxygenPlanets++; //OXYGEN ATMO
					//		if (p.entityAtmosphere == AtmosphereTypes.OxygenMethane) OxyMethPlanets++; //OXYMETH ATMO
					//	}

					//	foreach(Moon m in p.Moons)
					//	{
					//		if (m.entityAtmosphere == AtmosphereTypes.Oxygen) OxygenPlanets++; //OXYGEN ATMO
					//		if (m.entityAtmosphere == AtmosphereTypes.OxygenMethane) OxyMethPlanets++; //OXYMETH ATMO
					//	}
					//}
				}
			}

			_HE3CountBox.Text = HE3.ToString();
			_oxygenCountBox.Text = OxygenPlanets.ToString();
			_methoxyBox.Text = OxyMethPlanets.ToString();
			_planetCountBox.Text = Planets.ToString();

		}
	}
}
