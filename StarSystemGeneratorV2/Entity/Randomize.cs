using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarSystemGeneratorV2.Entity.StarSystems;

namespace StarSystemGeneratorV2.Generator
{
	class Randomize
	{
		//internal int GenVersion
		//{
		//	get
		//	{
		//		return Properties.Settings.Default.GeneratorVersion;
		//	}
		//}
		internal int _GenVersion = 0;
		int GenVersion
		{
			get
			{
				if (_GenVersion == 0) throw new InvalidOperationException("GenVersion has not been set!");
				return _GenVersion;
			}
		}

		internal DiceHelper diceHelper = new DiceHelper();

		internal List<AtmosphereTypes> UsableAtmospheres = new List<AtmosphereTypes>()
		{
			AtmosphereTypes.Oxygen,
			AtmosphereTypes.OxygenMethane,
			AtmosphereTypes.Nitrogen,
			AtmosphereTypes.Methane,
			AtmosphereTypes.CO2
		};
		
		#region Solar System Type Arrays
		static SRandomize[] StarSystemTypesArray = new SRandomize[]{
			new SRandomize(StarSystemTypes.Single, 10),
			new SRandomize(StarSystemTypes.Binary, 17),
			new SRandomize(StarSystemTypes.Trinary, 20)
		};

		static SRandomize[] HyperSpaceGateTypesArray = new SRandomize[]{
			new SRandomize(HyperSpaceGateTypes.Damaged, 1),
			new SRandomize(HyperSpaceGateTypes.NoGate, 19),
			new SRandomize(HyperSpaceGateTypes.Intact, 20)
		};

		static SRandomize[] StarTypesArray = new SRandomize[]{
			new SRandomize(StarTypes.G, 2),
			new SRandomize(StarTypes.K, 5),
			new SRandomize(StarTypes.F, 8),
			new SRandomize(StarTypes.A, 12),
			new SRandomize(StarTypes.B, 15),
			new SRandomize(StarTypes.O, 17),
			new SRandomize(StarTypes.M, 19),
			new SRandomize(StarTypes.D, 20),
		};

		static SRandomize[] SolarSystemSizeTypesArray = new SRandomize[]{
			new SRandomize(SystemSizeTypes.Small, 2),
			new SRandomize(SystemSizeTypes.Medium, 5),
			new SRandomize(SystemSizeTypes.Large, 10),
			new SRandomize(SystemSizeTypes.Huge, 15),
			new SRandomize(SystemSizeTypes.Gigantic, 18),
			new SRandomize(SystemSizeTypes.Massive, 20),
		};

		static SRandomize[] SystemCelestialBodyCategoriesArray = new SRandomize[]{
			new SRandomize(CelestialBodyCategories.None, 5),
			new SRandomize(CelestialBodyCategories.CloudsAndBelts, 10),
			new SRandomize(CelestialBodyCategories.RoguePlanetaryBodies, 13),
			new SRandomize(CelestialBodyCategories.StarRelatedAnomalies, 15),
			new SRandomize(CelestialBodyCategories.SystemEvents, 17),
			new SRandomize(CelestialBodyCategories.CloudsAndWaves, 19),
			new SRandomize(CelestialBodyCategories.RollTwice, 20),
		};

		static SRandomize[] CloudsAndBeltsArray = new SRandomize[]{
			new SRandomize(CelestialBodyTypes.DustCloud, 4),
			new SRandomize(CelestialBodyTypes.KuiperBelt, 8),
			new SRandomize(CelestialBodyTypes.OortCloud, 12),
			new SRandomize(CelestialBodyTypes.AsteroidBelt, 16),
			new SRandomize(CelestialBodyTypes.AsteroidCloud, 20),
		};

		static SRandomize[] RoguePlanetaryBodyArray = new SRandomize[]{
			new SRandomize(CelestialBodyTypes.Comets, 10),
			new SRandomize(CelestialBodyTypes.RoguePlanetMoon, 14),
			new SRandomize(CelestialBodyTypes.RogueAsteroid, 20),
		};

