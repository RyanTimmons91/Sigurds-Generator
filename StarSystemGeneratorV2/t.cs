using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSystemGeneratorV2.Entity
{
	public class Shipt
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
				return TotalEmptyWeight* MagicFuelMass;
			}
		}
		decimal MaxCargo
		{
			get
			{
				return TotalEmptyWeight * MagicCargo;
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
				return (YearsInProduction * 300) / BuildTime;
			}
		}

		decimal ChassisWeight
		{
			get
			{
				if (isChassisMaterialSet)
				{
					return ChassisMaterial.weight * ChassisThickness * ObjectVolume;
				}
				return 0;
			}
		}
		decimal ChassisCost
		{
			get
			{
				if (isChassisMaterialSet)
				{
					return ChassisMaterial.cost * ChassisThickness * ObjectVolume;
				}
				return 0;
			}
		}

		decimal ArmorWeight
		{
			get
			{
				if (isArmorMaterialSet)
				{
					return Armormaterial.weight * ArmorThickness * ObjectVolume;
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
					return Armormaterial.cost * ArmorThickness * ObjectVolume;
				}
				return 0;
			}
		}

		decimal ShieldCount
		{
			get
			{
				if (isShieldSet)
				{
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

		decimal EnergyCost
		{
			get
			{
				if (isGenerators)
				{
					//Generators Cost
					return CellGeneratorCount * 1000000;
				}
				else
				{
					//Cells Cost
					return CellGeneratorCount * 1000;
				}
			}
		}
		decimal EnergyWeight
		{
			get
			{
				if (isGenerators)
				{
					//Generators Weight
					return CellGeneratorCount * 10000;
				}
				else
				{
					//Cells Weight
					return CellGeneratorCount * 23;
				}
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

		decimal TotalWeight
		{
			get
			{
				return 0 +
					ChassisWeight +
					ArmorWeight +
					ShieldWeigth +
					EnergyWeight +
					SensorWeight +
					PassengerWeight +
					CargoWeight +
					PowerCellWeight +
					EngineWeight +
					WeaponWeightEmpty +
					WeaponWeightOther +
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
					EnergyWeight +
					SensorWeight +
					EngineWeight +
					WeaponWeightEmpty;
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
					EnergyCost +
					SensorCost +
					EngineCost +
					WeaponCost;
			}
		}
		decimal MaintCost
		{
			get
			{
				return TotalCost * .01m;
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
		internal VehicleMaterial ChassisMaterial;
		internal decimal ChassisThickness = 0;

		internal bool isArmorMaterialSet = false;
		internal VehicleMaterial Armormaterial;
		internal decimal ArmorThickness = 0;

		internal bool isShieldSet = false;
		internal Shield ShipShield;

		internal bool isGenerators = false;
		internal decimal CellGeneratorCount = 0;

		internal decimal SensorCount = 0;
		internal decimal ChaffFlare = 0;
		internal decimal Passengers = 0;
		internal decimal Cargo = 0;
		internal decimal PowerCells = 0;

		internal decimal AmmoWeight = 0;

		internal decimal EngineWeight = 0;
		internal decimal EngineCost = 0;

		internal decimal WeaponWeightEmpty = 0;
		internal decimal WeaponWeightOther = 0;
		internal decimal WeaponCost = 0;

		internal Shipt()
		{

		}

		internal List<object[]> BuildDataGrid()
		{
			List<object[]> Rows = new List<object[]>();

			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });
			Rows.Add(new Object[] { "Title", "Value" });

			return Rows;
		}
	}
}
