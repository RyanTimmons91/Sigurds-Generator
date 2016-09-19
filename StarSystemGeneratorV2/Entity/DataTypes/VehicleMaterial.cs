using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StarSystemGeneratorV2.Entity.DataTypes
{
	class VehicleMaterial : DataEntity
	{
		internal static List<VehicleMaterial> VehicleMaterialList = new List<VehicleMaterial>();

		internal override DataTypeEnum DataType
		{
			get { return DataTypeEnum.VehicleMaterial_Type; }
		}
		internal static string ConfigFileName = Settings.VehicleMaterialFilename;

		internal static void Load()
		{
			string AllText = File.ReadAllText(Path.Combine(Environment.CurrentDirectory + ConfigSubDirectory + ConfigFileName));
			string[] VehicleMaterials = AllText.Split(new string[] {ConfigDelimeter}, StringSplitOptions.RemoveEmptyEntries);

			foreach(string s in VehicleMaterials)
			{
				string[] v = s.Split(new string[] {VariableDelimiter}, StringSplitOptions.RemoveEmptyEntries);

				if (v.Length != 6)
				{
					if (v.Length == 1) continue;
					else
					{
					}
				}

				VehicleMaterial VM = new VehicleMaterial();
				VM.Name = v[0].Trim();
				VM.Weight = decimal.Parse(v[1].Trim());
				VM.Cost = decimal.Parse(v[2].Trim());
				VM.SpecialCheck = bool.Parse(v[3].Trim());
				VM.Text = v[4].Trim();
				VM.Values = new decimal[] {(decimal.Parse(v[5].Trim()))};

				VehicleMaterialList.Add(VM);
			}
		}
	}
}
