using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	public enum HighlightTypes
	{
		None = 0,
		ReadyForColonization = 1,
		LostColony = 2,
	}

	public enum EntityTypes
	{
		NoShow,

		StarSystem,
		Star,
		Planet,
		GasGiant,
		Moon,
		DebrisRing,
		ResourceSector,

		Resource,

		UniquePlanetaryAspect,
		CelestialObject,

		Civilization,

		HyperspaceGate,
	}

	#region Solar System
	public enum StarSystemTypes
	{
		Single = 1,
		Binary = 2,
		Trinary = 3
	}
	public enum HyperSpaceGateTypes
	{
		Damaged = 1,
		NoGate = 2,
		Intact = 3
	}
	public enum StarTypes
	{
		G = 1,
		K = 2,
		F = 3,
		A = 4,
		B = 5,
		O = 6,
		M = 7,
		D = 8
	}
	public enum SystemSizeTypes
	{
		Small = 1,
		Medium = 2,
		Large = 3,
		Huge = 4,
		Gigantic = 5,
		Massive = 6
	}
	public enum CelestialBodyCategories
	{
		None = 1,
		CloudsAndBelts = 2,
		RoguePlanetaryBodies = 3,
		StarRelatedAnomalies = 4,
		SystemEvents = 5,
		CloudsAndWaves = 6,
		RollTwice = 7
	}
	public enum CelestialBodyTypes
	{
		None = 1,

		//Clouds and Belts
		DustCloud = 2,
		KuiperBelt = 3,
		OortCloud = 4,
		AsteroidBelt = 5,
		AsteroidCloud = 6,

		//Rogue Planetary Bodies
		Comets = 7,
		RoguePlanetMoon = 8,
		RogueAsteroid = 9,

		//Star Related Anomalies
		CollapsingToNeutron = 10,
		StarOnVergeSupernova = 11,
		ExcessiveSolarRadiation = 12,
		ExcessiveSolarFlares = 13,

		//System Events
		BlackHole = 14,
		WhiteHole = 15,
		WormholeJunction = 16,
		RelativityAnomalies = 17,

		//Clouds and Waves
		RadiationCloud = 18,
		SolarStorms = 19,
		ElectromagneticCloud = 20,
		GravitationalStressWave = 21
	}
	#endregion

	#region Planets and Moons
	public enum PlanetMoonSizes
	{
		ThinDebrisRing = 1,
		ThickDebrisRing = 2,

		SmallAsteroid = 3,
		MediumAsteroid = 4,
		LargeAsteroid = 5,
		Luna = 6,
		Small = 7,
		Medium = 8,
		Large = 9,
		Giant = 10,
	}
	public enum GasGiantStatus
	{
		NotAGasGiant = 1,
		Standard = 2,
		IceGiant = 3,
		Other = 4,
	}

	public enum AtmosphereTypes
	{
		None = 255, //Not actually usable, just a placeholder for code execution later!
		Other = 254, //Not actually usable, just a placeholder for code execution later!

		HE3 = 200,

		SulphurDioxide = 1,
		Methane = 2,
		Nitrogen = 3,
		CO2 = 4,
		OxygenMethane = 5,
		Oxygen = 6,

		TooYoung = 7,
		NeverDeveloped = 8,
		DestroyedNatural = 9,
		DestroyedUnnatural = 10,

		Ammonia = 21,
		Helium = 22,
		Sodium = 23,
		Argon = 24,
		Water = 25,
		Neon = 26,
		Hydrogen = 27,
		Acetylene = 28,
		Acid = 29
	}
	
	public enum UniquePlanetAspects
	{
		RollTwice = 255,

		Young = 1,
		Old = 2,
		FaultyAxis = 3,
		EllipticalOrbit = 4,
		StrongMagneticField = 5,
		MeteorStorms = 6,
		SuperStorms = 7,
		LastDays = 8,
		BinaryPlanetSystem = 9
	}
	public enum Temperatures
	{
		None = 0, //Not Rollable, only valid if no atmosphere or atmosphere invalid

		ExtremelyHot = 1,
		ExtremelyCold = 2,
		Cold = 3,
		Hot = 4,
		Temperate = 5, 
	}
	public enum Ecologies
	{
		None = 0, //Not Rollable, only valid if no atmosphere or atmosphere invalid
		Desert = 1,
		Mountainous = 2,
		Volcanic = 3,
		Water = 4,
		Marshlands = 5,
		Jungle = 6,
		Forrest = 7,
		Grasslands = 8,
		Varied = 9
	}
	#endregion

	#region Civilizations
	public enum CivilizationTypes
	{
		None = 1,
		Living = 2,
		Lost = 3
	}
	public enum TechLevels
	{
		None = 255,

		PreHistory = 1,
		StoneAge = 2,
		BronzeAge = 3,
		IronAge = 4,
		Medieval = 5,
		Renaissance = 6,
		IndustrialRevolution = 7,
		AgeOfAir = 8,
		PreModernEra = 9,
		InformationAge = 10,
		SpaceAge = 11,
		ColonizationAge = 12,
		HyperspaceRevolution = 13
	}
	public enum GovTypes
	{
		Ethnarch = 1,
		ElectiveMonarchy = 2,
		Feudalism = 3,
		Mercenary = 4,
		Dictatorship = 5,
		MilitaryRule = 6,
		Democracy = 7,
		Republic = 8,
		Corporate = 9,
		Socialistic = 10,
		Communistic = 11,
		ConstitutionalMonarchy = 12,
		AbsoluteMonarchy = 13,
		Theocracy = 14,
		Piracy = 15,
		Oligarchy = 16,
		FeudalMonarchy = 17,
		TetrarchMonarchy = 18
	}
	public enum EconomyTypes
	{
		NewlyColonized = 1,
		Mining = 2,
		Agriculture = 3,
		Colonization = 4,
		TradeCommerce = 5,
		Military = 6,
		ResearchAndDevelopment = 7,
		Construction = 8,
		ArcheologicalSite = 9,
		ResortWorld = 10,

		RollTwo = 200,
		RollThree = 201,
		RollFour = 202,
		RollFive = 203,
		RollSix = 204,
		RollSeven = 205,
		RollEight = 206,
		RollNine = 207,

		Poor = 11
	}
	public enum ColonyStatus
	{
		ColonyFound = 1,
		StillLooking = 2,
		Missing = 3,
		Destroyed = 4
	}
	#endregion

	#region Resources
	public enum DepositTypes
	{
		None = 1,
		Minor = 2,
		Moderate = 3,
		Major = 4,
		Extreme = 5
	}
	public enum ResourceTypes
	{
		NickelIron = 1,
		Copper = 2,
		Silver = 3,
		Gold = 4,
		Platinum = 5,
		Palladium = 6,
		MonoCrystallanium = 7,
		OtherPreciousMetals = 8,
		OtherHeavyMetals = 9,
		Gemstones = 10,
		OtherMinerals = 11,
		OtherCrystals = 12
	}
	#endregion
}
