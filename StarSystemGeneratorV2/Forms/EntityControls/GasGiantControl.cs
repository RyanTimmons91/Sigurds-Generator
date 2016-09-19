using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarSystemGeneratorV2.Entity.StarSystems;

namespace StarSystemGeneratorV2.EntityControls
{
	public partial class GasGiantControl : UserControl
	{
		internal GasGiantControl(SystemEntity se)
		{
			InitializeComponent();

			Planet planet = (Planet)se;

			_sizeBox.Text = planet.Size.ToString();
			_gasGiantType.Text = planet.GGS.ToString();
			
			foreach (AtmosphereTypes AT in planet.gasAtmospheres)
			{
				_otherAtmospheres.Items.Add(AT);
			}
		}
	}
}