		static SRandomize[] StarRelatedAnomaliesArray = new SRandomize[]{
			new SRandomize(CelestialBodyTypes.CollapsingToNeutron, 1),
			new SRandomize(CelestialBodyTypes.StarOnVergeSupernova, 2),
			new SRandomize(CelestialBodyTypes.ExcessiveSolarRadiation, 10),
			new SRandomize(CelestialBodyTypes.ExcessiveSolarFlares, 20),
		};

		static SRandomize[] SystemEventsArray = new SRandomize[]{
			new SRandomize(CelestialBodyTypes.BlackHole, 1),
			new SRandomize(CelestialBodyTypes.WhiteHole, 2),
			new SRandomize(CelestialBodyTypes.WormholeJunction, 11),
			new SRandomize(CelestialBodyTypes.RelativityAnomalies, 20),
		};

		static SRandomize[] CloudsAndWavesArray = new SRandomize[]{
			new SRandomize(CelestialBodyTypes.RadiationCloud, 5),
			new SRandomize(CelestialBodyTypes.SolarStorms, 13),
			new SRandomize(CelestialBodyTypes.ElectromagneticCloud, 18),
			new SRandomize(CelestialBodyTypes.GravitationalStressWave, 20),
		};
		#endregion

		#region Planet and Moon Type Arrays
		static SRandomize[] PlanetSizeArray = new SRandomize[]{
			new SRandomize(PlanetMoonSizes.Small, 5),
			new SRandomize(PlanetMoonSizes.Medium, 10),
			new SRandomize(PlanetMoonSizes.Large, 15),
			new SRandomize(PlanetMoonSizes.Giant, 20),
		};
		
		static SRandomize[] GasGiantTypeArray = new SRandomize[]{
			new SRandomize(GasGiantStatus.NotAGasGiant, 15),
			new SRandomize(GasGiantStatus.Standard, 18),
			new SRandomize(GasGiantStatus.IceGiant, 19),
			new SRandomize(GasGiantStatus.Other, 20),
		};

		static SRandomize[] GasGiantAtmospheresArray = new SRandomize[]{
			new SRandomize(AtmosphereTypes.Ammonia, 2),
			new SRandomize(AtmosphereTypes.Helium, 4),
			new SRandomize(AtmosphereTypes.Sodium, 6),
			new SRandomize(AtmosphereTypes.Nitrogen, 8),
			new SRandomize(AtmosphereTypes.Argon, 10),
			new SRandomize(AtmosphereTypes.Water, 12),
			new SRandomize(AtmosphereTypes.Neon, 14),
			new SRandomize(AtmosphereTypes.Hydrogen, 16),
			new SRandomize(AtmosphereTypes.Acetylene, 18),
			new SRandomize(AtmosphereTypes.Acid, 20),
		};

		static SRandomize[] HE3CheckArray = new SRandomize[]{
			new SRandomize(true, 5),
			new SRandomize(false, 20),
		};

		static SRandomize[] PlanetaryUniqueAspectArray = new SRandomize[]{
			new SRandomize(UniquePlanetAspects.Young, 3),
			new SRandomize(UniquePlanetAspects.Old, 6),
			new SRandomize(UniquePlanetAspects.FaultyAxis, 9),
			new SRandomize(UniquePlanetAspects.EllipticalOrbit, 12),
			new SRandomize(UniquePlanetAspects.StrongMagneticField, 14),
			new SRandomize(UniquePlanetAspects.MeteorStorms, 16),
			new SRandomize(UniquePlanetAspects.SuperStorms, 17),
			new SRandomize(UniquePlanetAspects.LastDays, 18),
			new SRandomize(UniquePlanetAspects.BinaryPlanetSystem, 19),
			new SRandomize(UniquePlanetAspects.RollTwice, 20),
		};

