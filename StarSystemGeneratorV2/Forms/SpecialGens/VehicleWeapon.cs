using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Forms
{
	public partial class WeaponCost : Form
	{
		public WeaponCost()
		{
			InitializeComponent();
		}
		
		private void WeaponCost_Load(object sender, EventArgs e)
		{

		}

		private void _close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ValueChanged(object sender, EventArgs e)
		{
			UpdateOutput();
		}

		private void _damageType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(_energyRadio.Checked)
			{
				_weight.Text = _damage.Value * .25m + " KG";
			}
			if(_ballisticRadio.Checked)
			{
				_weight.Text = _damage.Value * 1.5m + " KG";
			}
			if(_gravRadio.Checked)
			{
				_weight.Text = _damage.Value * 2 + " KG";
			}
			if(_caselessRadio.Checked)
			{
				_weight.Text = _damage.Value * .75m + " KG";
			}
		}

		internal void UpdateOutput()
		{
			int value = 0; ;

			if (_semiAuto.Checked) value += 1000;
			if (_burstFire.Checked) value += 1500;
			if (_fullAuto.Checked) value += 3000;

			value += ((int)_capacity.Value * 10);
			value += ((int)_damage.Value * 10);
			value += ((int)_range.Value * 10);
			value += ((int)_radius.Value * 10);

			_weaponValue.Text = value + "";
		}
	}
}
