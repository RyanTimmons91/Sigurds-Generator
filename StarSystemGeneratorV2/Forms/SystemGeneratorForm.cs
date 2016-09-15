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

using StarSystemGeneratorV2.Entity;
using StarSystemGeneratorV2.Generator;

namespace StarSystemGeneratorV2
{
	public partial class SystemGeneratorForm : Form
	{
		internal static DiceRollerForm DiceRollerFormObject = new DiceRollerForm();

		Version v;
		bool BlinkWarning = false;

		public SystemGeneratorForm()
		{
			InitializeComponent();

			v = GetPublishedVersion();

			this.Text = this.Text + " Version " + v.ToString();
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
		}
		
		private void SystemGeneratorForm_Load(object sender, EventArgs e)
		{
			UpdateVersionAlert();
		}

		private void _testButton_Click(object sender, EventArgs e)
		{
			GenerateSystem();
		}
		
		private void _randomTest_Click(object sender, EventArgs e)
		{
			Randomize Generate = new Randomize();
			DiceHelper DH = Generate.diceHelper;

			Dictionary<ResourceTypes, int> ResourceCheck = new Dictionary<ResourceTypes, int>();

			for(int i = 0; i < 20000; i++)
			{
				Console.WriteLine("Iteration " + i);
				ResourceTypes RT = Generate.ResourceType();

				if (ResourceCheck.ContainsKey(RT))
				{
					ResourceCheck[RT] += 1;
				}
				else
				{
					ResourceCheck.Add(RT, 1);
				}
			}

			string s = "";

			foreach (KeyValuePair<ResourceTypes, int> KV in ResourceCheck)
			{
				s +=  KV.Key + " " + KV.Value + Environment.NewLine;
			}
			
			MessageBox.Show(s);
		}

		private void _systemTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			ClearSystemInfo();

			if (e.Node.Tag != null)
			{
				Entity.StarSystems.NodeObject NO = (Entity.StarSystems.NodeObject)e.Node.Tag;

				_globalSystemNumber.Text = NO.BaseEntity.SystemNumber + "";

				if (NO.BaseEntity.EntityType == EntityTypes.StarSystem)
				{
					EntityControls.StarSystemControl MC = new EntityControls.StarSystemControl(NO.BaseEntity);

					_dynamicPanel.Controls.Add(MC);

					MC.Dock = DockStyle.Fill;
					return;
				}
			}

			ClearSystemInfo();
		}

		private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Changelog().ShowDialog();
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClearSystemInfo();
			ClearSystemList();
		}

		void ClearSystemList()
		{
			_systemTreeView.Nodes.Clear();
		}
		void ClearSystemInfo()
		{
			_dynamicPanel.Controls.Clear();
			_globalSystemNumber.Text = "";
		}

		private void _0SystemNumber_Click(object sender, EventArgs e)
		{
			_seedBox.Value = 0;
			GenerateSystem();
		}

		private void _diceRoller_Click(object sender, EventArgs e)
		{
			DiceRollerFormObject.Show();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Options opt = new Options();
			opt.ShowDialog();
			UpdateVersionAlert();
		}

		private void resourceCostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ResourceCalc().Show();
		}

		private void weaponCostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Forms.WeaponCost().Show();
		}
		
		void UpdateVersionAlert()
		{
			int propVer = Properties.Settings.Default.GeneratorVersion;

			if (propVer != v.MinorRevision)
			{
				_versionText.BackColor = Color.Salmon;
				BlinkWarning = true;
			}
			else
			{
				_versionText.BackColor = SystemColors.Control;
				BlinkWarning = false;
			}

			_versionText.Text = "Using Version " + propVer;
		}

		private void _blinkWarning_Tick(object sender, EventArgs e)
		{
			if(BlinkWarning)
			{
				_versionText.Visible = !_versionText.Visible;
			}
			else
			{
				_versionText.Visible = true;
			}
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
	}
}