		static SRandomize[] MoonSizeArray = new SRandomize[]{
			new SRandomize(PlanetMoonSizes.SmallAsteroid, 5),
			new SRandomize(PlanetMoonSizes.MediumAsteroid, 10),
			new SRandomize(PlanetMoonSizes.LargeAsteroid, 14),
			new SRandomize(PlanetMoonSizes.Luna, 17),
			new SRandomize(PlanetMoonSizes.Small, 19),
			new SRandomize(PlanetMoonSizes.Medium, 20),
		};

		static SRandomize[] PlanetMoonAtmosphereArray = new SRandomize[]{
			new SRandomize(AtmosphereTypes.None, 8),
			new SRandomize(AtmosphereTypes.SulphurDioxide, 9),
			new SRandomize(AtmosphereTypes.Nitrogen, 11),
			new SRandomize(AtmosphereTypes.CO2, 13),
			new SRandomize(AtmosphereTypes.Methane, 14),
			new SRandomize(AtmosphereTypes.OxygenMethane, 15),
			new SRandomize(AtmosphereTypes.Oxygen, 18),
			new SRandomize(AtmosphereTypes.Other, 20),
		};

		static SRandomize[] PlanetMoonOtherAtmosphereArray = new SRandomize[]{
			new SRandomize(AtmosphereTypes.Ammonia, 2),
			new SRandomize(AtmosphereTypes.Helium, 6),
			new SRandomize(AtmosphereTypes.Sodium, 8),
			new SRandomize(AtmosphereTypes.Argon, 10),
			new SRandomize(AtmosphereTypes.Water, 12),
			new SRandomize(AtmosphereTypes.Neon, 14),
			new SRandomize(AtmosphereTypes.Hydrogen, 16),
			new SRandomize(AtmosphereTypes.Acetylene, 18),
			new SRandomize(AtmosphereTypes.Acid, 20),
		};

		static SRandomize[] NoAtmosphereReasonArray = new SRandomize[]{
			new SRandomize(AtmosphereTypes.TooYoung, 5),
			new SRandomize(AtmosphereTypes.NeverDeveloped, 12),
			new SRandomize(AtmosphereTypes.DestroyedNatural, 17),
			new SRandomize(AtmosphereTypes.DestroyedUnnatural, 20),
		};

		static SRandomize[] PlanetMoonTemperatureArray = new SRandomize[]{
			new SRandomize(Temperatures.ExtremelyHot, 4),
			new SRandomize(Temperatures.Hot, 8),
			new SRandomize(Temperatures.Temperate, 12),
			new SRandomize(Temperatures.Cold, 16),
			new SRandomize(Temperatures.ExtremelyCold, 20),
		};

		static SRandomize[] ExtremelyHotEcologyArray = new SRandomize[]{
			new SRandomize(Ecologies.Desert, 5),
			new SRandomize(Ecologies.Jungle, 10),
			new SRandomize(Ecologies.Mountainous, 15),
			new SRandomize(Ecologies.Volcanic, 20),
		};

		static SRandomize[] HotEcologyArray = new SRandomize[]{
			new SRandomize(Ecologies.Desert, 2),
			new SRandomize(Ecologies.Grasslands, 4),
			new SRandomize(Ecologies.Forrest, 6),
			new SRandomize(Ecologies.Jungle, 8),
			new SRandomize(Ecologies.Marshlands, 10),
			new SRandomize(Ecologies.Mountainous, 12),
			new SRandomize(Ecologies.Volcanic, 14),
			new SRandomize(Ecologies.Water, 16),
			new SRandomize(Ecologies.Varied, 20),
		};

		static SRandomize[] TemperateEcologyArray = new SRandomize[]{
			new SRandomize(Ecologies.Desert, 2),
			new SRandomize(Ecologies.Grasslands, 4),
			new SRandomize(Ecologies.Jungle, 6),
			new SRandomize(Ecologies.Marshlands, 8),
			new SRandomize(Ecologies.Forrest, 10),
			new SRandomize(Ecologies.Mountainous, 12),
			new SRandomize(Ecologies.Volcanic, 14),
			new SRandomize(Ecologies.Water, 16),
			new SRandomize(Ecologies.Varied, 20),
		};

