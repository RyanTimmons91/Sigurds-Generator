using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class CelestialObject : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.CelestialObject; }
		}
		internal override NodeObject Node
		{
			get { return new NodeObject(this, Type.ToString() + TextString, Color.Empty); }
		}

		List<SystemEntity> _ChildEntities = new List<SystemEntity>();
		internal override List<SystemEntity> ChildEntities
		{
			get
			{
				return _ChildEntities;
			}
		}

		CelestialBodyTypes Type;
		string TextString = "";

		internal CelestialObject(SystemEntity parent, CelestialBodyTypes type)
		{
			ParentEntity = parent;
			Type = type;

			if(Type == CelestialBodyTypes.WormholeJunction && VersionNumber >= 30)
			{
				int count = Generator.diceHelper.D20();
				TextString = count + "";
			}
		}

		internal override void Generate()
		{
			throw new NotImplementedException();
		}
	}
}
