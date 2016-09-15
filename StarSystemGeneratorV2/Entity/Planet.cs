using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StarSystemGeneratorV2.Generator;

namespace StarSystemGeneratorV2.Entity
{
	class Planet
	{
		internal Randomize Generate;

		Star parentStar;

		internal PlanetMoonSizes Size;

		internal bool isGasGiant
		{
			get
			{
				if (GasGiantType == GasGiantStatus.NotAGasGiant) return false;
				return true;
			}
		}
		internal GasGiantStatus GasGiantType;

		internal AtmosphereTypes[] GasGiantAtmospheres = new AtmosphereTypes[0];

		internal AtmosphereTypes entityAtmosphere;
		internal AtmosphereTypes originalAtmosphere;

		internal Temperatures entityTemperature;
		internal Temperatures originalTemperature;

		internal Ecologies entityEcology;

		internal UniquePlanetAspects[] UniquePlanetAspects;

		internal Resource[] Resources;

		internal List<Moon> Moons = new List<Moon>();
		internal List<DebrisRing> DebrisRings = new List<DebrisRing>();

		internal Civilization LivingCivilization = Civilization.NoCiv;
		internal Civilization LostCivilization = Civilization.NoCiv;
		internal int LostCivIntactPercentage = 0;

		bool CanSupportLife
		{
			get
			{
				if (Generate.UsableAtmospheres.Contains(entityAtmosphere)) return true;
				return false;
			}
		}

		internal Planet(Randomize gen, Star parent)
		{
			parentStar = parent;

			Generate = gen;

			Size = Generate.PlanetSize();

			GasGiantType = Generate.GasGiantCheck();
			if(GasGiantType == GasGiantStatus.Other)
			{
				GasGiantAtmospheres = Generate.GasGiantOtherAtmospheres();
			}

			UniquePlanetAspects = Generate.UniquePlanetaryAspects();

			GenerateMoons();

			if (Size == PlanetMoonSizes.Large || Size == PlanetMoonSizes.Giant)
			{
				GenerateMoons(); //Generate two sets of moons if it is a large or giant planet
			}

			if (!isGasGiant)
			{
				GeneratePlanet();
			}
			else
			{
				string test = "testing";
			}
		}

		void GeneratePlanet()
		{
			entityAtmosphere = Generate.PlanetAtmosphere();
			originalAtmosphere = entityAtmosphere;

			if ((int)entityAtmosphere < 7) entityAtmosphere = StarTypeModifiers.ModifyAtmosphere(parentStar, entityAtmosphere);

			if (CanSupportLife)
			{
				entityTemperature = Generate.Temperature();
				originalTemperature = entityTemperature;
				entityTemperature = StarTypeModifiers.ModifyTemperature(parentStar, entityTemperature);
				
				entityEcology = Generate.Ecology(entityTemperature);
				entityEcology = StarTypeModifiers.ModifyEcology(parentStar, entityEcology);

				if(Generate.LivingCivilizationCheck())
				{
					LivingCivilization = new Civilization(CivilizationTypes.Living, Generate.CivilizationTechLevel());
					//MessageBox.Show("FOUND LIVING CIV!" + Environment.NewLine + LivingCivilization.TechLevel);
				}
			}

			if(Generate.LostCivilizationCheck())
			{
				if(!isGasGiant)
				{
					if (entityAtmosphere == AtmosphereTypes.TooYoung || entityAtmosphere == AtmosphereTypes.NeverDeveloped)
					{
						LostCivilization = new Civilization(CivilizationTypes.Lost, Generate.GasGiantLostCivilizationTechLevel());
					}
					else
					{
						LostCivilization = new Civilization(CivilizationTypes.Lost, Generate.CivilizationTechLevel());
					}
				}
				else
				{
					LostCivilization = new Civilization(CivilizationTypes.Lost, Generate.GasGiantLostCivilizationTechLevel());
				}

				if (LostCivilization != Civilization.NoCiv)
				{
					LostCivIntactPercentage = Generate.diceHelper.Percentage();
				}
			}

			List<Resource> ResourceList = new List<Resource>();
			int count = Generate.NumberOfResources();

			for (int i = 0; i < count; i++)
			{
				DepositTypes DT = Generate.DepositType();

				if (DT == DepositTypes.None) continue;

				ResourceList.Add(new Resource(Generate.ResourceType(), DT));
			}

			Resources = ResourceList.ToArray();


		}

		internal void GenerateMoons()
		{
			int roll = Generate.diceHelper.D20();

			int MoonCount = 0;

			if(roll <=  2)
			{
				MoonCount = 0;
			}
			else if(roll <= 9)
			{
				MoonCount = 1;
			}
			else if(roll <= 13)
			{
				MoonCount = Generate.diceHelper.D2() + 1;
			}
			else if(roll <= 16)
			{
				MoonCount = Generate.diceHelper.D3() + 2;
			}
			else if(roll <= 18)
			{
				MoonCount = Generate.diceHelper.D4() + 3;
			}
			else if(roll <= 19)
			{
				DebrisRings.Add(new DebrisRing(Generate, PlanetMoonSizes.ThinDebrisRing));
			}
			else if(roll <= 20)
			{
				DebrisRings.Add(new DebrisRing(Generate, PlanetMoonSizes.ThickDebrisRing));
			}

			for(int i = 0; i < MoonCount; i++)
			{
				Moons.Add(new Moon(this, Generate, parentStar));
			}
		}

		internal TreeNode TreeNode()
		{
			NodeObject NO = new NodeObject(Generate.diceHelper._Seed, this, EntityTypes.Planet, Size.ToString() + " Planet - " + entityAtmosphere);

			foreach(DebrisRing dr in DebrisRings)
			{
				NO.Node.Nodes.Add(dr.TreeNode());
			}

			foreach (Moon m in Moons)
			{
				NO.Node.Nodes.Add(m.TreeNode());
			}

			return NO.Node;
		}
	}
}