		static SRandomize[] ColdEcologyArray = new SRandomize[]{
			new SRandomize(Ecologies.Desert, 3),
			new SRandomize(Ecologies.Grasslands, 6),
			new SRandomize(Ecologies.Marshlands, 9),
			new SRandomize(Ecologies.Forrest, 12),
			new SRandomize(Ecologies.Mountainous, 15),
			new SRandomize(Ecologies.Water, 18),
			new SRandomize(Ecologies.Varied, 20),
		};

		static SRandomize[] ExtremelyColdEcologyArray = new SRandomize[]{
			new SRandomize(Ecologies.Desert, 5),
			new SRandomize(Ecologies.Forrest, 10),
			new SRandomize(Ecologies.Mountainous, 15),
			new SRandomize(Ecologies.Water, 20),
		};
		#endregion

		#region Resource Type Arrays
		static SRandomize[] NumberOfResourcesArray = new SRandomize[]{
			new SRandomize(0, 1),
			new SRandomize(1, 2),
			new SRandomize(2, 4),
			new SRandomize(3, 6),
			new SRandomize(4, 8),
			new SRandomize(5, 10),
			new SRandomize(6, 12),
			new SRandomize(7, 14),
			new SRandomize(8, 16),
			new SRandomize(9, 17),
			new SRandomize(10, 18),
			new SRandomize(11, 19),
			new SRandomize(12, 20),
		};

		static SRandomize[] DepositTypesArray = new SRandomize[] {
			new SRandomize(DepositTypes.None, 4),
			new SRandomize(DepositTypes.Minor, 8),
			new SRandomize(DepositTypes.Moderate, 12),
			new SRandomize(DepositTypes.Major, 16),
			new SRandomize(DepositTypes.Extreme, 20),
		};

		static SRandomize[] ResourceTypesArray = new SRandomize[] {
			new SRandomize(ResourceTypes.NickelIron, 3),
			new SRandomize(ResourceTypes.Copper, 6),
			new SRandomize(ResourceTypes.Silver, 8),
			new SRandomize(ResourceTypes.Gold, 9),
			new SRandomize(ResourceTypes.Platinum, 10),
			new SRandomize(ResourceTypes.Palladium, 11),
			new SRandomize(ResourceTypes.MonoCrystallanium, 12),
			new SRandomize(ResourceTypes.OtherPreciousMetals, 13),
			new SRandomize(ResourceTypes.OtherHeavyMetals, 14),
			new SRandomize(ResourceTypes.Gemstones, 16),
			new SRandomize(ResourceTypes.OtherMinerals, 18),
			new SRandomize(ResourceTypes.OtherCrystals, 20),
		};
		#endregion

		#region Civilization Type Arrays
		#region OLDER ROLLS DO NOT EDIT
		static SRandomize[] LivingCivilizationArray17 = new SRandomize[] {
			new SRandomize(true, 1),
			new SRandomize(false, 20),
		};

		static SRandomize[] LostCivilizationArray17 = new SRandomize[] {
			new SRandomize(true, 2),
			new SRandomize(false, 20),
		};
		#endregion

		static SRandomize[] LivingCivilizationArray18 = new SRandomize[] {
			new SRandomize(true, 1),
			new SRandomize(false, 100),
		};
		
		static SRandomize[] LostCivilizationArray18 = new SRandomize[] {
			new SRandomize(true, 3),
			new SRandomize(false, 100),
		};

		static SRandomize[] TechLevelArray = new SRandomize[] {
			new SRandomize(TechLevels.PreHistory, 1),
			new SRandomize(TechLevels.StoneAge, 2),
			new SRandomize(TechLevels.BronzeAge, 3),
			new SRandomize(TechLevels.IronAge, 4),
			new SRandomize(TechLevels.Medieval, 5),
			new SRandomize(TechLevels.Renaissance, 6),
			new SRandomize(TechLevels.IndustrialRevolution, 8),
			new SRandomize(TechLevels.AgeOfAir, 10),
			new SRandomize(TechLevels.PreModernEra, 12),
			new SRandomize(TechLevels.InformationAge, 14),
			new SRandomize(TechLevels.SpaceAge, 16),
			new SRandomize(TechLevels.ColonizationAge, 18),
			new SRandomize(TechLevels.HyperspaceRevolution, 20),
		};

		
		static SRandomize[] GasGiantTechLevelArray = new SRandomize[] {
			new SRandomize(TechLevels.SpaceAge, 7),
			new SRandomize(TechLevels.ColonizationAge, 14),
			new SRandomize(TechLevels.HyperspaceRevolution, 20),
		};

