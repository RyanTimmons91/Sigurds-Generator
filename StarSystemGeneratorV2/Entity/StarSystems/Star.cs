using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class Star : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.Star; }
		}
		internal override NodeObject Node
		{
			get
			{
				NodeObject no = new NodeObject(this, "Star " + StarType.ToString() + " " + NumberOfPlanets, Color.Empty);

				foreach(SystemEntity se in ChildEntities)
				{
					no.Node.Nodes.Add(se.Node.Node);
				}

				return no;
			}
		}

		List<SystemEntity> _ChildEntities = new List<SystemEntity>();
		internal override List<SystemEntity> ChildEntities
		{
			get
			{
				return _ChildEntities;
			}
		}

		StarTypes StarType;
		SystemSizeTypes StarSystemSize;
		int NumberOfPlanets = 0;

		internal Star(SystemEntity parent)
		{
			ParentEntity = parent;
			
			Generate();
		}

		internal override void Generate()
		{
			int tvNum = VersionNumber;
			if (tvNum < 14) tvNum = 14;

			switch (tvNum)
			{
				case 14:
					GenerateVersion14();
					break;
				case 15:
				case 16:
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
					GenerateVersion15();
					return;
				case 30:
				default: //default to newer generator
					GenerateVersion30();
					break;
			}
		}

		internal void GenerateVersion14()
		{
			GenStarType14();
			GenCelestialBodies14();
			GenStarSystemSize14();
			GenPlanets14();
		}
		internal void GenerateVersion15()
		{
			GenerateVersion14();
			GenHyperSpaceGate15();
		}
		internal void GenerateVersion30()
		{
			GenHyperSpaceGate15();
			GenerateVersion14();
		}

		void GenStarType14()
		{
			StarType = Generator.StarType();
		}
		void GenCelestialBodies14()
		{
			CelestialBodyTypes[] CelestialBodies = Generator.CelestialBodies();

			for (int i = 0; i < CelestialBodies.Length; i++ )
			{
				ChildEntities.Add(new CelestialObject(this, CelestialBodies[i]));
			}
		}
		void GenStarSystemSize14()
		{
			StarSystemSize = Generator.SystemSize();
		}
		void GenPlanets14()
		{
			NumberOfPlanets = Generator.NumberOfPlanets(StarSystemSize);

			for (int i = 0; i < NumberOfPlanets; i++)
			{
				_ChildEntities.Add(new Planet(this));
			}
		}

		void GenHyperSpaceGate15()
		{
			ChildEntities.Add(new HyperspaceGate(this));
		}
	}
}
