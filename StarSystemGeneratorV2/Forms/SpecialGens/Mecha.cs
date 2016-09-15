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
	public partial class Mecha : Form
	{
		bool isUpdatingCells = false;

		public Mecha()
		{
			InitializeComponent();
		}

		private void Mecha_Load(object sender, EventArgs e)
		{
			foreach (VehicleMaterial m in VehicleMaterialWeightCost.VehicleMaterials)
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

			if (_shieldClass.SelectedIndex == 0)
			{
				foreach (Shield s in ShieldType.CivilianShields)
				{
					_shieldsBox.Items.Add(s);
				}
			}

			if (_shieldClass.SelectedIndex == 1)
			{
				foreach (Shield s in ShieldType.MilitaryVehicles)
				{
					_shieldsBox.Items.Add(s);
				}
			}

			if (_shieldClass.SelectedIndex == 2)
			{
				foreach (Shield s in ShieldType.MilitaryAuxiliary)
				{
					_shieldsBox.Items.Add(s);
				}
			}
		}
		private void _generators_CheckedChanged(object sender, EventArgs e)
		{
			//Generators or Cells?
			if (_cells.Checked)
			{
				_energyCountWatts.DecimalPlaces = 0;
				_countOrPettaWattLabel.Text = "Cell Count:";
			}
			if (_generators.Checked)
			{
				_energyCountWatts.DecimalPlaces = 5;
				_countOrPettaWattLabel.Text = "Petawatts:";
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
		private void _weaponGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (isUpdatingCells) return;

			isUpdatingCells = true;

			foreach (DataGridViewRow row in _weaponGrid.Rows)
			{
				try
				{
					decimal count = decimal.Parse("" + row.Cells[2].Value);
					decimal weight = decimal.Parse("" + row.Cells[3].Value);
					decimal cost = decimal.Parse("" + row.Cells[4].Value);

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
			decimal ObjectVolume = _mechaHeight.Value * _mechaLength.Value * _mechaWidth.Value;

			decimal TotalWeight = 0;
			decimal TotalCost = 0;
			decimal TotalEmptyWeight = 0;
			try
			{
				//Chassis
				if (_chassisMaterial.SelectedIndex != -1)
				{
					decimal ChassisWeight = (decimal)((VehicleMaterial)_chassisMaterial.SelectedItem).weight * _chassisThickness.Value * ObjectVolume;
					_chassisWeight.Text = string.Format("{0:G29}", (ChassisWeight / 1000)) + " MT";
					TotalWeight += ChassisWeight;
					TotalCost += (decimal)((VehicleMaterial)_chassisMaterial.SelectedItem).cost * _chassisThickness.Value * ObjectVolume;

				}

				//Armor
				if (_armorMaterial.SelectedIndex != -1)
				{
					decimal Armorweight = (decimal)((VehicleMaterial)_armorMaterial.SelectedItem).weight * _armorThickness.Value * ObjectVolume;
					_armorWeight.Text = string.Format("{0:G29}", (Armorweight / 1000)) + " MT";
					TotalWeight += Armorweight;
					TotalCost += (decimal)((VehicleMaterial)_armorMaterial.SelectedItem).weight * _armorThickness.Value * ObjectVolume;
				}

				//Myomar Musculature
				if (_movementSquares.Value > 0)
				{
					decimal MyomarWeight = (ObjectVolume / 100);
					_myomarWeight.Text = string.Format("{0:G29}", (MyomarWeight)) + " MT";
					TotalWeight += MyomarWeight * 1000;
					decimal MyomarCost = _movementSquares.Value * 10;
					_myomarCost.Text = string.Format("{0:G29}", (MyomarCost)) + "";
					TotalCost += MyomarCost;
				}
				else
				{
					_myomarWeight.Text = "";
					_myomarCost.Text = "";
				}

				//Hydrolic Actuator Systems (Carry Weight)
				decimal HASWeight = _movementSquares.Value * .1m;
				_hasWeight.Text = string.Format("{0:G29}", (HASWeight)) + " MT";
				TotalWeight += HASWeight * 1000;
				decimal HASCost = HASWeight * 10000;
				_hasCost.Text = string.Format("{0:G29}", (HASCost)) + "";
				TotalCost += HASCost;
				_carryWeight.Text = string.Format("{0:G29}", (HASWeight * 10)) + " MT";

				//Shields
				if (_shieldsBox.SelectedIndex != -1)
				{
					decimal ShieldCount = ObjectVolume / ((Shield)_shieldsBox.SelectedItem).coverage;
					ShieldCount = Math.Ceiling(ShieldCount);
					_shieldCount.Text = string.Format("{0:G29}", (ShieldCount)) + " Shields";
					TotalWeight += ShieldCount * ((Shield)_shieldsBox.SelectedItem).weight;
					TotalCost += ShieldCount * ((Shield)_shieldsBox.SelectedItem).cost;
				}

				//Energy
				if (_cells.Checked)
				{
					TotalWeight += _energyCountWatts.Value * 23;
					TotalCost += _energyCountWatts.Value * 1000;
				}
				if (_generators.Checked)
				{
					TotalWeight += _energyCountWatts.Value * 10000;
					TotalCost += _energyCountWatts.Value * 1000000;
				}
				
				//Sensors
				decimal TotalSensorCost = 0;
				TotalSensorCost += _sensorCount.Value * 1000;
				TotalSensorCost += _chaffFlares.Value * 100;
				_sensorsCost.Text = string.Format("{0:G29}", (TotalSensorCost)) + "";
				TotalCost += TotalSensorCost;
				decimal TotalSensorWeight = 0;
				TotalSensorWeight += _sensorCount.Value * 50;
				_sensorWeight.Text = string.Format("{0:G29}", (TotalSensorWeight / 1000)) + " MT";
				TotalWeight += TotalSensorWeight;


				//Engines
				foreach (DataGridViewRow row in _engineGrid.Rows)
				{
					try
					{
						TotalWeight += Decimal.Parse(row.Cells[3].Value + "") * 1000;
						TotalCost += Decimal.Parse(row.Cells[4].Value + "");
					}
					catch
					{ }
				}


				TotalEmptyWeight = TotalWeight;

				//Weapons
				//NOTE THAT BUILT IN WEAPONS ARE ADDED TO EMPTY WEIGHT
				foreach(DataGridViewRow row in _weaponGrid.Rows)
				{
					try
					{
						Console.WriteLine("Weapon Found");
						bool builtin = Convert.ToBoolean(row.Cells[0].Value); //IF NOT BUILT IN DO NOT ADD TO COST
						Console.WriteLine("Built in " + builtin);

						decimal count = decimal.Parse((string)row.Cells[2].Value);
						decimal weight = decimal.Parse((string)row.Cells[3].Value) * 1000;
						decimal cost = decimal.Parse((string)row.Cells[4].Value);

						if (builtin)
						{
							TotalEmptyWeight += count * weight;
							TotalWeight += count * weight;
							TotalCost += count * cost;
						}
						else
						{
							TotalWeight += count * weight;
						}
					}
					catch
					{

					}
				}
				
				//----------------
				//OPERATING WEIGHT
				//----------------

				//Additional Weight
				TotalWeight += _passengerWeight.Value * 250;
				TotalWeight += _cargoWeight.Value * 1000;
				TotalWeight += _powerCells.Value * (decimal)6.75;

				//AMMO
				foreach (DataGridViewRow row in _ammoGrid.Rows)
				{
					try
					{
						TotalWeight += Decimal.Parse(row.Cells[3].Value + "");
					}
					catch
					{ }
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
			}
			_emptyWeight.Text = string.Format("{0:G29}", (TotalEmptyWeight / 1000)) + " MT";
			_totalWeight.Text = "" + string.Format("{0:G29}", (TotalWeight / 1000)) + " MT";

			_totalCost.Text = string.Format("{0:G29}", TotalCost) + "";
			_maintCost.Text = string.Format("{0:G29}", (TotalCost * .01m)) + "";
		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Mecha m = new Mecha();
			m.Show();
			m.Location = this.Location;
			this.Close();
		}

	}
}
