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
	public partial class DebrisRingControl : UserControl
	{
		DebrisRing debrisRing;
		CelestialObject celestialObject;

		internal DebrisRingControl(DebrisRing d)
		{
			InitializeComponent();

			debrisRing = d;

			_resourceTypeBox.Text = d.Size.ToString();

			int i = 1;

			foreach(Resource[] Rarray in d.ResourceSectors)
			{
				TreeNode tn = _resourceOutput.Nodes.Add("Sector " + i);

				for (int i2 = 0; i2 < Rarray.Length; i2++)
				{
					if (Rarray[i2] == null) continue;
					tn.Nodes.Add(Rarray[i2].ResourceType + " " + Rarray[i2].DepositSize);
				}

				i++;
			}
		}
		internal DebrisRingControl(CelestialObject c)
		{
			InitializeComponent();
			
			celestialObject = c;

			_resourceTypeBox.Text = c.CelestialBody.ToString();

			int i = 1;

			foreach (Resource[] Rarray in c.ResourceSectors)
			{
				TreeNode tn = _resourceOutput.Nodes.Add("Sector " + i);

				for (int i2 = 0; i2 < Rarray.Length; i2++)
				{
					if (Rarray[i2] == null) continue;
					tn.Nodes.Add(Rarray[i2].ResourceType + " " + Rarray[i2].DepositSize);
				}

				i++;
			}
		}
	}
}
