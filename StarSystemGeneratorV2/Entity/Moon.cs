using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StarSystemGeneratorV2.Generator;

namespace StarSystemGeneratorV2.Entity
{
	class Moon
	{
		internal Randomize Generate;

		Star parentStar;

		Planet Parent;
		internal PlanetMoonSizes Size;

		internal AtmosphereTypes entityAtmosphere = AtmosphereTypes.None;
		internal AtmosphereTypes originalAtmosphere;

		internal Temperatures entityTemperature;
		internal Temperatures originalTemperature;

		internal Ecologies entityEcology;

		internal Resource[] Resources;

		internal Civilization LivingCivilization = Civilization.NoCiv;
		internal Civilization LostCivilization = Civilization.NoCiv;
		internal int LostCivIntactPercentage = 0;

		bool CanSupportLife
		{
			get
			{
				if (Generate.UsableAtmospheres.Contains(entityAtmosphere) && Size >= PlanetMoonSizes.Luna) return true;
				return false;
			}
		}

		internal Moon(Planet parent, PlanetMoonSizes size, Randomize gen, Star starParent)
		{
			parentStar = starParent;

			Generate = gen;

			Parent = parent;
			Size = size;

			GenerateMoon();
		}

		internal Moon(Planet parent, Randomize gen, Star starParent)
		{
			parentStar = starParent;

			Generate = gen;

			Parent = parent;
			Size = Generate.MoonSize(parent.Size);

			GenerateMoon();
		}

		void GenerateMoon()
		{
			if(Size >= PlanetMoonSizes.Luna)
			{
				entityAtmosphere = Generate.PlanetAtmosphere();
				originalAtmosphere = entityAtmosphere;

				if ((int)entityAtmosphere < 7) entityAtmosphere = StarTypeModifiers.ModifyAtmosphere(parentStar, entityAtmosphere);

				if (Generate.LostCivilizationCheck())
				{
					if (entityAtmosphere == AtmosphereTypes.TooYoung || entityAtmosphere == AtmosphereTypes.NeverDeveloped)
					{
						LostCivilization = new Civilization(CivilizationTypes.Lost, Generate.GasGiantLostCivilizationTechLevel());
					}
					else
					{
						LostCivilization = new Civilization(CivilizationTypes.Lost, Generate.CivilizationTechLevel());
					}

					if(LostCivilization != Civilization.NoCiv)
					{
						LostCivIntactPercentage = Generate.diceHelper.Percentage();
					}
				}
			}

			if (CanSupportLife)
			{
				entityTemperature = Generate.Temperature();
				originalTemperature = entityTemperature;
				entityTemperature = StarTypeModifiers.ModifyTemperature(parentStar, entityTemperature);


				entityEcology = Generate.Ecology(entityTemperature);
				entityEcology = StarTypeModifiers.ModifyEcology(parentStar, entityEcology);

				if (Generate.LivingCivilizationCheck())
				{
					LivingCivilization = new Civilization(CivilizationTypes.Living, Generate.CivilizationTechLevel());
					//MessageBox.Show("FOUND LIVING CIV!" + Environment.NewLine + LivingCivilization.TechLevel);
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

		internal TreeNode TreeNode()
		{
			NodeObject NO = new NodeObject(Generate.diceHelper._Seed, this, EntityTypes.Moon, Size.ToString() + " - " + entityAtmosphere);

			return NO.Node;
		}
	}
}
