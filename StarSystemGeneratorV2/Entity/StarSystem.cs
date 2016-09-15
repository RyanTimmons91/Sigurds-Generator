using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StarSystemGeneratorV2.Generator;

namespace StarSystemGeneratorV2.Entity
{
	class StarSystem
	{
		internal static List<StarSystem> StarSystems = new List<StarSystem>();

		internal Randomize Generate = new Randomize();

		StarSystemTypes StarSystemType;
		internal HyperSpaceGateTypes HyperSpaceGate;

		internal Star[] Stars;

		internal StarSystem()
		{
			Generate = new Randomize();
			GenerateSystem();

			InitializeSystem();
		}
		internal StarSystem(int seed)
		{
			Generate = new Randomize(seed);
			GenerateSystem();

			InitializeSystem();
		}

		void GenerateSystem()
		{
			StarSystemType = Generate.StarSystemType();
			HyperSpaceGate = Generate.HyperSpaceGateStatus();

			Stars = new Star[(int)StarSystemType];

			for (int i = 0; i < Stars.Length; i++)
			{
				Stars[i] = new Star(Generate);
			}
		}

		void InitializeSystem()
		{
			StarSystems.Add(this);
		}

		internal TreeNode TreeNode()
		{
			NodeObject NO = new NodeObject(Generate.diceHelper._Seed, this, EntityTypes.StarSystem, StarSystemType.ToString() + " System | " + Generate.diceHelper._Seed);

			if(HyperSpaceGate != HyperSpaceGateTypes.NoGate)
			{
				NO.Node.Nodes.Add(HyperSpaceGate.ToString());
			}
			
			foreach(Star s in Stars)
			{
				NO.Node.Nodes.Add(s.TreeNode());
			}

			NO.SetColor();

			return NO.Node;
		}
	}
}
