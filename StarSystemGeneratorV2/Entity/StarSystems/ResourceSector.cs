using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class ResourceSector : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.ResourceSector; }
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, "Sector " + SectorNumber);

					foreach (SystemEntity se in ChildEntities)
					{
						no.Node.Nodes.Add(se.Node.Node);
					}

					_Node = no;
					return no;
				}
				else return _Node;
			}
		}

		internal int SectorNumber;

		internal ResourceSector(SystemEntity parent, int number)
		{
			ParentEntity = parent;

			SectorNumber = number;

			Generate();
		}

		internal override void Generate()
		{
			int NumberOfResource = Generator.NumberOfResources();

			for(int i = 0; i < NumberOfResource; i++)
			{
				DepositTypes DT = Generator.DepositType();
				if (DT == DepositTypes.None) continue;

				ChildEntities.Add(new Resource(this, DT));
			}
		}
	}
}
