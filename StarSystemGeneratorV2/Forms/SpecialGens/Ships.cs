using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Forms.SpecialGens
{
	public partial class Ships : Form
	{
		bool isUpdatingCells = false;

		internal Entity.Ship ship = new Entity.Ship();

		public Ships()
		{
			InitializeComponent();
		}

		private void Mecha_Load(object sender, EventArgs e)
		{
			foreach (ShipMaterial m in ShipMaterialWeightCost.VehicleMaterials)
			{
				_chassisMaterial.Items.Add(m);
				_armorMaterial.Items.Add(m);
			}
		}

		private void _shieldClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_shieldClass.SelectedIndex == -1) return;

			_shieldsBox.Items.Clear();
			_shieldsBox.SelectedItem = -1;
			_shieldsBox.SelectedText = "";
			_shieldsBox.Text = "";
			_shieldsBox.SelectedItem = null;

			if (_shieldClass.SelectedIndex == 0)//Civilian
			{
				foreach (ShipShield s in ShipShieldType.CivilianShields)
				{
					_shieldsBox.Items.Add(s);
				}
			}

			if (_shieldClass.SelectedIndex == 1)//Military
			{
				foreach (ShipShield s in ShipShieldType.MilitaryVehicles)
				{
					_shieldsBox.Items.Add(s);
				}
			}
		}

		private void FormValueChanged(object sender, EventArgs e)
		{
			UpdateOutput();
		}
		private void _ammoGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (isUpdatingCells) return;

			isUpdatingCells = true;
			
			foreach (DataGridViewRow row in _ammoGrid.Rows)
			{
				try
				{
					row.Cells[3].Value = decimal.Parse(row.Cells[1].Value + "") * decimal.Parse(row.Cells[2].Value + "");
					row.ErrorText = "";
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
					row.ErrorText = "Invalid Value, please use ONLY numbers and decimal points!";
				}
			}

			isUpdatingCells = false;
			UpdateOutput();
		}
		private void _engineGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (isUpdatingCells) return;

			isUpdatingCells = true;

			foreach(DataGridViewRow row in _engineGrid.Rows)
			{
				try
				{
					decimal count = decimal.Parse("" + row.Cells[1].Value);
					decimal speed = decimal.Parse("" + row.Cells[2].Value);

					decimal weight = (speed / 1000) * count;
					decimal cost = weight * 100000;

					row.Cells[3].Value = weight;
					row.Cells[4].Value = cost;

					row.ErrorText = "";
				}
				catch
				{
					row.ErrorText = "Invalid Value, please use ONLY numbers and decimal points!";
				}
			}

			isUpdatingCells = false;
			UpdateOutput();
		}
		
		internal void UpdateOutput()
		{
			ship.Height = _shipHeight.Value;
			ship.Length = _shipLength.Value;
			ship.Width = _shipWidth.Value;

			ship.YearsInProduction = _yearsInProduction.Value;

			#region Chassis
			if(_chassisMaterial.SelectedIndex != -1)
			{
				ship.isChassisMaterialSet = true;
				ship.ChassisMaterial = (ShipMaterial)_chassisMaterial.SelectedItem;
				ship.ChassisThickness = _chassisThickness.Value;
			}
			else
			{
				ship.isChassisMaterialSet = false;
			}
			#endregion
			#region Armor
			if(_armorMaterial.SelectedIndex != -1)
			{
				ship.isArmorMaterialSet = true;
				ship.Armormaterial = (ShipMaterial)_armorMaterial.SelectedItem;
				ship.ArmorThickness = _armorThickness.Value;
			}
			else
			{
				ship.isArmorMaterialSet = false;
			}
			#endregion
			#region Shields
			if(_shieldsBox.SelectedIndex != -1)
			{
				ship.isShieldSet = true;
				ship.ShipShield = (ShipShield)_shieldsBox.SelectedItem;
			}
			else
			{
				ship.isShieldSet = false;
			}
			#endregion
			#region Sensors, Chaff, Passengers, Cargo, PowerCells
			ship.SensorCount = _sensorCount.Value;
			ship.ChaffFlare = _chaffFlares.Value;
			ship.Passengers = _passengerWeight.Value;
			ship.Cargo = _cargoWeight.Value;
			ship.PowerCells = _powerCells.Value;
			#endregion
			#region Ammo
			decimal AmmoWeight = 0;
			foreach (DataGridViewRow row in _ammoGrid.Rows)
			{
				try
				{
					AmmoWeight += Decimal.Parse(row.Cells[3].Value + "");
				}
				catch
				{ }
			}
			ship.AmmoWeight = AmmoWeight;
			#endregion
			#region Engines
			decimal EngineWeight = 0;
			decimal EngineCost = 0;
			foreach (DataGridViewRow row in _engineGrid.Rows)
			{
				try
				{
					EngineWeight += Decimal.Parse(row.Cells[3].Value + "") * 1000;
					EngineCost += Decimal.Parse(row.Cells[4].Value + "");
				}
				catch
				{ }
			}
			ship.EngineCost = EngineCost;
			ship.EngineWeight = EngineWeight;
			#endregion
			#region Turrets and Missiles
			if (_pointDefenseTurretType_Dorsal.SelectedIndex != -1)
			{
				ship.TurretPDDosalType = TurretMark.PointDefenseTurrets[_pointDefenseTurretType_Dorsal.SelectedIndex];
				ship.TurretPDDorsalCount = _pointDefenseTurretCount_Dorsal.Value;
			}
			if (_pbpTurretType_Dorsal.SelectedIndex != -1)
			{
				ship.TurretPBPDorsalType = TurretMark.ParticleBeamProjectorTurrets[_pbpTurretType_Dorsal.SelectedIndex];
				ship.TurretPBPDorsalCount = _pbpTurretCount_Dorsal.Value;
			}
			if (_pointDefenseTurretType_Ventral.SelectedIndex != -1)
			{
				ship.TurretPDVentralType = TurretMark.PointDefenseTurrets[_pointDefenseTurretType_Ventral.SelectedIndex];
				ship.TurretPDVentralCount = _pointDefenseTurretCount_Ventral.Value;
			}
			if (_pbpTurretType_Ventral.SelectedIndex != -1)
			{
				ship.TurretPBPVentralType = TurretMark.ParticleBeamProjectorTurrets[_pbpTurretType_Ventral.SelectedIndex];
				ship.TurretPBPVentralCount = _pbpTurretCount_Ventral.Value;
			}
			if (_pointDefenseMissileType.SelectedIndex != -1)
			{
				ship.MissileTubeType = TurretMark.PointDefenseMissileTube[_pointDefenseMissileType.SelectedIndex];
				ship.MissileTubeCount = _pointDefenseMissileCount.Value;
			}
			ship.SubCapitalMissileTubeCount = _subCapitalCount.Value;
			ship.CapitalMissileTubeCount = _capitalCount.Value;
			#endregion

			//TODO space speed based off of empty weight of the ship
		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Ships s = new Ships();
			s.Show();
			s.Location = this.Location;
			this.Close();
		}

		private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ShipResults(ship).Show();
		}
		
		private void PointDefenseStuff_ValueChanged(object sender, EventArgs e)
		{
			TurretType D_PDTType = null;
			TurretType D_PBPType = null;
			TurretType V_PDTType = null;
			TurretType V_PBPType = null;
			TurretType PDMType = null;
			TurretType SubCapital = TurretMark.SubCapitolMissileTube[0];
			TurretType Capital = TurretMark.CapitolMissileTube[0];
			
			decimal DorsalUsage = 0;
			decimal VentralUsage = 0;
			decimal BroadsideUsage = 0;

			if (_pointDefenseTurretType_Dorsal.SelectedIndex != -1)
			{
				D_PDTType = TurretMark.PointDefenseTurrets[_pointDefenseTurretType_Dorsal.SelectedIndex];
				DorsalUsage += D_PDTType.space * _pointDefenseTurretCount_Dorsal.Value;
			}
			if (_pbpTurretType_Dorsal.SelectedIndex != -1)
			{
				D_PBPType = TurretMark.ParticleBeamProjectorTurrets[_pbpTurretType_Dorsal.SelectedIndex];
				DorsalUsage += D_PBPType.space * _pbpTurretCount_Dorsal.Value;
			}
			if (_pointDefenseTurretType_Ventral.SelectedIndex != -1)
			{
				V_PDTType = TurretMark.PointDefenseTurrets[_pointDefenseTurretType_Ventral.SelectedIndex];
				VentralUsage += V_PDTType.space * _pointDefenseTurretCount_Ventral.Value;
			}
			if (_pbpTurretType_Ventral.SelectedIndex != -1)
			{
				V_PBPType = TurretMark.ParticleBeamProjectorTurrets[_pbpTurretType_Ventral.SelectedIndex];
				VentralUsage += V_PBPType.space * _pbpTurretCount_Ventral.Value;
			}
			if (_pointDefenseMissileType.SelectedIndex != -1)
			{
				PDMType = TurretMark.PointDefenseMissileTube[_pointDefenseMissileType.SelectedIndex];
				BroadsideUsage += PDMType.space * _pointDefenseMissileCount.Value;
			}

			BroadsideUsage += SubCapital.space * _subCapitalCount.Value;
			BroadsideUsage += Capital.space * _capitalCount.Value;

			_dorsalRemaining.Text = _shipLength.Value - DorsalUsage + " Meters Left";
			_ventralRemaining.Text = _shipLength.Value - VentralUsage + " Meters Left";
			_broadsideRemaining.Text = _shipLength.Value - BroadsideUsage + " Meters Left";

			if(DorsalUsage > _shipLength.Value)
			{
				_dorsalBox.BackColor = Color.Salmon;
			}
			else
			{
				_dorsalBox.BackColor = SystemColors.Control;
			}

			if (VentralUsage > _shipLength.Value)
			{
				_ventralBox.BackColor = Color.Salmon;
			}
			else
			{
				_dorsalBox.BackColor = SystemColors.Control;
			}

			if (BroadsideUsage > _shipLength.Value)
			{
				_broadsideBox.BackColor = Color.Salmon;
			}
			else
			{
				_broadsideBox.BackColor = SystemColors.Control;
			}

			UpdateOutput();
		}
	}
}
