using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarSystemGeneratorV2
{
	class VehicleMaterialWeightCost
	{
		internal static List<VehicleMaterial> VehicleMaterials = new List<VehicleMaterial>()
		{
			new VehicleMaterial(0, "Semi-Liquid Nanno-Carbons", .225m, 100, true, "Water Vehicles", 3),
			new VehicleMaterial(1, "Nanno-Pore", .9m, 110, false, "Water Vehicles", 4),
			new VehicleMaterial(2, "Nanno-Tex", .3m, 155, false, "Any Vehicles", 5),
			new VehicleMaterial(3, "Laminated Steel", 6.25m, 50, false, "Civilian Vehicles", 6),
			new VehicleMaterial(4, "Ceramo-Plast", 3, 180, false, "Civilian Vehicles", 7),
			new VehicleMaterial(5, "Flexi-Plasti-Steel", 2.8m, 230, false, "Civilian Vehicles", 8),
			new VehicleMaterial(6, "Carbon Fiber", 1.7m, 245, false, "Police/Security Vehicles", 9),
			new VehicleMaterial(7, "Plasti-Steel", 3.9m, 300, false, "Police/Security Vehicles", 10),
			new VehicleMaterial(8, "Nanno-Carbon Fiber Weave", 3.8m, 315, false, "Police/Security Vehicles", 11),
			new VehicleMaterial(9, "Ceramo-Steel", 4.5m, 345, false, "Military Vehicles", 12),
			new VehicleMaterial(10, "Lightweight Titanium", 5, 400, false, "Military Vehicles", 13),
			new VehicleMaterial(11, "Dimonotanium-Ceramatite", 5.5m, 450, false, "Military Vehicles", 15),
			new VehicleMaterial(12, "Dibitanium Ceramatite", 7.5m, 600, false, "Military Vehicles", 20),
			new VehicleMaterial(13, "Ditritanium Ceramatite", 10, 750, false, "Military Vehicles", 25),
		};


	}
	struct VehicleMaterial
	{
		int ID;
		internal string name;
		internal bool isCoating;

		internal decimal weight; //In Metric Tons
		internal int cost;
		internal string use;
		internal int DD;

		internal VehicleMaterial(int id, string n, decimal w, int c, bool isC, string u, int d)
		{
			ID = id;
			name = n;
			weight = w;
			cost = c;
			isCoating = isC;
			use = u;
			DD = d;
		}

		public int GetID()
		{
			return ID;
		}

		public override string ToString()
		{
			return name;
		}
	}

	class ArmorMaterialWeightCost
	{
		internal static ArmorMaterial nameFind(string name)
		{
			foreach(ArmorMaterial am in ArmorMaterials)
			{
				if (am.Name == name) return am;
			}
			return new ArmorMaterial();
		}

		internal static List<ArmorMaterial> ArmorMaterials = new List<ArmorMaterial>()
		{
			new ArmorMaterial(0, "Mono-Film", 1, 9, 0.7m, 110),
			new ArmorMaterial(1, "Spider-Silk", 2, 8, 0.5m, 205),
			new ArmorMaterial(2, "Thermal Spider Silk", 2, 8, 0.9m, 700),
			new ArmorMaterial(3, "Leather", 3, 7, 13.4m, 435),
			new ArmorMaterial(4, "Semi-Liquid Nanno-Carbons", 3, 7, 0.9m, 390),
			new ArmorMaterial(5, "Nanno-Pore", 4, 6, 3.6m, 440),
			new ArmorMaterial(6, "Kevlar	5", 5, 5, 8.9m, 590),
			new ArmorMaterial(7, "Bio-Tex", 6, 4, 0.6m, 1210),
			new ArmorMaterial(8, "Nanno-Tex", 6, 4, 1.2m, 615),
			new ArmorMaterial(9, "Ceramo-Plast", 7, 3, 12m, 715),
			new ArmorMaterial(10, "Flexi-Plasti-Steel", 8, 2, 11.1m, 910),
			new ArmorMaterial(11, "Carbon Fiber", 9, 1, 6.7m, 970),
			new ArmorMaterial(12, "Plasti-Steel", 10, 0, 15.6m, 1155),
			new ArmorMaterial(13, "Nanno-Carbon Fiber Weave", 11, -1, 14.9m, 1250),
			new ArmorMaterial(14, "Ceramo-Steel", 12, -2, 17.8m, 1380),
			new ArmorMaterial(15, "Lightweight Titanium", 13, -3, 20m, 1600),
			new ArmorMaterial(16, "Dimonotanium-Ceramatite", 15, -5, 20.4m, 1705),
			new ArmorMaterial(17, "Dibitanium-Ceramatite", 20, -10, 40.8m, 2410),
			new ArmorMaterial(18, "Ditritanium-Ceramatite", 25, -15, 61.3m, 3115),
		};
	}
	struct ArmorMaterial
	{
		internal int ID;
		internal string Name;

		internal decimal DD;
		internal decimal DEF;
		internal decimal Weight;
		internal decimal Cost;

		internal ArmorMaterial(int id, string n, decimal dd, decimal def, decimal w, decimal c)
		{
			ID = id;
			Name = n;
			DD = dd;
			DEF = def;
			Weight = w;
			Cost = c;
		}

		public override string ToString()
		{
			return Name;
		}
	}

	class ShieldType
	{
		internal static List<Shield> CivilianShields = new List<Shield>()
		{
			new Shield(10, "Civilian Vehicle / Aircraft", "CSG-01", 25, 25, 250, 25000),
			new Shield(11, "Civilian Vehicle / Aircraft", "CSG-02", 50, 50, 250, 50000),
			new Shield(12, "Civilian Vehicle / Aircraft", "CSG-03", 75, 75, 250, 75000),
			new Shield(13, "Civilian Vehicle / Aircraft", "CSG-04", 100, 100, 250, 100000),
			new Shield(14, "Civilian Vehicle / Aircraft", "CSG-05", 125, 125, 250, 125000),
			new Shield(15, "Civilian Vehicle / Aircraft", "CSG-06", 150, 150, 250, 150000),
			new Shield(16, "Civilian Vehicle / Aircraft", "CSG-07", 175, 175, 250, 175000),
			new Shield(17, "Civilian Vehicle / Aircraft", "CSG-08", 200, 200, 250, 200000),
			new Shield(18, "Civilian Vehicle / Aircraft", "CSG-09", 225, 225, 250, 225000),
			new Shield(19, "Civilian Vehicle / Aircraft", "CSG-10", 250, 250, 250, 250000),
		};
		internal static List<Shield> MilitaryVehicles = new List<Shield>()
		{
			new Shield(0, "Military Vehicle / Aircraft", "MSG-01", 125, 125, 25, 125000),
			new Shield(1, "Military Vehicle / Aircraft", "MSG-02", 250, 250, 25, 250000),
			new Shield(2, "Military Vehicle / Aircraft", "MSG-03", 375, 375, 25, 375000),
			new Shield(3, "Military Vehicle / Aircraft", "MSG-04", 500, 400, 25, 500000),
			new Shield(4, "Military Vehicle / Aircraft", "MSG-05", 625, 425, 25, 625000),
			new Shield(5, "Military Vehicle / Aircraft", "MSG-06", 750, 450, 25, 750000),
			new Shield(6, "Military Vehicle / Aircraft", "MSG-07", 875, 475, 25, 875000),
			new Shield(7, "Military Vehicle / Aircraft", "MSG-08", 1000, 500, 25, 1000000),
			new Shield(8, "Military Vehicle / Aircraft", "MSG-09", 1125, 525, 25, 1125000),
			new Shield(9, "Military Vehicle / Aircraft", "MSG-10", 1250, 550, 25, 1250000),
		};
		internal static List<Shield> MilitaryAuxiliary = new List<Shield>()
		{
			new Shield(20, "Military Auxiliary Craft", "ASG-01", 12500, 12500, 2500, 12500000),
			new Shield(21, "Military Auxiliary Craft", "ASG-02", 25000, 25000, 2500, 25000000),
			new Shield(22, "Military Auxiliary Craft", "ASG-03", 37500, 37500, 2500, 37500000),
			new Shield(23, "Military Auxiliary Craft", "ASG-04", 50000, 50000, 2500, 50000000),
			new Shield(24, "Military Auxiliary Craft", "ASG-05", 62500, 62500, 2500, 62500000),
			new Shield(25, "Military Auxiliary Craft", "ASG-06", 75000, 75000, 2500, 75000000),
			new Shield(26, "Military Auxiliary Craft", "ASG-07", 87500, 87500, 2500, 87500000),
			new Shield(27, "Military Auxiliary Craft", "ASG-08", 100000, 100000, 2500, 100000000),
			new Shield(28, "Military Auxiliary Craft", "ASG-09", 112500, 1125000, 2500, 1125000),
			new Shield(29, "Military Auxiliary Craft", "ASG-10", 125000, 125000, 2500, 1250000),
		};
	}
	struct Shield
	{
		internal int ID;
		internal string Model;
		internal int DD;
		internal int weight;
		internal int coverage;
		internal int cost;

		string Classification;

		internal Shield(int id, string cla, string m, int d, int w, int cov, int cos)
		{
			ID = id;
			Classification = cla;
			Model = m;
			DD = d;
			weight = w;
			coverage = cov;
			cost = cos;
		}

		public override string ToString()
		{
			return Model.ToString() + " " + coverage + "-SqM " + DD + "-dd";
		}
	}

	class AccesoryList
	{
		internal static List<Accesory> Accesories = new List<Accesory>()
		{
			new Accesory(0, "ACOG Sight", 0.7m, 1000),
			new Accesory(1, "Barrel Weight", 0.9m, 750),
			new Accesory(2, "Compensated", -0.1m, 250),
			new Accesory(3, "Flash Suppresor", 0.1m, 75),
			new Accesory(4, "Folding Bipod", 1.1m, 35),
			new Accesory(5, "Gun Camera", 1.6m, 800),
			new Accesory(6, "Holographic Sight", 0.2m, 580),
			new Accesory(7, "Hybrid Sight", 0.7m, 550),
			new Accesory(8, "Laser Sight", 0.2m, 130),
			new Accesory(9, "Quick Attach Barrel", 0, 75),
			new Accesory(10, "Red Dot", 0.4m, 170),
			new Accesory(11, "Scope x1.5", 0.7m, 150),
			new Accesory(12, "Scope x2", 0.9m, 200),
			new Accesory(13, "Scope x3", 1.3m, 300),
			new Accesory(14, "Scope x4", 1.8m, 400),
			new Accesory(15, "Scope x5", 2.2m, 500),
			new Accesory(16, "Silencer", 0, 1000),
			new Accesory(17, "Suppresor", 0, 500),
			new Accesory(18, "Tactical Light", 0.2m, 30),
			new Accesory(19, "Threaded Barrel", 0, 50),
			new Accesory(20, "Undermount Shotgun Piece", 0.2m, 150),
			new Accesory(21, "Vertical Foregrip", 0.7m, 25m),
		};
	}
	struct Accesory
	{
		internal int ID;
		internal string name;
		internal decimal cost;
		internal decimal weight;

		internal Accesory(int id, string n, decimal w, decimal c)
		{
			ID = id;
			name = n;
			cost = c;
			weight = w;
		}

		public override string ToString()
		{
			return name;
		}
	}

	class WeaponTypeClass
	{
		internal static List<WeaponType> WeaponTypes = new List<WeaponType>()
		{
			new WeaponType(0, "Handgun", 400,			0.075m),
			new WeaponType(1, "Shotgun", 250,			0.4m),
			new WeaponType(2, "Grenades", 0,			0),
			new WeaponType(3, "Assault Rifle", 350,		1.45m),
			new WeaponType(4, "Sniper", 4500,           5.25m),
			new WeaponType(5, "SMG", 250,				0.875m),
			new WeaponType(6, "Grenade Launcher", 500,	1.325m),
			new WeaponType(7, "Missile Launcher", 1000, 1.675m),
			new WeaponType(8, "Flame Thrower", 150,     7.3125m),
			new WeaponType(9, "Machine Gun", 2000,		3.75m),
		};
	}
	struct WeaponType
	{
		internal int ID;
		internal string name;
		internal decimal baseprice;
		internal decimal baseweight;

		internal WeaponType(int id, string n, decimal p, decimal w)
		{
			ID = id;
			name = n;
			baseprice = p;
			baseweight = w;
		}

		public override string ToString()
		{
			return name;
		}
	}

	class WeaponDamageTypeClass
	{
		internal static List<WeaponDamageType> WeaponDamageTypes = new List<WeaponDamageType>()
		{
			new WeaponDamageType(0, "Ballistic", 1, 1),
			new WeaponDamageType(1, "Caseless", 1.1m, .9m),
			new WeaponDamageType(2, "Grav / Mag", 1.75m, .8m),
			new WeaponDamageType(3, "Laser", 1.50m, .75m),
			new WeaponDamageType(4, "Particle", 1.25m, .5m),
		};
	}
	struct WeaponDamageType
	{
		internal int ID;
		internal string name;
		internal decimal costModifier;
		internal decimal weightModifier;

		internal WeaponDamageType(int id, string n, decimal c, decimal w)
		{
			ID = id;
			name = n;
			costModifier = c;
			weightModifier = w;
		}

		public override string ToString()
		{
			return name;
		}
	}

	class ConditionClass
	{
		internal static List<Condition> Conditions = new List<Condition>()
		{
			new Condition(0, "Well Maintained", 1),
			new Condition(1, "Barely Maintained", .9m),
			new Condition(2, "Neglected", .8m),
			new Condition(3, "Poorly Maintained", .7m),
			new	Condition(4, "Saturday Night Special", .6m),
		};
	}
	struct Condition
	{
		internal int ID;
		internal string name;
		internal decimal costMod;

		internal Condition(int id, string n, decimal c)
		{
			ID = id;
			name = n;
			costMod = c;
		}

		public override string ToString()
		{
			return name;
		}
	}

	//Armor Stuff
	//TreeNodes
	class ArmorEquipmentClass
	{
		internal static List<ArmorEquipment> RootEquipment = new List<ArmorEquipment>();

		internal static void Initialize()
		{
			ArmorEquipment HUD = new ArmorEquipment("HUD",
				@"This upgrade can be easily added to any cyber-optic and it allows for varying types of information to be displayed on the cyber-optic, quite a few Cyberware options require the installation of one of these.",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0.25m,
				null);
			new ArmorEquipment("Anti Flash",
				@"This option allows the person to avoid being blinded by bright flashes of light such as flash bangs and spotlights.
You gain a bonus to physical exertion vs. blinding.",
				5,
				new List<decimal> { 100, 200, 300, 400, 500 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				HUD);
			new ArmorEquipment("Coloration Change",
				@"This allows a person to change the colors of their eyes at will.",
				1,
				new List<decimal> { 250 },
				new List<string> { "" },
				0,
				HUD);
			new ArmorEquipment("GPS",
				@"With this module you can easily connect to GPS satellites in orbit around the planet you are on. You gain a bonus to survival skills – navigate. Note: There has to be GPS satellites in orbit.",
				1,
				new List<decimal> { 150 },
				new List<string> { "" },
				0,
				HUD);
			new ArmorEquipment("IR",
				@"This upgrade allows you to easily see in the infra-red range of vision.
You gain a bonus to notice checks for IR.",
				5,
				new List<decimal> { 50, 100, 150, 200, 250 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				HUD);
			new ArmorEquipment("Image Enhancer",
				@"With this upgrade your cyber-optics are able to take visual data and enhance it greatly allowing you to make out details.
It should be noted that this cannot be done real time but must be done once the image has been taken.
You gain a bonus to notice after the enhancement is complete.",
				5,
				new List<decimal> { 25, 50, 75, 100, 125 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				HUD);
			new ArmorEquipment("Low Light",
				@"With this upgrade you gain the ability to see more clearly in low-light situations.
You gain a bonus to notice checks in low-light.",
				5,
				new List<decimal> { 12.5m, 25m, 37.5m, 50m, 62.5m },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				HUD);
			new ArmorEquipment("Magnification",
				@"With this upgrade you are able to more clearly see at long ranges and be able to view microscopic items with detail.
You gain extended increment ranges and the ability to magnify close objects.",
				5,
				new List<decimal> { 200, 400, 600, 800, 1000 },
				new List<string> { "x1.5", "x2", "x3", "x4", "x5" },
				0,
				HUD);
			new ArmorEquipment("Night Vision",
				@"With this upgrade you are able to see in complete darkness.
You gain a bonus to notice checks in complete darkness along with being able to see a certain distance.",
				5,
				new List<decimal> { 2200, 4400, 6600, 8800, 11000 },
				new List<string> { "+1 Notice to 3m", "+2 Notice to 6m", "+3 Notice to 9m", "+4 Notice to 12m", "+5 Notice to 15m" },
				0,
				HUD);
			new ArmorEquipment("Range Finder",
				@"With the RF-[L] you are able to LASE a target and get a more accurate idea of how far away it is as well as being able to target it for incoming ordnance.
Ordnance and missiles gain a bonus to hit when using this.",
				5,
				new List<decimal> { 100, 200, 300, 400, 500 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				HUD);
			new ArmorEquipment("TADS",
				@"Target Acquisition & Designation System 
First used in the Apache Helicopters in the 20th century this downscaled version gives bonuses to a vehicle mounted ranged weapon that is linked through the TADS system; however the weapon must have a special laser sight attached to it.",
				5,
				new List<decimal> { 1000, 2000, 3000, 4000, 5000 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				HUD);
			new ArmorEquipment("Thermal",
				@"This upgrade allows a person to see in the thermal range allowing them to distinguish between most animate and inanimate objects.
You gain a bonus to notice – sight checks in the thermal range.",
				5,
				new List<decimal> { 150, 300, 450, 600, 750 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				HUD);
			new ArmorEquipment("Time / Date",
				@"Shows the Galactic Standard Date and Time on the HUD",
				1,
				new List<decimal> { 25 },
				new List<string> { "" },
				0,
				HUD);
			new ArmorEquipment("UV",
				@"With this upgrade your optics put out a UV based light allowing you to more easily see in low-light and darkness as well as being able to see in the UV range.
You gain a bonus to notice – sight in the UV range.",
				5,
				new List<decimal> { 300, 600, 900, 1200, 1500 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				HUD);
			new ArmorEquipment("View Screen",
				@"Used to access and playback video",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				HUD);
//--------------------------------------------------------------------------------------------------------------------------
			ArmorEquipment Radio = new ArmorEquipment("Radio",
				@"This bonus allows your Armor to pick up radio signals in the area, this is required for any of the
sub item's to function.",
				1,
				new List<decimal> { 100 },
				new List<string> { "" },
				1, //KG
				null);
			new ArmorEquipment("Short Range Comm.",
				@"This communications system allows you to communicate normally as if you were using a handheld COMM unit.",
				1,
				new List<decimal> { 100 },
				new List<string> { "" },
				0,
				Radio);
			new ArmorEquipment("Medium Range Comm.",
				@"This communications system allows you to communicate normally as if you were using a handheld COMM unit.",
				1,
				new List<decimal> { 150 },
				new List<string> { "" },
				0,
				Radio);
			new ArmorEquipment("Long Range Comm.",
				@"This communications system allows you to communicate normally as if you were using a handheld COMM unit.",
				1,
				new List<decimal> { 250 },
				new List<string> { "" },
				0,
				Radio);
			new ArmorEquipment("Bullhorn",
				@"This amplifies the sound of your voice allowing others to more easily hear you.
Others gain a bonus to notice – hearing checks when you are talking.",
				1,
				new List<decimal> { 500 },
				new List<string> { "+5" },
				0,
				Radio);
			new ArmorEquipment("Forked Tongue",
				@"This module allows a person to more easily and smoothly tell lies without anyone being able to tell by their tone if they are lying. You gain a bonus to your deception rolls.",
				1,
				new List<decimal> { 500 },
				new List<string> { "+5" },
				0,
				Radio);
			new ArmorEquipment("Synthesizer",
				@"This item allows you to mimic sounds such as animals and background noise. You gain a bonus to mimicking noises.",
				1,
				new List<decimal> { 500 },
				new List<string> { "+5" },
				0,
				Radio);
			new ArmorEquipment("Voice Pattern",
				@"This item allows you to mimic other people’s voice patterns almost perfectly. You gain a bonus to mimicking other people’s voices.",
				1,
				new List<decimal> { 500 },
				new List<string> { "+5" },
				0,
				Radio);
			new ArmorEquipment("HAS",
				@"The HAS system is able to enhance ones hearing and comes with numerous other accessories that can be easily added to the system.
The system comes with a number of varying slots for upgrades depending on model.
You gain a bonus to notice hearing.",
				5,
				new List<decimal> { 500, 1000, 1500, 2000, 2500 },
				new List<string> { "+1, 2 Slots", "+2, 4 Slots", "+3, 6 Slots", "+4, 8 Slots", "+5, 10 Slots" },
				0,
				Radio);
			new ArmorEquipment("Audible Tracker",
				@"This module allows you to lock onto a sound and track is easily; there is also a sub- and super-audible upgrades available allowing for the tracking of devices that emit these frequencies. 
You gain a bonus to survival skills – tracking; audio only.",
				5,
				new List<decimal> { 500, 1000, 1500, 2000, 2500 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				Radio);
			new ArmorEquipment("Scrambler",
				@"This module scrambles your outgoing communications and descrambles incoming communications making it harder for others to eavesdrop on your conversations.
Others gain a minus to descramble your communications when attempting to listen in. ",
				5,
				new List<decimal> { 2500, 5000, 7500, 10000, 12500 },
				new List<string> { "-1", "-2", "-3", "-4", "-5" },
				0,
				Radio);
			new ArmorEquipment("Descrambler",
				@"This module gives you a bonus to Descramble other communications",
				5,
				new List<decimal> { 2500, 5000, 7500, 10000, 12500 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				Radio);
			new ArmorEquipment("Sensor Detector",
				@"With this module you get an audible ping when it detects Radar, Sonar, IR, thermal, Laser, or Ultra sonic detection devices.
You gain a bonus to notice checks.
It should be noted that each one of these ranges is a separate module.",
				5,
				new List<decimal> { 5000, 10000, 15000, 20000, 25000 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				Radio);
			new ArmorEquipment("Recording Link",
				@"Combined with a moly-chip reader you can record everything that you hear.",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Radio);
			new ArmorEquipment("Sat uplink",
				@"Allows a person to uplink to orbital sattelites",
				1,
				new List<decimal> { 1000 },
				new List<string> { "" },
				1, //KG
				Radio);
			new ArmorEquipment("Sound Dampner",
				@"This module automatically dampens loud noises keeping you from being deafened by them.
You gain a bonus to physical exertions vs. deafening.",
				5,
				new List<decimal> { 1000, 2000, 3000, 4000, 5000 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				Radio);
			new ArmorEquipment("Subaudible",
				@"These modules allow you to pick up and hear in the sub-audible ranges.
You gain a bonus to notice hearing for these ranges.",
				5,
				new List<decimal> { 1000, 2000, 3000, 4000, 5000 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				Radio);
			new ArmorEquipment("Superaudible",
				@"These modules allow you to pick up and hear in the super-audible ranges.
You gain a bonus to notice hearing for these ranges.",
				5,
				new List<decimal> { 1000, 2000, 3000, 4000, 5000 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				Radio);
			new ArmorEquipment("Encrypted Comm",
				@"With this module you are able to pick up and hear both encrypted and unencrypted communications.
You gain a bonus to decrypt communications signals.",
				5,
				new List<decimal> { 1000, 2000, 3000, 4000, 5000 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				Radio);
//--------------------------------------------------------------------------------------------------------------------------
			ArmorEquipment Physical = new ArmorEquipment("Physical Enhancements",
				@"These enhancements give the operator a distinct physcal edge over their opponents.",
				1,
				new List<decimal> { 0 },
				new List<string> { "" },
				0,
				null);
			new ArmorEquipment("Gyro Stablizer",
				@"This cybernetic device keeps you level and steady while trying to perform attacks from a vehicle or from the back of an animal. You gain a bonus to attacks from animals and vehicles.",
				5,
				new List<decimal> { 200, 400, 600, 800, 1000 },
				new List<string> { "+1", "+2", "+3", "+4", "+5" },
				0,
				Physical);
			new ArmorEquipment("Joint Reinforcement",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Physical);
			new ArmorEquipment("Reinforced Spine",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Physical);
			new ArmorEquipment("Strengthened Shoulders",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Physical);
//--------------------------------------------------------------------------------------------------------------------------
			ArmorEquipment Medical = new ArmorEquipment("Medical",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				null);
			new ArmorEquipment("Biomonitor Personal",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Medical);
			new ArmorEquipment("Biomonitor Remote",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Medical);
			new ArmorEquipment("Internal Defribrillator",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Medical);
			new ArmorEquipment("Psychological SE",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Medical);
//--------------------------------------------------------------------------------------------------------------------------
			ArmorEquipment Utility = new ArmorEquipment("Utility",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0, 
				null);
			new ArmorEquipment("Oxygen",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Face Shield",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Flash Light",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Temp. Control",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Moly Chip Slot",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Camera",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Holo Projector",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Interface Plug",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Irthop Coating",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Magnetic Grip Pads",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Micrometric Tentacles",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Microwave / EMP Shielding",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Self Destruct",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Weapon Link",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
			new ArmorEquipment("Webbing",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Utility);
//--------------------------------------------------------------------------------------------------------------------------
			ArmorEquipment Sensors = new ArmorEquipment("Sensors",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				null);
			new ArmorEquipment("Motion Detector",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Sensors);
			new ArmorEquipment("Radar",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Sensors);
			new ArmorEquipment("Sonar",
				@"",
				1,
				new List<decimal> { 500 },
				new List<string> { "" },
				0,
				Sensors);

			RootEquipment.Add(HUD);
			RootEquipment.Add(Radio);
			RootEquipment.Add(Physical);
			RootEquipment.Add(Medical);
			RootEquipment.Add(Utility);
			RootEquipment.Add(Sensors);
		}
	}
	class ArmorEquipment
	{
		internal ArmorEquipment Parent;
		internal List<ArmorEquipment> Children = new List<ArmorEquipment>();

		internal string Name;
		internal string Description;

		/// <summary>
		/// Levels represents the number of numerical levels this boost has
		/// boosts that have only one level will use a checkbox instead of a numerical box
		/// boosts that have 0 levels will not have options
		/// </summary>
		internal decimal Levels;
		internal List<decimal> Cost;
		internal List<string> Bonuses;
		internal decimal Weight;
		
		internal ArmorEquipment(string name, string desc, decimal levels, List<decimal> cost, List<string> bonuses, decimal weight, ArmorEquipment parent)
		{
			Name = name;
			Description = desc;
			Levels = levels;
			Cost = cost;
			Bonuses = bonuses;
			Weight = weight;
			Parent = parent;

			if(parent != null) Parent.Children.Add(this);
		}

		internal TreeNode GetNode()
		{
			TreeNode t = new TreeNode(Name);
			t.Tag = this;

			foreach(ArmorEquipment ae in Children)
			{
				t.Nodes.Add(ae.GetNode());
			}

			return t;
		}
	}
	class ArmorEquipmentNode
	{

	}

	//Turrets / Tubes
	class TurretMark
	{
		internal static List<TurretType> PointDefenseTurrets = new List<TurretType>()
		{
			new TurretType(1, 15, 25m, 2500000m),
			new TurretType(2, 30, 50m, 5000000m),
			new TurretType(3, 45, 75m, 7500000m),
			new TurretType(4, 60, 100m, 10000000m),
			new TurretType(5, 75, 125m, 12500000m),
			new TurretType(6, 90, 150m, 15000000m),
			new TurretType(7, 105, 175m, 17500000m),
			new TurretType(8, 120, 200m, 20000000m),
			new TurretType(9, 135, 225m, 22500000m),
			new TurretType(10, 150, 250m, 25000000m)
		};
		internal static List<TurretType> ParticleBeamProjectorTurrets = new List<TurretType>()
		{
			new TurretType(1, 22.5m, 250m, 25000000m),
			new TurretType(2, 45m, 500m, 50000000m),
			new TurretType(3, 67.5m, 750m, 75000000m),
			new TurretType(4, 90m, 1000m, 100000000m),
			new TurretType(5, 112.5m, 1250m, 125000000m),
			new TurretType(6, 135m, 1500m, 150000000m),
			new TurretType(7, 157.5m, 1750m, 175000000m),
			new TurretType(8, 180m, 2000m, 200000000m),
			new TurretType(9, 202.5m, 2250m, 225000000m),
			new TurretType(10, 225m, 2500m, 250000000m)
		};
		internal static List<TurretType> PointDefenseMissileTube = new List<TurretType>()
		{
			new TurretType(1,5,2.5m,10000),
			new TurretType(2,10,5,20000),
			new TurretType(3,15,7.5m,30000),
			new TurretType(4,20,10,40000),
			new TurretType(5,25,12.5m,50000),
			new TurretType(6,30,15,60000),
			new TurretType(7,35,17.5m,70000),
			new TurretType(8,40,20,80000),
			new TurretType(9,45,22.5m,90000),
			new TurretType(10,50,25,100000)
		};
		internal static List<TurretType> SubCapitolMissileTube = new List<TurretType>()
		{
			new TurretType(1, 125, 200, 250000),
		};
		internal static List<TurretType> CapitolMissileTube = new List<TurretType>()
		{
			new TurretType(1, 250, 400, 500000),
		};
		
	}
	class TurretType
	{
		internal decimal version;
		internal decimal space;
		internal decimal weight;
		internal decimal cost;

		internal TurretType(decimal v, decimal s, decimal w, decimal c)
		{
			version = v;
			space = s;
			weight = w;
			cost = c;
		}
	}

	//Ship Shields
	class ShipShieldType
	{
		internal static List<ShipShield> CivilianShields = new List<ShipShield>()
		{
			new ShipShield("CSSG-01",125000,125,875000,1250000),
			new ShipShield("CSSG-02",250000,250,1750000,2500000),
			new ShipShield("CSSG-03",375000,375,2625000,3750000),
			new ShipShield("CSSG-04",500000,500,3500000,5000000),
			new ShipShield("CSSG-05",625000,625,4375000,6250000),
			new ShipShield("CSSG-06",750000,750,5250000,7500000),
			new ShipShield("CSSG-07",875000,875,6125000,8750000),
			new ShipShield("CSSG-08",1000000,1000,7000000,10000000),
			new ShipShield("CSSG-09",1125000,1125,7875000,11250000),
			new ShipShield("CSSG-10",1250000,1250,8750000,12500000)
		};
		internal static List<ShipShield> MilitaryVehicles = new List<ShipShield>()
		{
			new ShipShield("MSSG-01",1000000,1000,1312500,10000000),
			new ShipShield("MSSG-02",2000000,2000,2625000,20000000),
			new ShipShield("MSSG-03",3000000,3000,3937500,30000000),
			new ShipShield("MSSG-04",4000000,4000,5250000,40000000),
			new ShipShield("MSSG-05",5000000,5000,6562500,50000000),
			new ShipShield("MSSG-06",6000000,6000,7875000,60000000),
			new ShipShield("MSSG-07",7000000,7000,9187500,70000000),
			new ShipShield("MSSG-08",8000000,8000,10500000,80000000),
			new ShipShield("MSSG-09",9000000,9000,11812500,90000000),
			new ShipShield("MSSG-10",10000000,10000,13125000,100000000)
		};
	}
	struct ShipShield
	{
		internal string Model;
		internal int DD;
		internal int weight;
		internal int coverage;
		internal int cost;
		
		internal ShipShield(string m, int d, int w, int cov, int cos)
		{
			Model = m;
			DD = d;
			weight = w;
			coverage = cov;
			cost = cos;
		}

		public override string ToString()
		{
			return Model.ToString() + " " + coverage + "-SqM " + DD + "-dd";
		}
	}

	//Ship Materials
	class ShipMaterialWeightCost
	{
		internal static List<ShipMaterial> VehicleMaterials = new List<ShipMaterial>()
		{
			new ShipMaterial("Dimonotanium-Ceramatite", 5500m, 450, 15),
			new ShipMaterial("Dibitanium Ceramatite", 7500m, 600, 20),
			new ShipMaterial("Ditritanium Ceramatite", 10000, 750, 25),
		};
	}
	struct ShipMaterial
	{
		internal string name;
		internal decimal weight;
		internal int cost;
		internal int DD;

		internal ShipMaterial(string n, decimal w, int c, int d)
		{
			name = n;
			weight = w;
			cost = c;
			DD = d;
		}
		public override string ToString()
		{
			return name;
		}
	}
}
