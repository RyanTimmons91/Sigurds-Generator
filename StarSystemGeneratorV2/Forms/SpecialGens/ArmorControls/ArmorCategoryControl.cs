﻿using System;
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
	public partial class ArmorCategoryControl : UserControl
	{
		public ArmorCategoryControl(ArmorEquipmentNode AEN)
		{
			InitializeComponent();

			_categoryText.Text = AEN.baseEquipment.Description;
		}
	}
}
