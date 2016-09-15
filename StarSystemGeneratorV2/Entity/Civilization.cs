using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSystemGeneratorV2.Entity
{
	class Civilization
	{
		internal static Civilization NoCiv = new Civilization(CivilizationTypes.None, TechLevels.None);

		internal CivilizationTypes CivilizationType;
		internal TechLevels TechLevel;

		internal Civilization(CivilizationTypes civType, TechLevels tech)
		{
			CivilizationType = civType;
			TechLevel = tech;
		}

		public override string ToString()
		{
			return TechLevel.ToString();
		}
	}
}
