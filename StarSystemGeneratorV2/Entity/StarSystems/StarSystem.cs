using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarSystemGeneratorV2.Generator;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class StarSystem : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.StarSystem; }
		}

		internal Randomize _Generator = null;
		internal override Randomize Generator { get { return _Generator; } }

		internal int _VersionNumber = 28;
		internal override int VersionNumber { get { return _VersionNumber; } }

		internal int _SystemNumber = 0;
		internal override int SystemNumber
		{
			get
			{
				return _SystemNumber;
			}
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, "System " + _SystemNumber + " " + StarSystemType.ToString());

					List<NodeObject> BaseObjects = new List<NodeObject>();

					foreach (SystemEntity se in ChildEntities)
					{
						if (se.EntityType == EntityTypes.HyperspaceGate) //Hyperspace gates get added first!
						{
							no.Node.Nodes.Add(se.Node.Node);
						}
						else
						{
							BaseObjects.Add(se.Node); //Other entities, should only be stars
						}
					}

					//Stars
					foreach (NodeObject basenode in BaseObjects)
					{
						no.Node.Nodes.Add(basenode.Node);
					}

					_Node = no;
					return no;
				}
				else return _Node;
			}
		}

		StarSystemTypes StarSystemType;

		internal StarSystem(int genVersion, int sysNumber)
		{
			_VersionNumber = genVersion;
			
			if(sysNumber == 0)
			{
				_Generator = new Randomize();
				_SystemNumber = _Generator.diceHelper._Seed;
			}
			else
			{
				_Generator = new Randomize(sysNumber);
				_SystemNumber = sysNumber;
			}

			Generator._GenVersion = _VersionNumber;

			Generate();

			StarSystems.Add(this);
		}

		internal override void Generate()
		{
			int tvNum = VersionNumber;
			if (tvNum < 29) tvNum = 29;

			StarSystemType = Generator.StarSystemType();

			switch(tvNum)
			{
				case 29:
					GenerateHyperspaceGate();
					GenerateStars();
					return;
				case 30:
				default:
					/*
					 * Version 30 Removed Hyperspace Gate Generation from Star Systems
					 */
					GenerateStars();
					return;
			}
		}

		void GenerateHyperspaceGate()
		{
			ChildEntities.Add(new HyperspaceGate(this));
		}

		void GenerateStars()
		{
			int StarCount = (int)StarSystemType;

			for (int i = 0; i < StarCount; i++)
			{
				ChildEntities.Add(new Star(this));
			}
		}
	}
}
