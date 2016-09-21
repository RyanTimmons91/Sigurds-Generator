using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarSystemGeneratorV2.Entity.StarSystems;

namespace StarSystemGeneratorV2
{
	static class Program
	{
		internal static LogF logForm;

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

			logForm = new LogF();

			Application.Run(new SystemGeneratorForm());
		}

		static void Log(string s)
		{
			LogF.WriteLine(s);
		}
		static void Log(Exception e)
		{
			LogF.WriteLine(e.Message);
			LogF.WriteLine(e.StackTrace);
		}
	}
}
