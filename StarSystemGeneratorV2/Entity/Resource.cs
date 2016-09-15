using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSystemGeneratorV2.Entity
{
	class Resource
	{
		internal ResourceTypes ResourceType;
		internal DepositTypes DepositSize;

		internal Resource(ResourceTypes rType, DepositTypes dType)
		{
			ResourceType = rType;
			DepositSize = dType;
		}

		public override string ToString()
		{
			return DepositSize + " " + ResourceType;
		}
	}
}
