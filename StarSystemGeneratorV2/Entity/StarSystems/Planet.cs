using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class Planet : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.Planet; }
		}
		internal override NodeObject Node
		{
			get { return new NodeObject(this, "Planet", Color.Empty); }
		}

		List<SystemEntity> _ChildEntities = new List<SystemEntity>();
		internal override List<SystemEntity> ChildEntities
		{
			get
			{
				return _ChildEntities;
			}
		}

		internal Planet(SystemEntity parent)
		{
			Console.WriteLine("Planet Gen");
			ParentEntity = parent;
		}

		internal override void Generate()
		{
			throw new NotImplementedException();
		}
	}
}
