using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarSystemGeneratorV2.Generator;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	abstract class SystemEntity
	{
		internal List<SystemEntity> StarSystems = new List<SystemEntity>();

		internal abstract EntityTypes EntityType
		{
			get;
		}
		internal abstract NodeObject Node
		{
			get;
		}

		internal SystemEntity ParentEntity = null; //This is the Star System that this Entity Resides in

		internal abstract List<SystemEntity> ChildEntities
		{
			get;
		}

		internal virtual Randomize Generator
		{
			get
			{
				return ParentEntity.Generator;
			}
		}
		internal virtual int VersionNumber
		{
			get
			{
				return ParentEntity.VersionNumber;
			}
		}
		internal virtual int SystemNumber
		{
			get
			{
				return ParentEntity.SystemNumber;
			}
		}

		//Methods
		internal abstract void Generate();
	}
}
