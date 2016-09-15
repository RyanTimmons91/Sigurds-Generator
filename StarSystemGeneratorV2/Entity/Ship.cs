using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSystemGeneratorV2.Entity
{
	public class Ship
	{
		#region Magic Numbers
		internal const decimal MagicCrewNumber = 0.00001219047619047619m;
		internal const decimal MagicAirPersonnelNumber = .000006857142857142857m;
		internal const decimal MagicGroundTroopNumber = .00001523809523809524m;
		internal const decimal MagicMaxEvac = 0.0013714285714286m;
		internal const decimal MagicJumpDistance = .000000007619047619047619m;
		internal const decimal MagicHBTFurnace = .000000003047619047619048m;
		internal const decimal MagicThrusterBanks = .0000004571428571428571m;
		internal const decimal MagicIntertial = .000001142857142857143m;
		internal const decimal MagicFuelMass = 0.015m;
		internal const decimal MagicCargo = 1.1m;
		internal const decimal MagicDryStoreStandard = .000000002438095238095238m;
		internal const decimal MagicSmallArms = .0000000009142857142857143m;
		internal const decimal MagicVehicles = .0000000006095238095238095m;
		#endregion

		decimal ShipCrew
		{
			get
			{
				return Math.Ceiling(ObjectVolume * MagicCrewNumber);
			}
		}
		decimal ShipAirPers
		{
			get
			{
				return Math.Round(ObjectVolume * MagicAirPersonnelNumber);
			}
		}
		decimal GroundShipPers
		{
			get
			{
				return Math.Round(ObjectVolume * MagicGroundTroopNumber);
			}
		}
		decimal MaxEvac
		{
			get
			{
				return Math.Round(ObjectVolume * MagicMaxEvac);
			}
		}
		decimal JumpDistance
		{
			get
			{
				return Math.Round(ObjectVolume * MagicJumpDistance);
			}
		}
		decimal HBTFurnaces
		{
			get
			{
				return Math.Round(ObjectVolume * MagicHBTFurnace);
			}
		}
		decimal ThrusterBanks
		{
			get
			{
				return Math.Round(ObjectVolume * MagicThrusterBanks);
			}
		}
		decimal IntertialStuff
		{
			get
			{
				return Math.Round(ObjectVolume * MagicIntertial);
			}
		}
		decimal FuelMass
		{
			get
			{
				return TotalEmptyWeight * MagicFuelMass;
			}
		}
		decimal MaxCargo
		{
			get
			{
				return TotalEmptyWeight * MagicCargo;
			}
		}
		decimal DryStoreStandard
		{
			get
			{
				return Math.Round(ObjectVolume * MagicDryStoreStandard);
			}
		}
		decimal DryStoreCrewOnly
		{
			get
			{
				if (ShipCrew == 0) return 0;
				decimal Total = ShipCrew + ShipAirPers + GroundShipPers;
				return Math.Round(DryStoreStandard * (Total / ShipCrew));
			}
		}
		decimal DryStoreMaxEvac
		{
			get
			{
				if (ShipCrew == 0) return 0;
				decimal LowerNumber = ShipCrew + ShipAirPers + GroundShipPers;
				return Math.Round((DryStoreStandard * (LowerNumber / MaxEvac)) * 300);
			}
		}
		decimal SmallArms
		{
			get
			{
				return Math.Round(ObjectVolume * MagicSmallArms);
			}
		}
		decimal Vehicles
		{
			get
			{
				return Math.Round(ObjectVolume * MagicVehicles);
			}
		}

		decimal ObjectVolume
		{
			get
			{
				return Height * Length * Width;
			}
		}
		decimal BuildTime
		{
			get
			{
				return (Height + Length + Width) / 5;
			}
		}
		decimal TotalMade
		{
			get
			{
				if (BuildTime == 0) return 0;
				return (YearsInProduction * 300) / BuildTime;
			}
		}
		
		decimal ChassisWeight
		{
			get
			{
				if(isChassisMaterialSet)
				{
					return ChassisMaterial.weight * ChassisThickness * (ObjectVolume / 25);
				}
				return 0;
			}
		}
		decimal ChassisCost
		{
			get
			{
				if(isChassisMaterialSet)
				{
					return ChassisMaterial.cost * ChassisThickness * (ObjectVolume / 25);
				}
				return 0;
			}
		}

		decimal ArmorWeight
		{
			get
			{
				if(isArmorMaterialSet)
				{
					return Armormaterial.weight * ArmorThickness * (ObjectVolume / 25);
				}
				return 0;
			}
		}
		decimal ArmorCost
		{
			get
			{
				if (isArmorMaterialSet)
				{
					return Armormaterial.cost * ArmorThickness * (ObjectVolume / 25);
				}
				return 0;
			}
		}

		decimal ShieldCount
		{
			get
			{
				if(isShieldSet)
				{
					System.Windows.Forms.MessageBox.Show("" + ObjectVolume + " - " + ShipShield.coverage + "");
					return Math.Ceiling(ObjectVolume / ShipShield.coverage);
				}
				return 0;
			}
		}
		decimal ShieldWeigth
		{
			get
			{
				if (isShieldSet)
				{
					return ShieldCount * ShipShield.weight;
				}
				return 0;
			}
		}
		decimal ShieldCost
		{
			get
			{
				if (isShieldSet)
				{
					return ShieldCount * ShipShield.cost;
				}
				return 0;
			}
		}
		
		decimal SensorCost
		{
			get
			{
				return (SensorCount * 1000) + (ChaffFlare * 100);
			}
		}
		decimal SensorWeight
		{
			get
			{
				return SensorCount * 50;
			}
		}

		decimal PassengerWeight
		{
			get
			{
				return Passengers * 250;
			}
		}
		decimal CargoWeight
		{
			get
			{
				return Cargo * 1000;
			}
		}
		decimal PowerCellWeight
		{
			get
			{
				return PowerCells * 6.75m;
			}
		}

		decimal TurretsAndMissileTubesWeight
		{
			get
			{
				decimal weight = 0;
				if (TurretPDDosalType != null)
				{
					weight += TurretPDDosalType.weight * TurretPDDorsalCount;
				}
				if (TurretPBPDorsalType != null)
					weight += TurretPBPDorsalType.weight * TurretPBPDorsalCount;
				if (TurretPDVentralType != null)
					weight += TurretPDVentralType.weight * TurretPDVentralCount;
				if (TurretPBPVentralType != null)
					weight += TurretPBPVentralType.weight * TurretPBPVentralCount;
				if (MissileTubeType != null)
					weight += MissileTubeType.weight * MissileTubeCount;
				if (SubCapitalMissileTubeType != null)
					weight += SubCapitalMissileTubeType.weight * SubCapitalMissileTubeCount;
				if (CapitalMissileTubeType != null)
					weight += CapitalMissileTubeType.weight * CapitalMissileTubeCount;
				return weight;
			}
		}
		decimal TurretsAndMissileTubesCost
		{
			get
			{
				decimal cost = 0;
				if (TurretPDDosalType != null)
				{
					cost += TurretPDDosalType.cost * TurretPDDorsalCount;
				}
				if (TurretPBPDorsalType != null)
					cost += TurretPBPDorsalType.cost * TurretPBPDorsalCount;
				if (TurretPDVentralType != null)
					cost += TurretPDVentralType.cost * TurretPDVentralCount;
				if (TurretPBPVentralType != null)
					cost += TurretPBPVentralType.cost * TurretPBPVentralCount;
				if (MissileTubeType != null)
					cost += MissileTubeType.cost * MissileTubeCount;
				if (SubCapitalMissileTubeType != null)
					cost += SubCapitalMissileTubeType.cost * SubCapitalMissileTubeCount;
				if (CapitalMissileTubeType != null)
					cost += CapitalMissileTubeType.cost * CapitalMissileTubeCount;
				return cost;
			}
		}

		decimal TotalWeight
		{
			get
			{
				return 0 +
					ChassisWeight +
					ArmorWeight +
					ShieldWeigth +
					SensorWeight +
					PassengerWeight +
					CargoWeight +
					PowerCellWeight +
					EngineWeight +
					TurretsAndMissileTubesWeight +
					AmmoWeight;
			}
		}
		decimal TotalEmptyWeight
		{
			get
			{
				return 0 +
					ChassisWeight +
					ArmorWeight +
					ShieldWeigth +
					SensorWeight +
					EngineWeight +
					TurretsAndMissileTubesWeight;
			}
		}
		decimal TotalCost
		{
			get
			{
				return 0 +
					ChassisCost +
					ArmorCost +
					ShieldCost +
					SensorCost +
					EngineCost +
					TurretsAndMissileTubesCost;
			}
		}
		decimal MaintCost
		{
			get
			{
				return TotalCost * .01m;
			}
		}

		string Size
		{
			get
			{
				return (string)LengthToDefenseRating()[0];
			}
		}
		decimal Defense
		{
			get
			{
				return (decimal)LengthToDefenseRating()[1];
			}
		}
		string Maneuverability
		{
			get
			{
				return "" + (decimal)LengthToDefenseRating()[2] + " " +
					(decimal)LengthToDefenseRating()[3] + " " +
					(decimal)LengthToDefenseRating()[4] + " " +
					(decimal)LengthToDefenseRating()[5];
			}
		}
		
		//-------------------------------------
		// This area is filled in from the form
		//-------------------------------------

		internal decimal Height = 0;
		internal decimal Length = 0;
		internal decimal Width = 0;

		internal decimal YearsInProduction = 0;

		internal bool isChassisMaterialSet = false;
		internal ShipMaterial ChassisMaterial;
		internal decimal ChassisThickness = 0;

		internal bool isArmorMaterialSet = false;
		internal ShipMaterial Armormaterial;
		internal decimal ArmorThickness = 0;

		internal bool isShieldSet = false;
		internal ShipShield ShipShield;
		
		internal decimal SensorCount = 0;
		internal decimal ChaffFlare = 0;
		internal decimal Passengers = 0;
		internal decimal Cargo = 0;
		internal decimal PowerCells = 0;

		internal decimal AmmoWeight = 0;

		internal decimal EngineWeight = 0;
		internal decimal EngineCost = 0;

		#region Turrests and Missile Tubes
		internal TurretType TurretPDDosalType = null;
		internal decimal TurretPDDorsalCount = 0;

		internal TurretType TurretPBPDorsalType = null;
		internal decimal TurretPBPDorsalCount = 0;

		internal TurretType TurretPDVentralType = null;
		internal decimal TurretPDVentralCount = 0;

		internal TurretType TurretPBPVentralType = null;
		internal decimal TurretPBPVentralCount = 0;

		internal TurretType MissileTubeType = null;
		internal decimal MissileTubeCount = 0;

		internal TurretType SubCapitalMissileTubeType = TurretMark.SubCapitolMissileTube[0];
		internal decimal SubCapitalMissileTubeCount = 0;

		internal TurretType CapitalMissileTubeType = TurretMark.CapitolMissileTube[0];
		internal decimal CapitalMissileTubeCount = 0;
		#endregion

		internal Ship()
		{

		}
		
		internal object[] LengthToDefenseRating()
		{
			if(Length < 5.1m)
			{
				return new object[] { "Fine", 10m, 1m, 2m, 3m, 4m };
			}
			else if (Length < 25.1m)
			{
				return new object[] { "Diminutive", 9m, 2m, 3m, 4m, 5m };
			}
			else if (Length < 50.1m)
			{
				return new object[] { "Tiny", 8m, 3m, 4m, 5m, 6m };
			}
			else if (Length < 250.1m)
			{
				return new object[] { "Small", 7m, 4m, 5m, 6m, 7m };
			}
			else if (Length < 500.1m)
			{
				return new object[] { "Medium", 6m, 5m, 6m, 7m, 8m };
			}
			else if (Length < 750.1m)
			{
				return new object[] { "Large", 5m, 6m, 7m, 8m, 9m };
			}
			else if (Length < 1000.1m)
			{
				return new object[] { "Huge", 4m, 7m, 8m, 9m, 10m };
			}
			else if (Length < 2500.1m)
			{
				return new object[] { "Gigantic", 3m, 8m, 9m, 10m, 11m };
			}
			else if (Length < 5000.1m)
			{
				return new object[] { "Gargantuan", 2m, 9m, 10m, 11m, 12m };
			}
			else if (Length < 10000.1m)
			{
				return new object[] { "Colossal", 1m, 10m, 11m, 12m, 13m };
			}
			else
			{
				return new object[] { "Titanic", 0m, 11m, 12m, 13m, 14m };
			}

		}

		internal List<object[]> BuildDataGrid()
		{
			List<object[]> Rows = new List<object[]>();

			Rows.Add(new Object[] { "Total Cost", TotalCost + "" });
			Rows.Add(new Object[] { "Maintainence Cost", MaintCost + "" });
			
			Rows.Add(new Object[] { "Total Operating Weight", TotalWeight / 1000 + " mt" });
			Rows.Add(new Object[] { "Total Empty Weight", TotalEmptyWeight / 1000 + " mt" });

			Rows.Add(new Object[] { "Armor Weight", ArmorWeight / 1000 + " mt" });
			Rows.Add(new Object[] { "Armor Cost", ArmorCost + "" });

			Rows.Add(new Object[] { "Sensor Weight", SensorWeight + "" });
			Rows.Add(new Object[] { "Sensor Cost", SensorCost + "" });

			Rows.Add(new Object[] { "Cargo Capacity", CargoWeight / 1000 + " mt" });
			
			Rows.Add(new Object[] { "Ship Crew", ShipCrew + "" });
			Rows.Add(new Object[] { "Air Personnel", ShipAirPers + "" });
			Rows.Add(new Object[] { "Ground Personnel", GroundShipPers + "" });
			Rows.Add(new Object[] { "Max Evacuation", MaxEvac + "" });
			Rows.Add(new Object[] { "Jump Distance", JumpDistance + " parsecs" });
			Rows.Add(new Object[] { "HBT Furnaces", HBTFurnaces + "" });
			Rows.Add(new Object[] { "Thruster Banks", ThrusterBanks + "" });
			Rows.Add(new Object[] { "Intertial Sumps", IntertialStuff + "" });

			Rows.Add(new Object[] { "Build Time", BuildTime + "" });
			Rows.Add(new Object[] { "Total Made", TotalMade + "" });

			Rows.Add(new Object[] { "Shield Count", ShieldCount + "" });

			Rows.Add(new Object[] { "Fuel Mass", FuelMass / 1000 + " mt" });
			Rows.Add(new Object[] { "Max Cargo Weight", MaxCargo / 1000 + " mt" });

			Rows.Add(new Object[] { "Size", Size});
			Rows.Add(new Object[] { "Defense", Defense + "" });
			Rows.Add(new Object[] { "Maneuverability", Maneuverability});

			Rows.Add(new Object[] { "Dry Stores (Standard)", DryStoreStandard + " years" });
			Rows.Add(new Object[] { "Dry Stores (Crew Only)", DryStoreCrewOnly + " years" });
			Rows.Add(new Object[] { "Dry Stores (Max Evac)", DryStoreMaxEvac + " days" });

			Rows.Add(new Object[] { "Munitions - Small Arms", SmallArms + " months" });
			Rows.Add(new Object[] { "Munitions - Vehicles", Vehicles + " months" });
			Rows.Add(new Object[] { "DO MOAR MUNICIONZ", "I NEED MORE" });
			
			Rows.Add(new Object[] { "Probe Launch Tubes", 0.02m * Height + "" }); //0.02 times height
			Rows.Add(new Object[] { "Decoy Bays", 0.002m * Length + "" }); //0.002 * length
			
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });
			Rows.Add(new Object[] { "Title", 1000 + "" });

			return Rows;
		}
	}
}
