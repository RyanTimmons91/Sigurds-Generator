using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StarSystemGeneratorV2.Generator;

namespace StarSystemGeneratorV2.Entity
{
	class CelestialObject
	{
		internal Randomize Generate;

		internal CelestialBodyTypes CelestialBody;

		internal List<Resource[]> ResourceSectors = new List<Resource[]>();

		PlanetMoonSizes Size;

		internal CelestialObject(Randomize gen, CelestialBodyTypes CBT)
		{
			Generate = gen;

			CelestialBody = CBT;

			switch(CBT)
			{
				//case CelestialBodyTypes.DustCloud:
				case CelestialBodyTypes.KuiperBelt:
				case CelestialBodyTypes.OortCloud:
				case CelestialBodyTypes.AsteroidBelt:
				case CelestialBodyTypes.AsteroidCloud:
					GenerateCelestialCloudBelt();
					break;
				//case CelestialBodyTypes.RoguePlanetMoon:
				//case CelestialBodyTypes.RogueAsteroid:
			}
		}

		internal void GenerateCelestialCloudBelt()
		{
			Resource[] resources;

			for (int i = 0; i < 8; i++)
			{
				resources = new Resource[Generate.NumberOfResources()];

				for (int i2 = 0; i2 < resources.Length; i2++)
				{
					DepositTypes dt = Generate.DepositType();
					if (dt != DepositTypes.None)
					{
						resources[i2] = new Resource(Generate.ResourceType(), dt);
					}
				}

				ResourceSectors.Add(resources);
			}
		}

		internal TreeNode TreeNode()
		{
			EntityTypes ET = EntityTypes.NoShow;

			switch (CelestialBody)
			{
				//case CelestialBodyTypes.DustCloud: //Cloud of dust, may contain resources but might also be hard to gather
				case CelestialBodyTypes.KuiperBelt: //Belt of objects out in the system
				case CelestialBodyTypes.OortCloud: //Cloud of comets and asteroids further out in the system
				case CelestialBodyTypes.AsteroidBelt: //2d Ring of asteroids in the System
				case CelestialBodyTypes.AsteroidCloud: //3d Sphere of asteroids in the system
					ET = EntityTypes.CelestialObject;
					break;
				//case CelestialBodyTypes.RoguePlanetMoon: //Rogue planet or moon
				//case CelestialBodyTypes.RogueAsteroid: //Smaller rogue object

			}

			NodeObject NO = new NodeObject(Generate.diceHelper._Seed, this, ET, CelestialBody.ToString());

			return NO.Node;
		}
	}
}
