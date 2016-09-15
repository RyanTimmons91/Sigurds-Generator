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
	public partial class NPCEncounterGen : Form
	{
		bool isInProgress = false;

		public NPCEncounterGen()
		{
			InitializeComponent();
		}

		private void _randomAll_Click(object sender, EventArgs e)
		{
			isInProgress = true;

			_npcGrid.Rows.Clear();

			Random random = new Random();

			//Set Enemy Count
			int count = (int)_enemyCount.Value;
			if (count == 0)
			{
				count = random.Next(1, 50);
			}

			int AvgPlayerLevel = (int)_avgPlayer.Value;
			int NPCLevelSpread = (int)_npcLvlSpread.Value;

			NPCRace race = null;
			int Level = 1;

			if(_singleRace.Checked)
			{
				race = NPCStatDB.Races[random.Next(0, 7)];
			}

			if(_singleLevel.Checked)
			{
				if (AvgPlayerLevel == -1)
				{
					Level = random.Next(1, 21); //Inclusive start, exclusive end
				}
				else
				{
					int lowLevel = AvgPlayerLevel - NPCLevelSpread;
					if (lowLevel < 1) lowLevel = 1;

					int maxLevel = AvgPlayerLevel + NPCLevelSpread + 1;
					if (maxLevel < lowLevel) maxLevel = lowLevel;
					Level = random.Next(lowLevel, maxLevel); //Inclusive start, exclusive end
				}
			}


			for(int i = 0; i < count; i++)
			{
				if (!_singleRace.Checked) //Race Randomization
				{
					race = NPCStatDB.Races[random.Next(0, 7)];
				}
				if(!_singleLevel.Checked)
				{
					if (AvgPlayerLevel == -1)
					{
						Level = random.Next(1, 21); //Inclusive start, exclusive end
					}
					else
					{
						int lowLevel = AvgPlayerLevel - NPCLevelSpread;
						if (lowLevel < 1) lowLevel = 1;

						int maxLevel = AvgPlayerLevel + NPCLevelSpread + 1;
						if (maxLevel < lowLevel) maxLevel = lowLevel;
						Level = random.Next(lowLevel, maxLevel); //Inclusive start, exclusive end
					}
				}
				
				int weaponCount = race.Weapons.Count;
				int weaponNumber = random.Next(0, weaponCount);
				Weapon weapon = race.Weapons[weaponNumber];

				//Output this row
				int RowNum = _npcGrid.Rows.Add();
				DataGridViewRow row = _npcGrid.Rows[RowNum];
				row.Cells[0].Value = race.Name;
				row.Cells[1].Value = "" + Level;
				row.Cells[2].Value = weapon.Name;
				row.Cells[3].Value = (50 + ((race.RacialHP + 10) * Level)) + "";
				row.Cells[4].Value = weapon.AttackBonus[Level - 1];
				row.Cells[5].Value = 5 + Level;
			}

			isInProgress = false;
		}

		private void _avgPlayer_ValueChanged(object sender, EventArgs e)
		{

		}

		private void _npcLvlSpread_ValueChanged(object sender, EventArgs e)
		{

		}

		private void _npcGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(isInProgress)
			{
				return;
			}

			if (e.RowIndex == -1) return;

			isInProgress = true;

			DataGridViewRow Row = _npcGrid.Rows[e.RowIndex];

			if (e.ColumnIndex == 6)
			{
				//3 = HP
				//6 = DMG
				//7 = Current HP

				int Hp = int.Parse((string)Row.Cells[3].Value);
				int Dmg = int.Parse((string)Row.Cells[6].Value);

				Row.Cells[7].Value = Hp - Dmg;

				isInProgress = false;
				return;
			}

			if (e.ColumnIndex >= 3)
			{
				isInProgress = false;
				return;
			}
			
			try
			{
				NPCRace Race = NPCStatDB.stringToRace((string)Row.Cells[0].Value);

				int Level = int.Parse((string)Row.Cells[1].Value);
				string Weapon = (string)Row.Cells[2].Value;

				if (!Race.ValidWeapon(Weapon))
				{
					Row.ErrorText = "You have selected an invalid weapon for that race, please try again.";
				}
				else
				{
					Weapon weapon = Race.GetWeapon(Weapon);

					Row.ErrorText = "";

					Row.Cells[3].Value = (50 + ((Race.RacialHP + 10) * Level)) + "";
					Row.Cells[4].Value = weapon.AttackBonus[Level - 1];
					Row.Cells[5].Value = 5 + Level;
				}
			}
			catch
			{
				Row.ErrorText = "Error, please fill out the first three cells completely";
			}
			isInProgress = false;
		}
	}
	/*
	 * Encounter Level - 
	 * Group Size / Level of NPC's
	 * 
	 * HP 50 + ((Racial + 10) * level)
	 * 
	 * Race
	 * Weapons
	 * Attack Bonus
	 * Defense Bonus
	 * 
	 * Defense = 5+lvl
	 * //Armor def 5
	 * 
	 */

	class NPCStatDB
	{
		internal static List<NPCRace> Races = new List<NPCRace>()
		{
			new NPCRace(0, "Human", 8, new List<Weapon> {
				new Weapon("Knife", new List<int> { 1,1,2,2,2,3,3,4,4,4,5,5,6,6,6,7,7,7,8,8 }),
				new Weapon("Pistol", new List<int> { 1,1,2,2,2,3,3,3,4,4,5,5,5,6,6,6,7,7,8,8 }),
				new Weapon("SMG", new List<int> { 1,1,2,2,2,2,3,3,4,4,5,5,5,6,6,7,7,7,7,8 }),
				new Weapon("Shotgun", new List<int> { 1,1,2,2,2,3,3,3,4,4,5,5,5,6,6,6,7,7,8,8 }),
				new Weapon("Assault Rifle", new List<int> { 1,2,2,2,2,3,3,4,4,4,5,5,6,6,6,7,7,7,8,8 }),
				new Weapon("Machine Gun", new List<int> { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
				new Weapon("Sniper Rifle", new List<int> { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
			} ),
			new NPCRace(1, "Dwuervan", 10, new List<Weapon> {
				 new Weapon("Axe", new List<int>() { 2,3,4,5,6,7,8,9,10,10,10,10,10,10,10,10,10,10,10,10 }),
				 new Weapon("Pistol", new List<int>() { 1,1,2,2,2,3,3,3,4,4,5,5,5,6,6,6,7,7,8,8 }),
				 new Weapon("Shotgun", new List<int>() { 2,2,3,3,3,4,4,4,5,5,5,6,6,7,7,7,8,8,8,9 }),
				 new Weapon("Assault Rifle", new List<int>() { 1,2,2,2,2,3,3,4,4,4,5,5,6,6,6,7,7,7,8,8 }),
				 new Weapon("Machine Gun", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
				 new Weapon("Sniper Rifle", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
			} ),
			new NPCRace(2, "Elharnian", 4, new List<Weapon> {
				new Weapon("Sword", new List<int>() { 2,3,4,5,6,7,8,9,10,10,10,10,10,10,10,10,10,10,10,10 }),
				new Weapon("Pistol", new List<int>() { 1,1,2,2,2,3,3,3,4,4,5,5,5,6,6,6,7,7,8,8 }),
				new Weapon("Shotgun", new List<int>() { 2,2,3,3,3,4,4,4,5,5,5,6,6,7,7,7,8,8,8,9 }),
				new Weapon("Assault Rifle", new List<int>() { 1,2,2,2,2,3,3,4,4,4,5,5,6,6,6,7,7,7,8,8 }),
				new Weapon("Machine Gun", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
				new Weapon("Sniper Rifle", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
			} ),
			new NPCRace(3, "Halfarn", 3, new List<Weapon> {
				new Weapon("Knife", new List<int>() { 2,3,4,5,6,7,8,9,10,10,10,10,10,10,10,10,10,10,10,10 }),
				new Weapon("Pistol", new List<int>() { 1,1,2,2,2,3,3,3,4,4,5,5,5,6,6,6,7,7,8,8 }),
				new Weapon("Shotgun", new List<int>() { 1,1,2,2,2,3,3,3,4,4,4,5,5,5,6,6,6,7,7,7 }),
				new Weapon("Assault Rifle", new List<int>() { 1,2,2,2,2,3,3,4,4,4,5,5,6,6,6,7,7,7,8,8 }),
				new Weapon("Machine Gun", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
				new Weapon("Sniper Rifle", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
			} ),
			new NPCRace(4, "Ngorm", 4, new List<Weapon> {
				new Weapon("Knife", new List<int>() { 2,3,4,5,6,7,8,9,10,10,10,10,10,10,10,10,10,10,10,10 }),
				new Weapon("Pistol", new List<int>() { 1,1,2,2,2,3,3,3,4,4,5,5,5,6,6,6,7,7,8,8 }),
				new Weapon("Shotgun", new List<int>() { 1,1,2,2,2,3,3,3,4,4,4,5,5,5,6,6,6,7,7,7 }),
				new Weapon("Assault Rifle", new List<int>() { 1,2,2,2,2,3,3,4,4,4,5,5,6,6,6,7,7,7,8,8 }),
				new Weapon("Machine Gun", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
				new Weapon("Sniper Rifle", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
			} ),
			new NPCRace(5, "Orlanc", 10, new List<Weapon> {
				new Weapon("Knife", new List<int>() { 2,3,4,5,6,7,8,9,10,10,10,10,10,10,10,10,10,10,10,10 }),
				new Weapon("Pistol", new List<int>() { 1,1,2,2,2,3,3,3,4,4,5,5,5,6,6,6,7,7,8,8 }),
				new Weapon("Shotgun", new List<int>() { 1,1,2,2,2,3,3,3,4,4,4,5,5,5,6,6,6,7,7,7 }),
				new Weapon("Assault Rifle", new List<int>() { 1,2,2,2,2,3,3,4,4,4,5,5,6,6,6,7,7,7,8,8 }),
				new Weapon("Machine Gun", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
				new Weapon("Sniper Rifle", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
			} ),
			new NPCRace(6, "Yettin", 12, new List<Weapon> {
				new Weapon("Knife", new List<int>() { 2,3,4,5,6,7,8,9,10,10,10,10,10,10,10,10,10,10,10,10 }),
				new Weapon("Pistol", new List<int>() { 1,1,2,2,2,3,3,3,4,4,5,5,5,6,6,6,7,7,8,8 }),
				new Weapon("Shotgun", new List<int>() { 1,1,2,2,2,3,3,3,4,4,4,5,5,5,6,6,6,7,7,7 }),
				new Weapon("Assault Rifle", new List<int>() { 1,2,2,2,2,3,3,4,4,4,5,5,6,6,6,7,7,7,8,8 }),
				new Weapon("Machine Gun", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
				new Weapon("Sniper Rifle", new List<int>() { 0,1,2,2,2,2,3,3,4,4,4,5,5,5,6,6,7,7,7,8 }),
			} ),
		};

		internal static NPCRace Human = Races[0];
		internal static NPCRace Dwuervan = Races[1];
		internal static NPCRace Elharnian = Races[2];
		internal static NPCRace Halfarn = Races[3];
		internal static NPCRace Ngorm = Races[4];
		internal static NPCRace Orlanc = Races[5];
		internal static NPCRace Yettin = Races[6];

		internal static NPCRace stringToRace(string s)
		{
			switch (s)
			{
				case "Dwuervan":
					return Dwuervan;
				case "Elharnian":
					return Elharnian;
				case "Halfarn":
					return Halfarn;
				case "Ngorm":
					return Ngorm;
				case "Orlanc":
					return Orlanc;
				case "Yettin":
					return Yettin;
				case "Human":
				default:
					return Human;
			}
		}
	}
	class NPCRace
	{
		int ID;
		internal string Name; //The Name of this race
		internal decimal RacialHP; //How many HP per level this race gets
		internal List<Weapon> Weapons = new List<Weapon>(); //The dictionary containing all of this races weapons and hte attack bonuses of them

		internal NPCRace(int id, string name, decimal hp, List<Weapon> weapons)
		{
			ID = id;
			Name = name;
			RacialHP = hp;
			foreach(Weapon w in weapons)
			{
				Weapons = weapons;
			}
		}

		internal bool ValidWeapon(string s)
		{
			for (int i = 0; i < Weapons.Count; i++)
			{
				if (Weapons[i].Name == s) return true;
			}

			return false;
		}

		internal Weapon GetWeapon(string s)
		{
			for (int i = 0; i < Weapons.Count; i++)
			{
				if (Weapons[i].Name == s) return Weapons[i];
			}

			return null;
		}
	}
	class Weapon
	{
		internal string Name; //The name of the weapon
		internal List<int> AttackBonus; //This attack bonus depends on the character level

		internal Weapon(string name, List<int> ab)
		{
			Name = name;
			AttackBonus = ab;
		}
	}

}
