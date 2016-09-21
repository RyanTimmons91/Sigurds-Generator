using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class CelestialObject : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.CelestialObject; }
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, "Cel.Obj. " + Type.ToString() + TextString);

					List<NodeObject> ResourceSectors = new List<NodeObject>();
					List<NodeObject> BaseNodes = new List<NodeObject>();

					foreach (SystemEntity se in ChildEntities)
					{
						if(se.EntityType == EntityTypes.ResourceSector)
						{
							ResourceSectors.Add(se.Node);
						}
						else
						{
							BaseNodes.Add(se.Node);
						}
					}

					if(ResourceSectors.Count > 0)
					{
						TreeNode ResourceNode = no.Node.Nodes.Add("Resource Sectors");

						foreach (NodeObject resourceNode in ResourceSectors)
						{
							ResourceNode.Nodes.Add(resourceNode.Node);
						}
					}

					foreach(NodeObject basenode in BaseNodes)
					{
						no.Node.Nodes.Add(basenode.Node);
					}

					_Node = no;
					return no;
				}
				else return _Node;
			}
		}
		
		CelestialBodyTypes Type;
		string TextString = "";

		internal CelestialObject(SystemEntity parent, CelestialBodyTypes type)
		{
			ParentEntity = parent;
			Type = type;

			if(Type == CelestialBodyTypes.WormholeJunction && VersionNumber >= 30) //We generate the number of wormholes after version 30
			{
				int count = Generator.diceHelper.D20();
				TextString = " " + count;
			}

			switch(Type)
			{
				case CelestialBodyTypes.KuiperBelt:
				case CelestialBodyTypes.OortCloud:
				case CelestialBodyTypes.AsteroidBelt:
				case CelestialBodyTypes.AsteroidCloud:
					Generate();
					break;
			}
		}

		internal override void Generate()
		{
			for (int i = 0; i < 8; i++)
			{
				int ResourceCount = Generator.NumberOfResources();

				for (int i2 = 0; i2 < ResourceCount; i2++)
				{
					DepositTypes dt = Generator.DepositType();
					if (dt != DepositTypes.None)
					{
						ChildEntities.Add(new Resource(this, dt));
					}
				}
			}
		}
	}
}