		static SRandomize[] GovernmentTypeArray = new SRandomize[] {
			new SRandomize(GovTypes.Ethnarch, 2),
			new SRandomize(GovTypes.ElectiveMonarchy, 5),
			new SRandomize(GovTypes.Feudalism, 10),
			new SRandomize(GovTypes.Mercenary, 15),
			new SRandomize(GovTypes.Dictatorship, 20),
			new SRandomize(GovTypes.MilitaryRule, 25),
			new SRandomize(GovTypes.Democracy, 30),
			new SRandomize(GovTypes.Republic, 45),
			new SRandomize(GovTypes.Corporate, 60),
			new SRandomize(GovTypes.Socialistic, 65),
			new SRandomize(GovTypes.Communistic, 70),
			new SRandomize(GovTypes.ConstitutionalMonarchy, 75),
			new SRandomize(GovTypes.AbsoluteMonarchy, 80),
			new SRandomize(GovTypes.Theocracy, 85),
			new SRandomize(GovTypes.Piracy, 90),
			new SRandomize(GovTypes.Oligarchy, 95),
			new SRandomize(GovTypes.FeudalMonarchy, 98),
			new SRandomize(GovTypes.TetrarchMonarchy, 100),
		};

		static SRandomize[] EconomyTypeArray = new SRandomize[] {
			new SRandomize(EconomyTypes.NewlyColonized, 1),
			new SRandomize(EconomyTypes.Mining, 2),
			new SRandomize(EconomyTypes.Agriculture, 3),
			new SRandomize(EconomyTypes.Colonization, 4),
			new SRandomize(EconomyTypes.TradeCommerce, 5),
			new SRandomize(EconomyTypes.Military, 6),
			new SRandomize(EconomyTypes.ResearchAndDevelopment, 7),
			new SRandomize(EconomyTypes.Construction, 8),
			new SRandomize(EconomyTypes.ArcheologicalSite, 9),
			new SRandomize(EconomyTypes.ResortWorld, 10),

			new SRandomize(EconomyTypes.RollTwo, 11),
			new SRandomize(EconomyTypes.RollThree, 12),
			new SRandomize(EconomyTypes.RollFour, 13),
			new SRandomize(EconomyTypes.RollFive, 14),
			new SRandomize(EconomyTypes.RollSix, 15),
			new SRandomize(EconomyTypes.RollSeven, 16),
			new SRandomize(EconomyTypes.RollEight, 17),
			new SRandomize(EconomyTypes.RollNine, 18),

			new SRandomize(EconomyTypes.Poor, 20),
		};

		static SRandomize[] EconomyTypeArray2 = new SRandomize[] {
			new SRandomize(EconomyTypes.Mining, 1),
			new SRandomize(EconomyTypes.Agriculture, 2),
			new SRandomize(EconomyTypes.Colonization, 3),
			new SRandomize(EconomyTypes.TradeCommerce, 4),
			new SRandomize(EconomyTypes.Military, 5),
			new SRandomize(EconomyTypes.ResearchAndDevelopment, 6),
			new SRandomize(EconomyTypes.Construction, 7),
			new SRandomize(EconomyTypes.ArcheologicalSite, 8),
			new SRandomize(EconomyTypes.ResortWorld, 9),
		};

