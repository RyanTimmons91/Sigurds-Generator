using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSystemGeneratorV2.Entity.DataTypes
{
	abstract class DataEntity
	{
		internal static StarSystemGeneratorV2.Properties.Settings Settings = StarSystemGeneratorV2.Properties.Settings.Default;
		internal static string ConfigSubDirectory = Settings.ConfigDirectory;
		internal static string ConfigDelimeter = Settings.ConfigDelimeter;
		internal static string VariableDelimiter = Settings.VariableDelimeter;

		internal abstract DataTypeEnum DataType
		{
			get;
		}

		internal string Name;

		internal bool SpecialCheck;

		internal string Text;

		internal decimal Weight;
		internal decimal Cost;

		internal decimal[] Values;

		public override string ToString()
		{
			return Name;
		}
	}
}
