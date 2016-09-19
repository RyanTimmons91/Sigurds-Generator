using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class HyperspaceGate : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.HyperspaceGate; }
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, "HSG: " + GateType.ToString());

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
		
		internal HyperSpaceGateTypes GateType;

		internal HyperspaceGate(SystemEntity parent)
		{
			ParentEntity = parent;
			Generate();
		}
		
		internal override void Generate()
		{
			GateType = Generator.HyperSpaceGateStatus();
		}
	}
}
