using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class Civilization : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.Civilization; }
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, "Civ. " + CivType.ToString() + " " + CivilizationTechLevel + " " + IntactPercent);

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

		internal CivilizationTypes CivType;
		
		internal TechLevels CivilizationTechLevel;
		internal int IntactPercent = 100;

		internal Civilization(SystemEntity parent, CivilizationTypes civtype, TechLevels tech)
		{
			ParentEntity = parent;

			CivType = civtype;

			if(CivType == CivilizationTypes.Lost)
			{
				IntactPercent = Generator.diceHelper.Percentage();
			}

			CivilizationTechLevel = tech;
		}

		internal override void Generate()
		{
			throw new NotImplementedException();
		}
	}
}
