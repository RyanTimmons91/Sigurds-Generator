using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSystemGeneratorV2.DiceRoller
{
    internal static class CustomRoll
    {
		internal static Dictionary<string, CustomRollData> CustomRolls = new Dictionary<string, CustomRollData>();

		internal static void AddCustomRoll(string name, string s)
		{
			CustomRolls.Add(name, new CustomRollData(s));
		}
		internal static double RollCustomRoll(string name)
		{
			return CustomRolls[name].Roll();
		}

		internal static void SaveAll()
		{
			Properties.Settings.Default.CustomDieRolls = new System.Collections.Specialized.StringCollection();

			foreach(KeyValuePair<string, CustomRollData> kv in CustomRolls)
			{
				Properties.Settings.Default.CustomDieRolls.Add(kv.Key + "~^~" + kv.Value.OriginalData);
			}

			Properties.Settings.Default.Save();
		}
    }
	class CustomRollData
	{
		internal string OriginalData = "";
		
		internal SortedList<int, Expression> RollSteps = new SortedList<int, Expression>();

		internal CustomRollData(string s)
		{
			OriginalData = s;

			ParseText(s);
		}

		CustomRollData ParseText(string s)
		{
			s = s.ToUpper();
			s = s.Replace(" ", "");
			s = s.Replace(Environment.NewLine, "");

			Expression ex = new Expression();
			ex.isInitial = true;

			string currentPart = "";

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == 'D')
				{
					ex.isSetNumber = false;
					ex.isDiceRoll = true;
					ex.DieCount = int.Parse(currentPart);
					currentPart = "";

					continue;
				}
				else if (s[i] == '+')
				{
					ex._value = double.Parse(currentPart);

					RollSteps.Add(RollSteps.Count, ex);

					currentPart = "";

					ex = new Expression();
					ex.isAdd = true;

					continue;
				}
				else if (s[i] == '-')
				{
					ex._value = double.Parse(currentPart);

					RollSteps.Add(RollSteps.Count, ex);

					currentPart = "";

					ex = new Expression();
					ex.isSubtract = true;

					continue;
				}
				else if (s[i] == '*')
				{
					ex._value = double.Parse(currentPart);

					RollSteps.Add(RollSteps.Count, ex);

					currentPart = "";

					ex = new Expression();
					ex.isMultiply = true;

					continue;
				}
				else if (s[i] == '/')
				{
					ex._value = double.Parse(currentPart);

					RollSteps.Add(RollSteps.Count, ex);

					currentPart = "";

					ex = new Expression();
					ex.isDivide = true;

					continue;
				}

				if (Char.IsNumber(s[i]) || s[i] == '.')
				{
					currentPart += s[i];
				}
				else
				{
					throw new InvalidOperationException("Unknown character in Custom Roll: " + s[i] + Environment.NewLine + OriginalData);
				}
			}

			ex._value = double.Parse(currentPart);
			RollSteps.Add(RollSteps.Count, ex);

			return null;
		}

		internal double Roll()
		{
			Console.WriteLine("test1 " + RollSteps.Count);
			double TempValue = 0;

			for(int i = 0; i < RollSteps.Count; i++)
			{
				Console.WriteLine("test1 - " + i);
				TempValue = RollSteps[i].EvaluteExpression(TempValue);
				Console.WriteLine(TempValue);
			}
			return TempValue;
		}

		internal void Roll(object sender, EventArgs e)
		{
			double Result = Roll();

			SystemGeneratorForm.DiceRollerFormObject._outputTextbox.AppendText(Result + Environment.NewLine);
		}
	}
	class Expression
	{
		Generator.Randomize gen = new Generator.Randomize();

		internal bool isInitial = false;
		internal bool isAdd = false;
		internal bool isSubtract = false;
		internal bool isMultiply = false;
		internal bool isDivide = false;

		internal bool isDiceRoll = false;
		internal bool isSetNumber = true;
		internal double _value = 0; //also used for DieSize

		internal int DieCount = 0;

		double value
		{
			get
			{
				if (isDiceRoll)
				{
					return DieRoll();
				}
				if (isSetNumber)
				{
					return _value;
				}

				throw new InvalidOperationException("No Value for expression set");
			}
		}
		
		int DieRoll()
		{
			int rValue = gen.diceHelper.Roll((int)_value, DieCount, 0);
			Console.WriteLine("rv: " + rValue);
			return rValue;
		}

		internal double EvaluteExpression(double current)
		{
			Console.WriteLine("Evaluating");
			if (isInitial)
			{
				double rValue = value;
				Console.WriteLine("r2" + rValue);
				return rValue;
			}

			if (isAdd)
			{
				return current + value;
			}
			if (isSubtract)
			{
				return current - value;
			}
			if (isMultiply)
			{
				return current * value;
			}
			if (isDivide)
			{
				return current / value;
			}

			throw new InvalidOperationException("Invlid Expression Type!");
		}
	}
}