		static SRandomize[] ColonyStatusArray = new SRandomize[] {
			new SRandomize(ColonyStatus.ColonyFound, 1),
			new SRandomize(ColonyStatus.StillLooking, 2),
			new SRandomize(ColonyStatus.Missing, 3),
			new SRandomize(ColonyStatus.Destroyed, 4),
		};
		#endregion

		#region Celestial Object Arrays
		//TODO Ask about rolls for rogue planet / moon numbers!
		static SRandomize[] RoguePlanetMoonArray = new SRandomize[]{
			new SRandomize(PlanetMoonSizes.Luna, 1),
			new SRandomize(PlanetMoonSizes.Small, 5),
			new SRandomize(PlanetMoonSizes.Medium, 10),
			new SRandomize(PlanetMoonSizes.Large, 15),
			new SRandomize(PlanetMoonSizes.Giant, 20),
		};

		//Ask about rolls for rogue Asteroid numbers!
		static SRandomize[] RogueAsteroidArray = new SRandomize[]{
			new SRandomize(PlanetMoonSizes.SmallAsteroid, 5),
			new SRandomize(PlanetMoonSizes.MediumAsteroid, 10),
			new SRandomize(PlanetMoonSizes.LargeAsteroid, 20),
		};

		#endregion

		//Generators

		#region Solar System Generators
		internal StarSystemTypes StarSystemType()
		{
#if DEBUG
			LogF.WriteLine("Get Star System Type");
#endif

			return GenerateRandom(StarSystemTypesArray);
		}

		internal HyperSpaceGateTypes HyperSpaceGateStatus()
		{
#if DEBUG
			LogF.WriteLine("Gen Hyperspace Gate"); 
#endif

			return GenerateRandom(HyperSpaceGateTypesArray);
		}

		internal StarTypes StarType()
		{
#if DEBUG
			LogF.WriteLine("Gen Star Type"); 
#endif

			return GenerateRandom(StarTypesArray);
		}

		internal SystemSizeTypes SystemSize()
		{
#if DEBUG
			LogF.WriteLine("Gen System Size"); 
#endif

			return GenerateRandom(SolarSystemSizeTypesArray);
		}

		internal int NumberOfPlanets(SystemSizeTypes SystemSize)
		{
#if DEBUG
			LogF.WriteLine("Gen Number of Plnaets for " + SystemSize.ToString()); 
#endif

			switch (SystemSize)
			{
				case SystemSizeTypes.Medium:
					return diceHelper.D6() + 4;
				case SystemSizeTypes.Large:
					return diceHelper.D8() + 6;
				case SystemSizeTypes.Huge:
					return diceHelper.D10() + 8;
				case SystemSizeTypes.Gigantic:
					return diceHelper.D12() + 10;
				case SystemSizeTypes.Massive:
					return diceHelper.D20() + 12;
				default:
					return diceHelper.D4();
			}
		}

		internal CelestialBodyCategories CelestialBodyCategory()
		{
#if DEBUG
			LogF.WriteLine("Gen Celestial Body Category"); 
#endif

			return GenerateRandom(SystemCelestialBodyCategoriesArray);
		}

		internal CelestialBodyTypes[] CelestialBodies()
		{
#if DEBUG
			LogF.WriteLine("Gen Celestial Bodies"); 
#endif

			List<CelestialBodyTypes> RandomCelestialBodies = new List<CelestialBodyTypes>();

			CelestialBodyCategories CBC = CelestialBodyCategory();

			switch (CBC)
			{
				case CelestialBodyCategories.None:
					break;
				case CelestialBodyCategories.CloudsAndBelts:
					RandomCelestialBodies.Add(GenerateRandom(CloudsAndBeltsArray));
					break;
				case CelestialBodyCategories.RoguePlanetaryBodies:
					RandomCelestialBodies.Add(GenerateRandom(RoguePlanetaryBodyArray));
					break;
				case CelestialBodyCategories.StarRelatedAnomalies:
					RandomCelestialBodies.Add(GenerateRandom(StarRelatedAnomaliesArray));
					break;
				case CelestialBodyCategories.SystemEvents:
					RandomCelestialBodies.Add(GenerateRandom(SystemEventsArray));
					break;
				case CelestialBodyCategories.CloudsAndWaves:
					RandomCelestialBodies.Add(GenerateRandom(CloudsAndWavesArray));
					break;
				case CelestialBodyCategories.RollTwice:
					RandomCelestialBodies.AddRange(CelestialBodies());
					RandomCelestialBodies.AddRange(CelestialBodies());
					break;
			}

			return RandomCelestialBodies.ToArray();
		}
#endregion

