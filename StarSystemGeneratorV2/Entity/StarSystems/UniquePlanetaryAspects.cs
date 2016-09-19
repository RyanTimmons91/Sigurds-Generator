using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class UniquePlanetaryAspects : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.UniquePlanetaryAspect; }
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get 
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, "Aspect " + Aspect.ToString());

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

		UniquePlanetAspects Aspect;

		internal UniquePlanetaryAspects(SystemEntity parent, UniquePlanetAspects a)
		{
			ParentEntity = parent;
			Aspect = a;
		}

		internal override void Generate()
		{
			throw new NotImplementedException();
		}
	}
}
