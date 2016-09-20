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
			
			foreach(TreeNode node in _equipmentIndex.Nodes)
			{
				TotalCost += cost(node);
				TotalWeight += weight(node);

				foreach(TreeNode snode in node.Nodes)
				{
					TotalCost += cost(snode);
					TotalWeight += weight(snode);
				}
			}

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

		decimal cost(TreeNode node)
		{
			ArmorEquipmentNode AEN = (ArmorEquipmentNode)node.Tag;
			
			if(AEN.baseEquipment.Cost.Count == 1)
			{
				ArmorControls.ArmorEquipmentSingleLevel single = (ArmorControls.ArmorEquipmentSingleLevel)AEN.ArmorControl;

				if (single._isInstalled.Checked) return AEN.baseEquipment.Cost[0];
			}
			else if(AEN.baseEquipment.Cost.Count > 1)
			{
				ArmorControls.ArmorEquipmentMultiLevelControl multiple = (ArmorControls.ArmorEquipmentMultiLevelControl)AEN.ArmorControl;

				if (AEN.baseEquipment.Name == "Oxygen")
				{
					return multiple._level.Value;
				}

				if (multiple._level.Value > 0)
				{
					return AEN.baseEquipment.Cost[(int)(multiple._level.Value - 1)];
				}
			}

			return 0;
		}
		decimal weight(TreeNode node)
		{
			ArmorEquipmentNode AEN = (ArmorEquipmentNode)node.Tag;

			if (AEN.baseEquipment.Cost.Count == 1)
			{
				ArmorControls.ArmorEquipmentSingleLevel single = (ArmorControls.ArmorEquipmentSingleLevel)AEN.ArmorControl;

				if (single._isInstalled.Checked) return AEN.baseEquipment.Weight;
			}
			else if (AEN.baseEquipment.Cost.Count > 1)
			{
				ArmorControls.ArmorEquipmentMultiLevelControl multiple = (ArmorControls.ArmorEquipmentMultiLevelControl)AEN.ArmorControl;

				if (multiple._level.Value > 0) return AEN.baseEquipment.Weight;
			}

			return 0;
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
				ArmorEquipmentNode AE = (ArmorEquipmentNode)_equipmentIndex.SelectedNode.Tag;
				
				splitContainer2.Panel2.Controls.Add(AE.ArmorControl);
			}

			FormUpdate();
		}


		private void _layers_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
		{
			FormUpdate();
		}

		private void _exoSkeleton_CheckedChanged(object sender, EventArgs e)
		{
			FormUpdate();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(tabControl1.SelectedIndex == 2) //Bonuses Tab
			{
				string Bonuses = "";
				Bonuses += MaterialBonuses();
				Bonuses += EquipmentBonuses();

				_bonuses.Text = Bonuses;
			}
		}

		string MaterialBonuses()
		{
			string r = "";

			foreach (DataGridViewRow row in _layers.Rows)
			{
				decimal count = 0;
				for (int i = 1; i < 12; i++)
				{
					object obj = row.Cells[i].Value;
					string s = (string)obj;
					if (!string.IsNullOrEmpty(s) && !string.IsNullOrWhiteSpace(s))
					{
						decimal Icount = decimal.Parse(s);
						count += Icount;
					}
				}
				if (count > 0)
				{
					ArmorMaterial material = (ArmorMaterial)row.Cells[0].Value;

					r += NumToString(material.ID) + Environment.NewLine;
				}
			}

			return r;
		}
		string NumToString(int num)
		{
			string r = "";

			switch(num)
			{
				case 0://new ArmorMaterial(0, "Mono-Film", 1, 9, 0.7m, 110),
					return "Reduces Slashing Damage by 5%";
				case 1://new ArmorMaterial(1, "Spider-Silk", 2, 8, 0.5m, 205),
					return "Reduces Slashing Damage by 10%";
				case 2://new ArmorMaterial(2, "Thermal Spider Silk", 2, 8, 0.9m, 700),
					return "Reduces Slashing Damage by 10%";
				case 3://new ArmorMaterial(3, "Leather", 3, 7, 13.4m, 435),
					return "Reduces Slashing Damage by 10%";
				case 4://new ArmorMaterial(4, "Semi-Liquid Nanno-Carbons", 3, 7, 0.9m, 390),
					return "Reduces Electrical Damage by 10%";
				case 5://new ArmorMaterial(5, "Nanno-Pore", 4, 6, 3.6m, 440),
					return "Reduces Piercing Damage by 5%";
				case 6://new ArmorMaterial(6, "Kevlar	5", 5, 5, 8.9m, 590),
					return "Reduces Slashing Damage by 15%";
				case 7://new ArmorMaterial(7, "Bio-Tex", 6, 4, 0.6m, 1210),
					return "Reduces Electrical Damage by 25%";
				case 8://new ArmorMaterial(8, "Nanno-Tex", 6, 4, 1.2m, 615),
					return "Reduces Electrical Damage by 15%";
				case 9://new ArmorMaterial(9, "Ceramo-Plast", 7, 3, 12m, 715),
					return "Reduces Energy Damage by 5%";
				case 10://new ArmorMaterial(10, "Flexi-Plasti-Steel", 8, 2, 11.1m, 910),
					return "Reduces Bludgeoning Damage by 10%";
				case 11://new ArmorMaterial(11, "Carbon Fiber", 9, 1, 6.7m, 970),
					return "Reduces Piercing Damage by 25%";
				case 12://new ArmorMaterial(12, "Plasti-Steel", 10, 0, 15.6m, 1155),
					return "Reduces Bludgeoning Damage by 10%";
				case 13://new ArmorMaterial(13, "Nanno-Carbon Fiber Weave", 11, -1, 14.9m, 1250),
					return "Reduces Piercing Damage by 30%";
				case 14://new ArmorMaterial(14, "Ceramo-Steel", 12, -2, 17.8m, 1380),
					return "Reduces Energy Damage by 10%";
				case 15://new ArmorMaterial(15, "Lightweight Titanium", 13, -3, 20m, 1600),
					return "Reduces Heat/Fire Damage by 10%";
				case 16://new ArmorMaterial(16, "Dimonotanium-Ceramatite", 15, -5, 20.4m, 1705),
					return "Reduces Energy Damage by 15%";
				case 17://new ArmorMaterial(17, "Dibitanium-Ceramatite", 20, -10, 40.8m, 2410),
					return "Reduces Energy Damage by 20%";
				case 18://new ArmorMaterial(18, "Ditritanium-Ceramatite", 25, -15, 61.3m, 3115),
					return "Reduces Energy Damage by 25%";
			}
			return r;
		}
		
		string EquipmentBonuses()
		{
			string r = "";

			foreach(TreeNode t in _equipmentIndex.Nodes)
			{
				r += GetEquipBonuses(t);
			}

			return r;
		}
		string GetEquipBonuses(TreeNode n)
		{
			string r = "";

			ArmorEquipmentNode AEN = (ArmorEquipmentNode)n.Tag;

			if (AEN.baseEquipment.Name == "Oxygen")
			{
				var control = (ArmorControls.ArmorEquipmentMultiLevelControl)AEN.ArmorControl;

				if (control._level.Value > 0)
				{
					r += control._level.Value + " Hours of Oxygen";
				}
			}
			else
			{
				if (AEN.baseEquipment.Cost.Count == 1)
				{
					var control = (ArmorControls.ArmorEquipmentSingleLevel)AEN.ArmorControl;

					if (control._isInstalled.Checked)
					{
						r += AEN.baseEquipment.Bonuses[0] + Environment.NewLine;
					}
				}
				if (AEN.baseEquipment.Cost.Count > 1)
				{
					var control = (ArmorControls.ArmorEquipmentMultiLevelControl)AEN.ArmorControl;

					if (control._level.Value > 0)
					{
						r += AEN.baseEquipment.Bonuses[(int)(control._level.Value - 1)] + Environment.NewLine;
					}
				}
			}
			
			foreach(TreeNode t in n.Nodes)
			{
				r += GetEquipBonuses(t);
			}

			return r;
		}

		private void _formUpdateButton_Click(object sender, EventArgs e)
		{
			FormUpdate();
		}

		private void _resetForm_Click(object sender, EventArgs e)
		{
			Armor m = new Armor();
			m.Show();
			m.Location = this.Location;
			this.Close();
		}
	}
}
