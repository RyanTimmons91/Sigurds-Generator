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
    public partial class ArmorEquipmentSingleLevel: UserControl
    {
        public ArmorEquipmentSingleLevel(ArmorEquipmentNode AEN)
        {
            InitializeComponent();

			_ItemDescription.Text = AEN.baseEquipment.Description;
			_weight.Text = AEN.baseEquipment.Weight + " KG";
			_cost.Text = AEN.baseEquipment.Cost[0] + " Credits";
        }
	}
}
