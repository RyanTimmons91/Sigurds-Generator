using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarSystemGeneratorV2.Entity;
using StarSystemGeneratorV2.Generator;

namespace StarSystemGeneratorV2
{
	class StarTypeModifiers
	{
		internal static Dictionary<StarTypes, modifiers> ModList = new Dictionary<StarTypes, modifiers>();

		internal static void Init()
		{
			ModList.Add(StarTypes.G, new modifiers(StarTypes.G, 1, 1, 1));
			ModList.Add(StarTypes.K, new modifiers(StarTypes.K, 0, 1, 1));
			ModList.Add(StarTypes.F, new modifiers(StarTypes.F, 0, 0, 1));

			ModList.Add(StarTypes.A, new modifiers(StarTypes.A, 0, 0, 0));

			ModList.Add(StarTypes.B, new modifiers(StarTypes.B, 0, 0, -1));
			ModList.Add(StarTypes.O, new modifiers(StarTypes.O, 0, -1, -1));
			ModList.Add(StarTypes.M, new modifiers(StarTypes.M, 0, 0, -2));
			ModList.Add(StarTypes.D, new modifiers(StarTypes.D, -1, -1, -2));
		}

		internal static AtmosphereTypes ModifyAtmosphere(Star s, AtmosphereTypes A)
		{
			int AtmosphereMod = ModList[s.StarType].AtmoMod;
			int tempAtmo = (int)A + AtmosphereMod;

			if (tempAtmo < 1) A = AtmosphereTypes.NeverDeveloped;
			else if (tempAtmo > 6) A = AtmosphereTypes.Oxygen;
			else A = (AtmosphereTypes)tempAtmo;

			return A;
		}

		internal static Temperatures ModifyTemperature(Star s, Temperatures T)
		{
			//Console.WriteLine("Original and Star: " + T + " " + s.StarType);

			int TemperatureMod = ModList[s.StarType].TempMod;
			int tempTemp = (int)T + TemperatureMod;

			//Console.WriteLine("Mod and temptemp: " + TemperatureMod + " " + tempTemp);

			if (tempTemp < 1) T = Temperatures.ExtremelyHot;
			else if (tempTemp > 5) T = Temperatures.Temperate;
			else T = (Temperatures)tempTemp;

			//Console.WriteLine("Final Temp: " + T);
			//Console.WriteLine("");

			return T;
		}

		internal static Ecologies ModifyEcology(Star s, Ecologies E)
		{

			int EcologyMod = ModList[s.StarType].EcoMod;
			int tempEco = (int)E + EcologyMod;

			if (tempEco < 1) E = Ecologies.Desert;
			else if (tempEco > 9) E = Ecologies.Varied;
			else E = (Ecologies)tempEco;

			return E;
		}
	}
	class modifiers
	{
		internal StarTypes starType;
		internal int AtmoMod;
		internal int EcoMod;
		internal int TempMod;

		internal modifiers(StarTypes s, int a, int e, int t)
		{
			starType = s;
			AtmoMod = a;
			EcoMod = e;
			TempMod = t;
		}
	}
}
