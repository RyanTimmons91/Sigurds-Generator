using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Forms.SpecialGens.ArmorControls
{
	public partial class ArmorEquipmentMultiLevelControl : UserControl
	{
		ArmorEquipmentNode AEN;

		public ArmorEquipmentMultiLevelControl(ArmorEquipmentNode aen)
		{
			AEN = aen;
			InitializeComponent();

			_ItemDescription.Text = AEN.baseEquipment.Description;
			_weight.Text = AEN.baseEquipment.Weight + " KG";

			for(int i = 0; i < AEN.baseEquipment.Cost.Count; i++)
			{
				if(AEN.baseEquipment.Name == "Oxygen")
				{
					_bonusBox.Text = "1 Credit Per Hour of Oxygen";
					_level.Maximum = 100000;
				}
				else
				{
					_bonusBox.AppendText(AEN.baseEquipment.Bonuses[i] + Environment.NewLine + AEN.baseEquipment.Cost[i] + " GSC" + Environment.NewLine + "----" + Environment.NewLine);
				}
			}
		}

		private void _level_ValueChanged(object sender, EventArgs e)
		{
			if(AEN.baseEquipment.Name == "Oxygen")
			{
				_cost.Text = _level.Value + " GSC";
				return;
			}
			decimal level = _level.Value - 1;
			try
			{
				_cost.Text = AEN.baseEquipment.Cost[(int)level] + " GSC";
			}
			catch
			{
				_cost.Text = "";
			}
		}
	}
}
