using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace StarSystemGeneratorV2
{
	class NodeObject
	{
		internal Entity.EntityTypes BaseType;
		internal dynamic BaseObject;
		internal TreeNode Node;

		internal int SystemNumber = 0;

		internal bool HasLivingCiv = false;
		internal bool HasLostCiv = false;

		Color ThisNodeColor = Color.Empty;

		internal NodeObject(int sysNumber, object BaseO, Entity.EntityTypes type, string Name)
		{
			SystemNumber = sysNumber;
			BaseObject = BaseO;
			BaseType = type;
			Node = new TreeNode();
			Node.Name = Name;
			Node.Text = Name;
			Node.Tag = this;

			if(BaseType == Entity.EntityTypes.Moon || BaseType == Entity.EntityTypes.Planet)
			{
				if(BaseObject.LivingCivilization != Entity.Civilization.NoCiv)
				{
					HasLivingCiv = true;
				}
				if (BaseObject.LostCivilization != Entity.Civilization.NoCiv)
				{
					HasLostCiv = true;
				}
			}
		}

		internal void SetColor()
		{
			foreach(TreeNode n in Node.Nodes)
			{
				NodeObject NO = (NodeObject)n.Tag;

				if (NO == null) continue;

				NO.SetColor();

				if (NO.HasLivingCiv) HasLivingCiv = true;
				if (NO.HasLostCiv) HasLostCiv = true;
			}

			Color TColor = NodeColor();

			if(TColor != Color.Empty)
			{
				ThisNodeColor = TColor;
				Node.BackColor = NodeColor();
			}
		}

		internal Color NodeColor()
		{
			if (HasLostCiv && HasLivingCiv) return Color.Orange;
			if (HasLostCiv) return Color.Yellow;
			if (HasLivingCiv) return Color.Red;
			return Color.Empty;
		}
	}
}