		#region Planet and Moon Generators
		internal PlanetMoonSizes PlanetSize()
		{
#if DEBUG
			LogF.WriteLine("Gen Planet Size"); 
#endif

			return GenerateRandom(PlanetSizeArray);
		}
		internal PlanetMoonSizes MoonSize(PlanetMoonSizes ParentSize)
		{
#if DEBUG
			LogF.WriteLine("Gen Moon Size"); 
#endif

			PlanetMoonSizes RandomSize = GenerateRandom(MoonSizeArray); //Pick a random moon size

			if (ParentSize - RandomSize < 2) RandomSize = ParentSize - 2; //If we are not at least two planet sizes away we need to jump to two planet sizes below the host

			return RandomSize;
		}

		internal GasGiantStatus GasGiantCheck()
		{
#if DEBUG
			LogF.WriteLine("Gas Giant Check"); 
#endif

			return GenerateRandom(GasGiantTypeArray);
		}
		internal AtmosphereTypes[] GasGiantOtherAtmospheres()
		{
#if DEBUG
			LogF.WriteLine("Gen Gas Giant Other Atmospheres"); 
#endif

			List<AtmosphereTypes> Atmospheres = new List<AtmosphereTypes>();

			AtmosphereTypes A2 = AtmosphereTypes.None;

			for (int i = 0; i < 3; i++)
			{
				do
				{
					A2 = GenerateRandom(GasGiantAtmospheresArray);
				} while (Atmospheres.Contains(A2));

				if (A2 == AtmosphereTypes.Helium)
				{
					if (GenerateRandom(HE3CheckArray))
						A2 = AtmosphereTypes.HE3;
				}

				Atmospheres.Add(A2);
			}

			return Atmospheres.ToArray();
		}

		internal UniquePlanetAspects[] UniquePlanetaryAspects()
		{
#if DEBUG
			LogF.WriteLine("Gen unique Aspects"); 
#endif

			List<UniquePlanetAspects> UPAList = new List<UniquePlanetAspects>();

			UniquePlanetAspects UPA = GenerateRandom(PlanetaryUniqueAspectArray);

			if (diceHelper.D20() > 5)
			{
				return UPAList.ToArray(); //No Unique aspects on a D20 roll greater than 5
			}

			if (UPA == UniquePlanetAspects.RollTwice)
			{
				UPAList.AddRange(UniquePlanetaryAspects());
				UPAList.AddRange(UniquePlanetaryAspects());
			}
			else
			{
				UPAList.Add(UPA);
			}

			return UPAList.ToArray();
		}

		internal AtmosphereTypes PlanetAtmosphere()
		{
#if DEBUG
			LogF.WriteLine("Gen Planet Atmosphere"); 
#endif

			AtmosphereTypes AT = GenerateRandom(PlanetMoonAtmosphereArray);

			if (AT == AtmosphereTypes.None)
			{
				AT = GenerateRandom(NoAtmosphereReasonArray);
			}
			else if (AT == AtmosphereTypes.Other)
			{
				AT = GenerateRandom(PlanetMoonOtherAtmosphereArray);

				if (AT == AtmosphereTypes.Helium)
				{
					if (GenerateRandom(HE3CheckArray)) AT = AtmosphereTypes.HE3;
				}
			}

			return AT;
		}

		internal Temperatures Temperature()
		{
#if DEBUG
			LogF.WriteLine("Gen temperature"); 
#endif

			return GenerateRandom(PlanetMoonTemperatureArray);
		}

