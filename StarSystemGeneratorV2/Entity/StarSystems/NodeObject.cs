using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class NodeObject
	{
		internal SystemEntity BaseEntity;
		internal TreeNode Node;

		Color ThisNodeColor = Color.Empty;

		internal NodeObject(SystemEntity BaseO, string Name, Color color)
		{
			BaseEntity = BaseO;
			Node = new TreeNode();

			Node.Name = Name;
			Node.Text = Name;
			Node.Tag = this;

			ThisNodeColor = color;
		}
	}
}
