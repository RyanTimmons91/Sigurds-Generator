using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using StarSystemGeneratorV2.Entity.StarSystems;


namespace StarSystemGeneratorV2.SaveLoad
{
	class SaveData
	{
		internal bool SaveFile(string file)
		{
			StreamWriter SW = new StreamWriter(file);

			try
			{
				//foreach (StarSystem SS in StarSystem.StarSystems)
				//{
				//	//SS.Save(SW);
				//}
			}
			catch
			{
				
			}

			SW.Flush();
			SW.Close();

			return true;
		}
	}
}
