using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class Moon : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.Moon; }
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, "Moon " + Size.ToString() + " " + entityAtmosphere_Final);

					List<NodeObject> CivilizationNodes = new List<NodeObject>();

					List<NodeObject> ResourceNodes = new List<NodeObject>();
					List<NodeObject> BaseEntities = new List<NodeObject>();

					foreach (SystemEntity se in ChildEntities)
					{
						if (se.EntityType == EntityTypes.Civilization)
						{
							CivilizationNodes.Add(se.Node);
						}
						else if (se.EntityType == EntityTypes.Resource)
						{
							ResourceNodes.Add(se.Node);
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

					if (ResourceNodes.Count > 0)
					{
						TreeNode ResourceNode = no.Node.Nodes.Add("Resources");
						foreach (NodeObject rnode in ResourceNodes)
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

		internal PlanetMoonSizes Size;

		internal AtmosphereTypes entityAtmosphere_Original;
		internal AtmosphereTypes entityAtmosphere_Final;

		internal Temperatures entityTemperature_Original;
		internal Temperatures entityTemperature_Final;

		internal Ecologies entityEcology;

		bool CanSupportLife
		{
			get
			{
				if (Generator.UsableAtmospheres.Contains(entityAtmosphere_Final) && Size >= PlanetMoonSizes.Luna) return true;
				return false;
			}
		}

		internal Moon(SystemEntity parent)
		{
			ParentEntity = parent;

			Size = Generator.MoonSize(((Planet)parent).Size);

			Generate();
		}

		internal override void Generate()
		{
			GenerateV30();
		}

		internal void GenerateV30()
		{
			if(Size >= PlanetMoonSizes.Luna)
			{
				entityAtmosphere_Final = Generator.PlanetAtmosphere();
				entityAtmosphere_Original = entityAtmosphere_Final;

				if ((int)entityAtmosphere_Final < 7) entityAtmosphere_Final = StarTypeModifiers.ModifyAtmosphere(ParentEntity.ParentEntity, entityAtmosphere_Final);

				if(Generator.LostCivilizationCheck())
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
			}

			if(CanSupportLife)
			{
				entityTemperature_Final = Generator.Temperature();
				entityTemperature_Original = entityTemperature_Final;
				entityTemperature_Final = StarTypeModifiers.ModifyTemperature(ParentEntity.ParentEntity, entityTemperature_Final);

				entityEcology = Generator.Ecology(entityTemperature_Final);
				entityEcology = StarTypeModifiers.ModifyEcology(ParentEntity.ParentEntity, entityEcology);

				if(Generator.LivingCivilizationCheck())
				{
					ChildEntities.Add(new Civilization(this, CivilizationTypes.Living, Generator.CivilizationTechLevel()));
				}
			}

			int ResourceCount = Generator.NumberOfResources();

			for(int i = 0; i < ResourceCount; i++)
			{
				DepositTypes DT = Generator.DepositType();
				if(DT == DepositTypes.None) continue;

				ChildEntities.Add(new Resource(this, DT));
			}
		}
	}
}
