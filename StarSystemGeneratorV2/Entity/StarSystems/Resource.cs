using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class Resource : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.Resource; }
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, "Res. " + DepositSize.ToString() + " " + ResourceType.ToString());

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

		DepositTypes DepositSize;
		ResourceTypes ResourceType;

		internal Resource(SystemEntity parent, DepositTypes dt)
		{
			ParentEntity = parent;

			DepositSize = dt;
			ResourceType = Generator.ResourceType();
		}

		internal override void Generate()
		{
			throw new NotImplementedException();
		}
	}
}
