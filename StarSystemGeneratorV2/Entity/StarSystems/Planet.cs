using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class Planet : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.Planet; }
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, NodeText);

					List<NodeObject> CivilizationNodes = new List<NodeObject>();

					List<NodeObject> AspectEntities = new List<NodeObject>();
					List<NodeObject> ResourceEntities = new List<NodeObject>();

					List<NodeObject> BaseEntities = new List<NodeObject>();

					foreach (SystemEntity se in ChildEntities)
					{
						if (se.EntityType == EntityTypes.Civilization)
						{
							CivilizationNodes.Add(se.Node);
						}
						else if (se.EntityType == EntityTypes.UniquePlanetaryAspect)
						{
							AspectEntities.Add(se.Node);
						}
						else if (se.EntityType == EntityTypes.Resource)
						{
							ResourceEntities.Add(se.Node);
						}
						else
						{
							BaseEntities.Add(se.Node);
						}
					}

					foreach (NodeObject civnode in CivilizationNodes)
					{
						no.Node.Nodes.Add(civnode.Node);
					}

					if (AspectEntities.Count == 1)
					{
						foreach (NodeObject ano in AspectEntities)
						{
							no.Node.Nodes.Add(ano.Node);
						}
					}
					else
					{
						if (AspectEntities.Count > 1)
						{
							TreeNode aspectNode = no.Node.Nodes.Add("U.Aspects");
							foreach (NodeObject ano in AspectEntities)
							{
								aspectNode.Nodes.Add(ano.Node);
							}
						}
					}

					if (ResourceEntities.Count > 0)
					{
						TreeNode ResourceNode = no.Node.Nodes.Add("Resources");
						foreach (NodeObject rnode in ResourceEntities)
						{
							ResourceNode.Nodes.Add(rnode.Node);
						}
					}

					foreach (NodeObject bnode in BaseEntities)
					{
						no.Node.Nodes.Add(bnode.Node);
					}

					_Node = no;
					return no;
				}
				else return _Node;
			}
		}
		
		string NodeText
		{
			get
			{
				if(isGasGiant)
				{
					return "Gas " + GGS.ToString();
				}
				else
				{
					return "Planet " + entityAtmosphere_Final;
				}
			}
		}

		internal bool isGasGiant
		{
			get
			{
				if (GGS == GasGiantStatus.NotAGasGiant) return false;
				return true;
			}
		}
		internal bool CanSupportLife
		{
			get
			{
				if (Generator.UsableAtmospheres.Contains(entityAtmosphere_Final)) return true;
				return false;
			}
		}

		internal PlanetMoonSizes Size;

		internal GasGiantStatus GGS = GasGiantStatus.NotAGasGiant;

		internal AtmosphereTypes[] gasAtmospheres;

		internal AtmosphereTypes entityAtmosphere_Original;
		internal AtmosphereTypes entityAtmosphere_Final;

		internal Temperatures entityTemperature_Original;
		internal Temperatures entityTemperature_Final;

		internal Ecologies entityEcology;
		
		//UniqueAspects, Resources, Moons, and Civilizations are Child Entities!

		internal Planet(SystemEntity parent)
		{
			ParentEntity = parent;

			Generate();
		}

		internal override void Generate()
		{
			GenerateV30();
		}

		void GenerateV30()
		{
			Size = Generator.PlanetSize();

			GGS = Generator.GasGiantCheck();
			if (GGS == GasGiantStatus.Other)
			{
				gasAtmospheres = Generator.GasGiantOtherAtmospheres();
			}

			var UniqueAspects = Generator.UniquePlanetaryAspects();
			foreach(UniquePlanetAspects aspect in UniqueAspects)
			{
				ChildEntities.Add(new UniquePlanetaryAspects(this, aspect));
			}

			if(Size == PlanetMoonSizes.Large || Size == PlanetMoonSizes.Giant)
			{
				GenerateMoons(); //Generate two sets of moons if we are a very large planet
				GenerateMoons();
			}
			else
			{
				GenerateMoons(); //Otherwise just one set
			}

			if(!isGasGiant)
			{
				GeneratePlanet(); //We then generate the actual planet itself
			}
			
		}
		void GenerateMoons()
		{
			int randomRoll = Generator.diceHelper.D20();
			int MoonCount = RollToCount(randomRoll);

			for (int i = 0; i < MoonCount; i++)
			{
				ChildEntities.Add(new Moon(this));
			}
		}
		int RollToCount(int roll)
		{
			switch (roll)
			{
				case 1:
				case 2:
					return 0;
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
					return 1;
				case 10:
				case 11:
				case 12:
				case 13:
					return Generator.diceHelper.D2() + 1;
				case 14:
				case 15:
				case 16:
					return Generator.diceHelper.D3() + 2;
				case 17:
				case 18:
					return Generator.diceHelper.D4() + 3;
				case 19:
					ChildEntities.Add(new DebrisRing(this, PlanetMoonSizes.ThinDebrisRing));
					return 0;
				case 20:
					ChildEntities.Add(new DebrisRing(this, PlanetMoonSizes.ThickDebrisRing));
					return 0;
				default:
					return 0;
			}
		}

		void GeneratePlanet()
		{
			entityAtmosphere_Final = Generator.PlanetAtmosphere();
			entityAtmosphere_Original = entityAtmosphere_Final;

			if ((int)entityAtmosphere_Final < 7) entityAtmosphere_Final = StarTypeModifiers.ModifyAtmosphere(ParentEntity, entityAtmosphere_Final);

			if(CanSupportLife)
			{
				entityTemperature_Final = Generator.Temperature();
				entityTemperature_Original = entityTemperature_Final;
				entityTemperature_Final = StarTypeModifiers.ModifyTemperature(ParentEntity, entityTemperature_Final);

				entityEcology = Generator.Ecology(entityTemperature_Final);
				entityEcology = StarTypeModifiers.ModifyEcology(ParentEntity, entityEcology);

				if(Generator.LivingCivilizationCheck())
				{
					ChildEntities.Add(new Civilization(this, CivilizationTypes.Living, Generator.CivilizationTechLevel()));
				}
			}

			if(Generator.LostCivilizationCheck())
			{
				if(!isGasGiant)
				{
					if(entityAtmosphere_Final == AtmosphereTypes.TooYoung || entityAtmosphere_Final == AtmosphereTypes.NeverDeveloped)
					{
						ChildEntities.Add(new Civilization(this, CivilizationTypes.Lost, Generator.GasGiantLostCivilizationTechLevel()));
					}
					else
					{
						ChildEntities.Add(new Civilization(this, CivilizationTypes.Lost, Generator.CivilizationTechLevel()));
					}
				}
				else
				{
					ChildEntities.Add(new Civilization(this, CivilizationTypes.Lost, Generator.GasGiantLostCivilizationTechLevel()));
				}
			}

			//Resources
			int ResourceCount = Generator.NumberOfResources();

			for(int i = 0; i < ResourceCount; i++)
			{
				DepositTypes DT = Generator.DepositType();
				if (DT == DepositTypes.None) continue;

				ChildEntities.Add(new Resource(this, DT));
			}
		}
	}
}
