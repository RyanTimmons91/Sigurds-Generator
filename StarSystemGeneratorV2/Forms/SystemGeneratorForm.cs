using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.Xml;

using StarSystemGeneratorV2.Entity.StarSystems;
using StarSystemGeneratorV2.Generator;

namespace StarSystemGeneratorV2
{
	public partial class SystemGeneratorForm : Form
	{
		internal static DiceRollerForm DiceRollerFormObject = new DiceRollerForm();

		DiceHelper DH = new DiceHelper();

		Version v;

		public SystemGeneratorForm()
		{
			InitializeComponent();

			v = GetPublishedVersion();

			this.Text = this.Text + " Version " + v.ToString();
		}

		internal void GenerateSystem()
		{
			Entity.StarSystems.StarSystem GeneratedSystem;

			if (_seedBox.Value != 0)
			{
				GeneratedSystem = new Entity.StarSystems.StarSystem((int)_versionGen.Value, (int)_seedBox.Value);
			}
			else
			{
				GeneratedSystem = new Entity.StarSystems.StarSystem((int)_versionGen.Value, 0);
			}

			int treeNodeNumber = _systemTreeView.Nodes.Add(GeneratedSystem.Node.Node);
			_systemTreeView.SelectedNode = _systemTreeView.Nodes[treeNodeNumber];
			GeneratedSystem.Colorize();

			_encounterCheck.Text = DH.D12().ToString();
		}

		//Actions
		private void _systemTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			ClearSystemInfo(); //Clear the Selected System in Dock and the System number

			if (e.Node.Tag == null)
			{
				//Should only hit this when we have a 'group' node selected (Resources, Celestial Objects, etc)
				
				TreeNode node = e.Node;
				while(node.Tag == null)
				{
					if (node.Parent == null) break;
					node = node.Parent;
				}

				if(node.Tag == null)
				{
					//Still not found, this should never happen!
				}
				else
				{
					_globalSystemNumber.Text = ((Entity.StarSystems.NodeObject)node.Tag).BaseEntity.SystemNumber + "";
				}
			}
			else
			{
				//We have a Node Tag, so we might be able to display an Entity
				Entity.StarSystems.NodeObject NO = (Entity.StarSystems.NodeObject)e.Node.Tag;

				_globalSystemNumber.Text = NO.BaseEntity.SystemNumber + "";

				switch(NO.BaseEntity.EntityType)
				{
					case EntityTypes.StarSystem:
						EntityControls.StarSystemControl SSC = new EntityControls.StarSystemControl(NO.BaseEntity);
						_dynamicPanel.Controls.Add(SSC);
						SSC.Dock = DockStyle.Fill;
						return;
					case EntityTypes.Star:
						EntityControls.StarControl SC = new EntityControls.StarControl(NO.BaseEntity);
						_dynamicPanel.Controls.Add(SC);
						SC.Dock = DockStyle.Fill;
						return;
					case EntityTypes.Planet:
						EntityControls.PlanetControl PC = new EntityControls.PlanetControl(NO.BaseEntity);
						_dynamicPanel.Controls.Add(PC);
						PC.Dock = DockStyle.Fill;
						return;
					case EntityTypes.GasGiant:
						EntityControls.GasGiantControl GGC = new EntityControls.GasGiantControl(NO.BaseEntity);
						_dynamicPanel.Controls.Add(GGC);
						GGC.Dock = DockStyle.Fill;
						return;
					case EntityTypes.Moon:
						EntityControls.MoonControl MC = new EntityControls.MoonControl(NO.BaseEntity);
						_dynamicPanel.Controls.Add(MC);
						MC.Dock = DockStyle.Fill;
						return;
					default:
						return;
				}
			}

			ClearSystemInfo();
		}

		//Buttons
		private void _GenerateButton_Click(object sender, EventArgs e)
		{
			GenerateSystem();
		}
		private void _0SystemNumber_Click(object sender, EventArgs e)
		{
			_seedBox.Value = 0;
			GenerateSystem();
		}

		//Helper Functions
		void ClearSystemList()
		{
			_systemTreeView.Nodes.Clear();
		}
		void ClearSystemInfo()
		{
			_dynamicPanel.Controls.Clear();
			_globalSystemNumber.Text = "";
		}
		public static Version GetPublishedVersion()
		{
			XmlDocument xmlDoc = new XmlDocument();
			Assembly asmCurrent = System.Reflection.Assembly.GetExecutingAssembly();
			string executePath = new Uri(asmCurrent.GetName().CodeBase).LocalPath;

			xmlDoc.Load(executePath + ".manifest");
			string retval = string.Empty;
			if (xmlDoc.HasChildNodes)
			{
				retval = xmlDoc.ChildNodes[1].ChildNodes[0].Attributes.GetNamedItem("version").Value.ToString();
			}
			return new Version(retval);
		}

		
		#region Menu
		private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Changelog().ShowDialog();
		}
		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClearSystemInfo();
			ClearSystemList();
		}
		private void _diceRoller_Click(object sender, EventArgs e)
		{
			DiceRollerFormObject.Show();
		}
		#endregion

		#region SpecialGenButtons
		private void resourceCostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ResourceCalc().Show();
		}
		private void weaponCostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Forms.WeaponCost().Show();
		}
		private void mechaWeightCostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Forms.SpecialGens.Mecha().Show();
		}
		private void handheldWeaponsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Forms.SpecialGens.HandheldWeapons().Show();
		}
		private void armorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Forms.SpecialGens.Armor().Show();
		}
		private void missileLaunchersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Forms.SpecialGens.MissileLauncher().Show();
		}
		private void nPCEncountersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Forms.SpecialGens.NPCEncounterGen().Show();
		}
		private void shipsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Forms.SpecialGens.Ships().Show();
		}
		#endregion

		private void _highlightComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			HighlightTypes highlightTypes = (HighlightTypes)_highlightComboBox.SelectedIndex;

			//Reset to none
			SystemEntity.HighlightType = HighlightTypes.None;
			UpdateHighlighting();

			//Apply current Colors
			SystemEntity.HighlightType = highlightTypes;
			UpdateHighlighting();
		}
		void UpdateHighlighting()
		{
			StarSystem[] SS = new StarSystem[_systemTreeView.Nodes.Count];

			for (int i = 0; i < SS.Length; i++)
			{
				NodeObject n = (NodeObject)_systemTreeView.Nodes[i].Tag;
				((StarSystem)n.BaseEntity).Colorize();
			}
		}

		private void logToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Program.logForm.Show();
		}

		private void SystemGeneratorForm_Load(object sender, EventArgs e)
		{

			

		}

		private void testToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new LoadingAnimationForm().Show();
		}
	}
}
