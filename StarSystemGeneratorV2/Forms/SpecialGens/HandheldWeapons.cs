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
	public partial class HandheldWeapons : Form
	{
		public HandheldWeapons()
		{
			InitializeComponent();
		}

		private void HandheldWeapons_Load(object sender, EventArgs e)
		{
			foreach(WeaponType weapon in WeaponTypeClass.WeaponTypes)
			{
				_weaponType.Items.Add(weapon);
			}

			foreach(WeaponDamageType wpt in WeaponDamageTypeClass.WeaponDamageTypes)
			{
				_damageType.Items.Add(wpt);
			}

			foreach(Condition condition in ConditionClass.Conditions)
			{
				_condition.Items.Add(condition);
			}

			foreach(Accesory acc in AccesoryList.Accesories)
			{
				_accesories.Items.Add(acc);
			}
		}

		private void FormValueChanged(object sender, EventArgs e)
		{
			UpdateOutput();
		}
		private void _accesories_KeyUp(object sender, KeyEventArgs e)
		{
			UpdateOutput();
		}
		private void _accesories_MouseUp(object sender, MouseEventArgs e)
		{
			UpdateOutput();
		}

		internal void UpdateOutput()
		{
			decimal TotalWeight = 0;
			decimal TotalCost = 0;

			//Base Cost / Weight
			if (_weaponType.SelectedIndex != -1)
			{
				WeaponType weaponType = (WeaponType)_weaponType.SelectedItem;
				TotalWeight += weaponType.baseweight;
				TotalCost += weaponType.baseprice;
			}

			//Damage Type
			if (_damageType.SelectedIndex != -1)
			{
				WeaponDamageType weaponDamageType = (WeaponDamageType)_damageType.SelectedItem;
				TotalWeight *= weaponDamageType.weightModifier;
				TotalCost *= weaponDamageType.costModifier;
			}

			//Condition
			if (_condition.SelectedIndex != -1)
			{
				Condition condition = (Condition)_condition.SelectedItem;
				TotalCost *= condition.costMod;
			}

			//Availability
			decimal Availability = _availability.Value;
			Availability *= -1;
			Availability /= 10;
			Availability = Availability + 1;
			TotalCost *= Availability;

			//ROF
			if (_ssCheck.Checked)
				TotalCost += 0;
			if (_saCheck.Checked)
				TotalCost += 100;
			if (_bfCheck.Checked)
				TotalCost += 150;
			if (_faCheck.Checked)
				TotalCost += 300;

			//Range
			TotalCost += _range.Value * 5;

			//Radius
			TotalCost += _radius.Value * 5;

			//Capacity
			TotalCost += _capacity.Value * 2.5m;

			//Damage
			TotalCost += _damage.Value;

			//TODO change weight per damange based on damage type
			TotalWeight += _damage.Value * .0625m;
			//--

			//Superior
			if (_superior.Checked)
				TotalCost *= 1.25m;

			//Pic Rails
			TotalCost += _picRails.Value * 45;

			//Accesories
			foreach (Accesory CLBI in _accesories.CheckedItems)
			{
				TotalWeight += CLBI.weight;
				TotalCost += CLBI.cost;
			}

			//Lightweight
			if (_lightweight.Checked) TotalWeight *= .5m;
			if (_lightweight.Checked) TotalCost *= 1.75m;

			//Output
			_totalWeight.Text = TotalWeight + " KG";
			_totalCost.Text = TotalCost + " Credits";
		}
	}
}
