using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarSystemGeneratorV2
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			StarTypeModifiers.Init();
			
			if (Control.ModifierKeys == Keys.Control)
			{
				Properties.Settings.Default.CustomDieRolls = null;
			}
			
			if (Properties.Settings.Default.CustomDieRolls != null)
			{
				foreach (string s in Properties.Settings.Default.CustomDieRolls)
				{
					string[] line = s.Split(new string[] { "~^~" }, StringSplitOptions.None);

					if(line.Length == 2)
					{
						DiceRoller.CustomRoll.AddCustomRoll(line[0], line[1]);
					}
					else
					{
						Console.WriteLine("Problem Loading Custom Die Roll:");
						Console.WriteLine(s);
					}
				}
			}

			ArmorEquipmentClass.Initialize();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new SystemGeneratorForm());
		}
	}
}
