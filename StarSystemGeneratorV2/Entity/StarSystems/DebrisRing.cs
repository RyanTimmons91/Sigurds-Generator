using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class DebrisRing : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.DebrisRing; }
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, "Deb.Ring " + SizeText);

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

		PlanetMoonSizes Size;
		string SizeText
		{
			get
			{
				if(Size == PlanetMoonSizes.ThinDebrisRing)
				{
					return "Thin";
				}
				else
				{
					return "Thick";
				}
			}
		}

		internal DebrisRing(SystemEntity parent, PlanetMoonSizes size)
		{
			ParentEntity = parent;

			Size = size;

			Generate();
		}

		internal override void Generate()
		{
			GenerateV30();
		}

		internal void GenerateV30()
		{
			for(int i = 0; i < 8; i++)
			{
				ChildEntities.Add(new ResourceSector(this, i));
			}
		}
	}
}
