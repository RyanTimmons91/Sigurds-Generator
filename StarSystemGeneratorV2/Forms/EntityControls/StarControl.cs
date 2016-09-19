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
	public partial class StarControl : UserControl
	{
		Star star;

		internal StarControl(SystemEntity se)
		{
			InitializeComponent();

			Star star = (Star)se;

			int HE3 = 0;
			int Planets = 0;
			int OxygenPlanets = 0;
			int OxyMethPlanets = 0;

			foreach(SystemEntity entity in star.ChildEntities)
			{
				if(entity.EntityType == EntityTypes.GasGiant)
				{
					Planets++;
					Planet giant = (Planet)entity;
					if(giant.gasAtmospheres.Contains(AtmosphereTypes.HE3))
					{
						HE3++;
					}
				}
				if (entity.EntityType == EntityTypes.Planet)
				{
					Planets++;
					Planet planet = (Planet)entity;
					if(planet.entityAtmosphere_Final == AtmosphereTypes.HE3) HE3++;
					if(planet.entityAtmosphere_Final == AtmosphereTypes.Oxygen) OxygenPlanets++;
					if(planet.entityAtmosphere_Final == AtmosphereTypes.OxygenMethane) OxyMethPlanets++;

					foreach(SystemEntity child in planet.ChildEntities)
					{
						if(child.EntityType == EntityTypes.Moon)
						{
							Moon moon = (Moon)child;
							if(moon.entityAtmosphere_Final == AtmosphereTypes.HE3) HE3++;
							if(moon.entityAtmosphere_Final == AtmosphereTypes.Oxygen) OxygenPlanets++;
							if(moon.entityAtmosphere_Final == AtmosphereTypes.OxygenMethane) OxyMethPlanets++;
						}
					}
				}
			}

			_HE3CountBox.Text = HE3.ToString();
			_oxygenCountBox.Text = OxygenPlanets.ToString();
			_methoxyBox.Text = OxyMethPlanets.ToString();
			_planetCountBox.Text = Planets.ToString();

		}
	}
}
