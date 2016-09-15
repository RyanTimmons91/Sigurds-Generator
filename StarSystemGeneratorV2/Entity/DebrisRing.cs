using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StarSystemGeneratorV2.Generator;

namespace StarSystemGeneratorV2.Entity
{
	class DebrisRing
	{
		internal Randomize Generate;

		internal PlanetMoonSizes Size;

		internal List<Resource[]> ResourceSectors = new List<Resource[]>();

		internal DebrisRing(Randomize Gen, PlanetMoonSizes size)
		{
			Generate = Gen;

			Size = size;
			
			Resource[] resources;

			for(int i = 0; i < 8; i++)
			{
				resources = new Resource[Generate.NumberOfResources()];

				for (int i2 = 0; i2 < resources.Length; i2++)
				{
					DepositTypes dt = Generate.DepositType();
					if(dt != DepositTypes.None)
					{
						resources[i2] = new Resource(Generate.ResourceType(), dt);
					}
				}

				ResourceSectors.Add(resources);
			}
		}

		internal TreeNode TreeNode()
		{
			NodeObject NO = new NodeObject(Generate.diceHelper._Seed, this, EntityTypes.DebrisRing, Size.ToString());

			return NO.Node;
		}
	}
}
