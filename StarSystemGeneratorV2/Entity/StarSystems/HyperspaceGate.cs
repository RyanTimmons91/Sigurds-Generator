using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class HyperspaceGate : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.HyperspaceGate; }
		}
		internal override NodeObject Node
		{
			get
			{
				return new NodeObject(this, "HSG: " + GateType.ToString(), Color.Empty);
			}
		}

		List<SystemEntity> _ChildEntities = new List<SystemEntity>();
		internal override List<SystemEntity> ChildEntities
		{
			get
			{
				return _ChildEntities;
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
