using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarSystemGeneratorV2.Entity;

namespace StarSystemGeneratorV2.EntityControls
{
	public partial class GasGiantControl : UserControl
	{
		Planet planet;

		internal GasGiantControl(Planet p)
		{
			InitializeComponent();

			planet = p;

			_sizeBox.Text = p.Size.ToString();
			_gasGiantType.Text = p.GasGiantType.ToString();
			_lostCivBox.Text = p.LostCivilization.ToString();

			foreach (AtmosphereTypes AT in p.GasGiantAtmospheres)
			{
				_otherAtmospheres.Items.Add(AT);
			}
		}
	}
}
