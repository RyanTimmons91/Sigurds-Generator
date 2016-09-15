using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StarSystemGeneratorV2.Generator;

namespace StarSystemGeneratorV2.Entity
{
	class Star
	{
		internal Randomize Generate;

		internal StarTypes StarType;

		CelestialObject[] CelestialObjects;

		SystemSizeTypes StarSystemSize;

		internal Planet[] Planets;

		internal HyperSpaceGateTypes HyperSpaceGate = HyperSpaceGateTypes.NoGate;

		internal Star(Randomize gen)
		{
			Generate = gen;

			switch(Generate.GenVersion)
			{
				case 14:
					GenerateVersion14();
					break;
				case 15:
				case 16:
				case 17:
				case 18:
				default: //default to newer generator
					GenerateVersion15();
					break;

			}
		}

		#region Part Generators
		#region OLDER ROLLS DO NOT EDIT
		void GenStarType14()
		{
			StarType = Generate.StarType();
		}
		void GenCelestialBodies14()
		{
			CelestialBodyTypes[] CelestialBodies = Generate.CelestialBodies();

			CelestialObjects = new CelestialObject[CelestialBodies.Length];

			for (int i = 0; i < CelestialBodies.Length; i++)
			{
				CelestialObjects[i] = new CelestialObject(Generate, CelestialBodies[i]);
			}
		}
		void GenStarSystemSize14()
		{
			StarSystemSize = Generate.SystemSize();
		}
		void GenPlanets14()
		{
			Planets = new Planet[Generate.NumberOfPlanets(StarSystemSize)];

			for (int i = 0; i < Planets.Length; i++)
			{
				Planets[i] = new Planet(Generate, this);
			}
		}

		void GenHyperSpaceGate15()
		{
			HyperSpaceGate = Generate.HyperSpaceGateStatus();
		}
		#endregion


		#endregion

		#region OLDER ROLLS DO NOT EDIT

		void GenerateVersion14()
		{
			GenStarType14();
			GenCelestialBodies14();
			GenStarSystemSize14();
			GenPlanets14();
		}

		void GenerateVersion15()
		{
			GenerateVersion14();
			GenHyperSpaceGate15();
		}

		#endregion

		internal TreeNode TreeNode()
		{
			NodeObject NO = new NodeObject(Generate.diceHelper._Seed, this, EntityTypes.Star, StarType.ToString() + " Class Star");

			if (CelestialObjects.Length > 0)
			{
				TreeNode CB = new TreeNode("Celestial Bodies");
				NO.Node.Nodes.Add(CB);

				foreach (CelestialObject CBT in CelestialObjects)
				{
					CB.Nodes.Add(CBT.TreeNode());
				}
			}

			foreach (Planet p in Planets)
			{
				NO.Node.Nodes.Add(p.TreeNode());
			}

			return NO.Node;
		}
	}
}
