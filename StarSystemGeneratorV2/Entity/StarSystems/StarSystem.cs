using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarSystemGeneratorV2.Generator;
using System.Drawing;

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

		internal override NodeObject Node
		{
			get
			{
				NodeObject no = new NodeObject(this, "Star System " + _SystemNumber, Color.Empty);

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

			Generate();

			StarSystems.Add(this);
		}

		internal override void Generate()
		{
			int tvNum = VersionNumber;
			if (tvNum < 29) tvNum = 29;

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
			StarSystemType = Generator.StarSystemType();

			int StarCount = (int)StarSystemType;

			for (int i = 0; i < StarCount; i++)
			{
				ChildEntities.Add(new Star(this));
			}
		}
	}
}
