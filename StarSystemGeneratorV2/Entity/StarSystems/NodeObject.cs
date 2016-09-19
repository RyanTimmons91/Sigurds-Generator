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

		internal NodeObject(SystemEntity BaseO, string Name)
		{			
			BaseEntity = BaseO;
			Node = new TreeNode();

			Node.Name = Name;
			Node.Text = Name;
			Node.Tag = this;
		}
	}
}
