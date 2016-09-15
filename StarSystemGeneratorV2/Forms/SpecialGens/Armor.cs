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
	public partial class Armor : Form
	{
		

		public Armor()
		{
			InitializeComponent();
			
			foreach (ArmorMaterial AM in ArmorMaterialWeightCost.ArmorMaterials)
			{
				_layers.Rows.Add(AM);
			}
		}
		
		internal decimal Num2Percent(int columnNumber)
		{
			switch(columnNumber)
			{
				case 1:
					return .04m;
				case 2:
					return .02m;
				case 3:
					return .05m;
				case 4:
					return .15m;
				case 5:
					return .15m;
				case 6:
					return .05m;
				case 7:
					return .02m;
				case 8:
					return .20m;
				case 9:
					return .03m;
				case 10:
					return .25m;
				case 11:
					return .04m;
				default:
					return 0;
			}
		}

		internal void FormUpdate()
		{
			decimal TotalCost = 0;
			decimal TotalWeight = 0;

			decimal[] Areas = new decimal[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

			bool firstMaterial = true;
			decimal Defense = 0; 

			//Layers
			foreach (DataGridViewRow row in _layers.Rows)
			{
				ArmorMaterial material = (ArmorMaterial)row.Cells[0].Value;

				for(int i = 1; i <= 11; i++)
				{
					object obj = row.Cells[i].Value;
					string s = (string)obj;
					if(!string.IsNullOrEmpty(s) && !string.IsNullOrWhiteSpace(s))
					{
						decimal count = decimal.Parse(s);

						if (count > 0)
						{
							decimal percentage = Num2Percent(i);

							TotalCost += count * percentage * material.Cost;
							TotalWeight += count * percentage * material.Weight;
							Areas[i - 1] += material.DD * count;

							if(i == 4) //chest
							{
								if(firstMaterial)
								{
									Defense = material.DEF;
								}
								else
								{
									if (material.DEF < Defense) Defense = material.DEF;
								}
							}
						}
					}
				}
			}

			//Bonuses and Optics
			/*
			 * 
			 * Oxygen (Hrs)
			 * Face Shield
			 * Flash Light (Squares)
			 * Temperature Control
			 * 
			 * Biomonitor Personal
			 * Biomonitor Remote
			 * Moly Chip Slot
			 * Camera
			 * Sattelite Uplink
			 * Gyro Stablizer
			 * Holo Projector
			 * Interface Plug
			 * Internal Defibrillator
			 * Irthop Coating
			 * Joint Reinforcement
			 * Magnetic Grip Pads
			 * Micrometric Tentacles
			 * Microwave / EMP Shielding
			 * Motion Detector
			 * Psychological Stress Evaluator
			 * Radar
			 * Reinforced Spine
			 * Self Destruct
			 * Sonar
			 * Strengthened Shoulders
			 * Weapon Link
			 * Webbing
			 * 
			 * Radio
			 * Radio - Audiovox
			 * Radio - Bullhorn
			 * Radio - Forked Tongue
			 * Radio - Synthesizer
			 * Radio - Voice Pattern
			 * Radio - HAS
			 * Radio - Audible Tracker
			 * Radio - Scrambler
			 * Radio - Descrambler
			 * Radio - Sensor Detector
			 * Radio - Recording Link
			 * Radio - Sound Dampner
			 * Radio - Subaudible
			 * Radio - Superaudible
			 * Radio - Encrypted Comm
			 * HUD - Anti Flash
			 * HUD - Coloration Change
			 * HUD - GPS
			 * HUD - IR
			 * HUD - Image Enhancer
			 * HUD - Low Light
			 * HUD - Maginification
			 * HUD - Night Vision
			 * HUD - Range Finder
			 * HUD - TADS
			 * HUD - Thermal
			 * HUD - Time / Date
			 * HUD - UV
			 * HUD - View Screen
			 * 
			 */

			//ExoSkeleton

			//DD Output
			_headDD.Text = "" + Areas[0];
			_neckDD.Text = "" + Areas[1];
			_shoulderDD.Text = "" + Areas[2];
			_chestDD.Text = "" + Areas[3];
			_stomachDD.Text = "" + Areas[4];
			_forearmsDD.Text = "" + Areas[5];
			_handsDD.Text = "" + Areas[6];
			_pelvisDD.Text = "" + Areas[7];
			_kneesDD.Text = "" + Areas[8];
			_lowerLegsDD.Text = "" + Areas[9];
			_feetDD.Text = "" + Areas[10];

			decimal PercentCoverage = 0;
			if (Areas[0] > 0) PercentCoverage += Num2Percent(1) * 10;
			if (Areas[1] > 0) PercentCoverage += Num2Percent(2) * 10;
			if (Areas[2] > 0) PercentCoverage += Num2Percent(3) * 10;
			if (Areas[3] > 0) PercentCoverage += Num2Percent(4) * 10;
			if (Areas[4] > 0) PercentCoverage += Num2Percent(5) * 10;
			if (Areas[5] > 0) PercentCoverage += Num2Percent(6) * 10;
			if (Areas[6] > 0) PercentCoverage += Num2Percent(7) * 10;
			if (Areas[7] > 0) PercentCoverage += Num2Percent(8) * 10;
			if (Areas[8] > 0) PercentCoverage += Num2Percent(9) * 10;
			if (Areas[9] > 0) PercentCoverage += Num2Percent(10) * 10;
			if (Areas[10] > 0) PercentCoverage += Num2Percent(11) * 10;

			_initsToDon.Text = Math.Ceiling(PercentCoverage) + "";

			//Defense Ouptut
			_defense.Text = "" + Defense;

			//Total Output
			_totalCost.Text = TotalCost + "";
			if(_exoSkeleton.Checked)
			{
				TotalWeight *= 1.25m;
			}
			_totalWeight.Text = TotalWeight + "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormUpdate();
		}
		
		private void Armor_Load(object sender, EventArgs e)
		{
			foreach(ArmorEquipment ae in ArmorEquipmentClass.RootEquipment)
			{
				_equipmentIndex.Nodes.Add(ae.GetNode());
			}
		}

		private void _equipmentIndex_AfterSelect(object sender, TreeViewEventArgs e)
		{
			splitContainer2.Panel2.Controls.Clear();

			if (_equipmentIndex.SelectedNode != null)
			{
				ArmorEquipment AE = (ArmorEquipment)_equipmentIndex.SelectedNode.Tag;
				//TODO this currently destroys the panel when the selection is changed, find a way to make it persistent!

				ArmorControls.ArmorEquipmentMultiLevelControl AEMC = new ArmorControls.ArmorEquipmentMultiLevelControl();
				AEMC.Dock = DockStyle.Fill;

				AEMC._ItemDescription.Text = AE.Description;

				if (AE.Bonuses != null)
				{
					MessageBox.Show("NOT NULL");
					foreach (string s in AE.Bonuses)
					{
						AEMC._bonusBox.AppendText(s + Environment.NewLine);
					}
				}
				else
				{
					MessageBox.Show("ISNULL");
				}

				if(AE.Levels > 1)
				{
					AEMC._installed.Enabled = false;
					AEMC._level.Enabled = true;
				}
				else
				{
					AEMC._installed.Enabled = true;
					AEMC._level.Enabled = false;
				}

				AEMC._weight.Text = AE.Weight + "";
				AEMC._cost.Text = AE.Cost + "";

				splitContainer2.Panel2.Controls.Add(AEMC);
			}
		}


		private void _layers_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
		{
			FormUpdate();
		}

		private void _exoSkeleton_CheckedChanged(object sender, EventArgs e)
		{
			FormUpdate();
		}
	}
}