		internal Ecologies Ecology(Temperatures temp)
		{
#if DEBUG
			LogF.WriteLine("Gen Ecology for " + temp.ToString()); 
#endif

			switch (temp)
			{
				case Temperatures.ExtremelyHot:
					return GenerateRandom(ExtremelyHotEcologyArray);
				case Temperatures.Hot:
					return GenerateRandom(HotEcologyArray);
				case Temperatures.Temperate:
					return GenerateRandom(TemperateEcologyArray);
				case Temperatures.Cold:
					return GenerateRandom(ColdEcologyArray);
				case Temperatures.ExtremelyCold:
					return GenerateRandom(ExtremelyColdEcologyArray);
				default:
					return Ecologies.None;
			}
		}

		#endregion

		#region Resource Generators
		internal int NumberOfResources()
		{
#if DEBUG
			LogF.WriteLine("Gen Number of Resources"); 
#endif

			return GenerateRandom(NumberOfResourcesArray);
		}

		internal DepositTypes DepositType()
		{
#if DEBUG
			LogF.WriteLine("Gen Deposit Type"); 
#endif

			return GenerateRandom(DepositTypesArray);
		}

		internal ResourceTypes ResourceType()
		{
#if DEBUG
			LogF.WriteLine("Gen Resource Types"); 
#endif

			return GenerateRandom(ResourceTypesArray);
		}
		#endregion

		#region Civilization Generators
		internal bool LivingCivilizationCheck()
		{
#if DEBUG
			LogF.WriteLine("Living Civ Check V" + GenVersion); 
#endif

			switch (GenVersion)
			{
				case 14:
				case 15:
				case 16:
				case 17:
					return GenerateRandom(LivingCivilizationArray17);
				case 18:
				default: //default to newer generator
					return GenerateRandom(LivingCivilizationArray18);
			}

		}

		internal bool LostCivilizationCheck()
		{
#if DEBUG
			LogF.WriteLine("Lost Civ Check V" + GenVersion); 
#endif

			switch (GenVersion)
			{
				case 14:
				case 15:
				case 16:
				case 17:
					return GenerateRandom(LostCivilizationArray17);
				case 18:
				default: //default to newer generator
					return GenerateRandom(LostCivilizationArray18);
			}
		}

		internal TechLevels CivilizationTechLevel()
		{
#if DEBUG
			LogF.WriteLine("Civ Tech"); 
#endif

			return GenerateRandom(TechLevelArray);
		}

		internal TechLevels GasGiantLostCivilizationTechLevel()
		{
#if DEBUG
			LogF.WriteLine("Gas Giant Lost Civ"); 
#endif

			return GenerateRandom(GasGiantTechLevelArray);
		}



		//TOOD Need to do additional Colony Generation Methods

		#endregion

		dynamic GenerateRandom(SRandomize[] array)
		{
			int DieSize = array[array.Length-1].MaxDieRoll;

			int DieRoll = diceHelper.Roll(DieSize);

			SRandomize tempResult = new SRandomize(null, 0);
			SRandomize CValue;

			for (int i = 0; i < array.Length; i++)
			{
				CValue = array[i];
				if(DieRoll == CValue.MaxDieRoll) return CValue.Value;
				if (DieRoll > CValue.MaxDieRoll) continue;

				if (DieRoll < CValue.MaxDieRoll && (CValue.MaxDieRoll < tempResult.MaxDieRoll || tempResult.MaxDieRoll == 0))
				{
					//Console.WriteLine("Debug 2");
					tempResult = CValue;
				}
			}

			return tempResult.Value;
		}

		internal Randomize()
		{
			diceHelper = new DiceHelper();
		}
		internal Randomize(int seed)
		{
			diceHelper = new DiceHelper(seed);
		}
	}
	class SRandomize
	{
		public dynamic Value; //The Value within the enum of this type
		public int MaxDieRoll; //The maximum number that can be rolled on a d20 to get this result

		public SRandomize(dynamic value, int maxDieRoll)
		{
			Value = value;
			MaxDieRoll = maxDieRoll;
		}
	}
}
