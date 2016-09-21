using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSystemGeneratorV2
{
	public class DiceHelper
	{

		public int _Seed
		{
			get
			{
				return Seed;
			}
		}
		int Seed;
		Random random;

		public DiceHelper(int seed)
		{
			Seed = seed;
			random = new Random(seed);
		}
		public DiceHelper()
		{
			Random tempRandom = new Random();
			int i1 = tempRandom.Next(0, 9);
			int i2 = tempRandom.Next(0, 9);
			int i3 = tempRandom.Next(0, 9);
			int i4 = tempRandom.Next(0, 9);
			int i5 = tempRandom.Next(0, 9);
			int i6 = tempRandom.Next(0, 9);
			int i7 = tempRandom.Next(0, 9);
			int i8 = tempRandom.Next(0, 9);
			int i9 = tempRandom.Next(0, 9);

			Seed = int.Parse("" + i1 + i3 + i3 + i4 + i5 + i6 + i7 + i8 + i9);

			random = new Random(Seed);
		}

		/// <summary>
		/// Rolls a specified die a specified number of times and returns the sum of all results
		/// </summary>
		/// <param name="DieSides">The number of sides on the die</param>
		/// <param name="DieCount">The number of dice to roll</param>
		/// <returns>Returns the total of all rolled dice</returns>
		public int RollSum(int DieSides, int DieCount)
		{
			return Roll(DieSides, DieCount, 0);
		}

		/// <summary>
		/// Roll a single die
		/// </summary>
		/// <param name="DieSides">The number of sides on the die to roll</param>
		/// <returns>Returns the results of the die roll</returns>
		public int Roll(int DieSides)
		{
			int maxValue = DieSides + 1;

			return random.Next(1, maxValue);
		}

		/// <summary>
		/// Roll a certain Die a number of times and add the results together
		/// </summary>
		/// <param name="DieSides">The number of sides on the die</param>
		/// <param name="DieCount">The number of dice to roll, the results will be added together</param>
		/// <param name="RollModifier">The number to add to or subtract from the total, this can be zero or negative</param>
		/// <returns>The sum of all rolled dice plus or minus the RollModifier</returns>
		public int Roll(int DieSides, int DieCount, int RollModifier)
		{
			int TempSum = 0;

			for (int i = 0; i < DieCount; i++) //Loop for the number of dice we are using (count)
			{
				TempSum += Roll(DieSides);
			}

			return TempSum + RollModifier; //Return result of random calculations
		}

		/// <summary>
		/// Rolls a certain Die a number of times and adds the results together, repeated a number of times
		/// </summary>
		/// <param name="DieSides">The number of sides on the die</param>
		/// <param name="DieCount">The number of dice to roll in each set, the results will be added together</param>
		/// <param name="RollModifier">This number gets added to each set of dice, can be zero or negative</param>
		/// <param name="RollCount">The number of sets of dice to roll, each set of dice gets added together</param>
		/// <returns>An array of integers, each index in the array is DieCount number of DieSides dice added together +/- RollModifer, the array length is RollCount</returns>
		public int[] Roll(int DieSides, int DieCount, int RollModifier, int RollCount)
		{
			int[] result = new int[RollCount]; //Placeholder for total result

			for (int i2 = 0; i2 < RollCount; i2++)
			{
				result[i2] = Roll(DieSides, DieCount, RollModifier); //Generate a random number to represent a die roll
			}

			return result; //Return result of random calculations
		}

		/// <summary>
		/// Roll a single percentage value
		/// </summary>
		/// <returns>Returns a random number from 1-100</returns>
		public int Percentage()
		{
#if DEBUG
			LogF.WriteLine("Roll Percentage"); 
#endif

			return Roll(100);
		}

		/// <summary>
		/// Roll a single die
		/// </summary>
		/// <returns>Returns the results of the die roll</returns>
		public int D2()
		{
#if DEBUG
			LogF.WriteLine("Roll D2"); 
#endif

			return Roll(2);
		}
		/// <summary>
		/// Roll a number of Dice and add them together
		/// </summary>
		/// <param name="count">The number of Dice to roll</param>
		/// <returns>The sum of all rolled dice</returns>
		public int D2(int count)
		{
			return RollSum(2, count);
		}

		/// <summary>
		/// Roll a single die
		/// </summary>
		/// <returns>Returns the results of the die roll</returns>
		public int D3()
		{
#if DEBUG
			LogF.WriteLine("Roll D3"); 
#endif

			return Roll(3);
		}
		/// <summary>
		/// Roll a number of Dice and add them together
		/// </summary>
		/// <param name="count">The number of Dice to roll</param>
		/// <returns>The sum of all rolled dice</returns>
		public int D3(int count)
		{
			return RollSum(3, count);
		}

		/// <summary>
		/// Roll a single die
		/// </summary>
		/// <returns>Returns the results of the die roll</returns>
		public int D4()
		{
#if DEBUG
			LogF.WriteLine("Roll D4"); 
#endif

			return Roll(4);
		}
		/// <summary>
		/// Roll a number of Dice and add them together
		/// </summary>
		/// <param name="count">The number of Dice to roll</param>
		/// <returns>The sum of all rolled dice</returns>
		public int D4(int count)
		{
			return RollSum(4, count);
		}

		/// <summary>
		/// Roll a single die
		/// </summary>
		/// <returns>Returns the results of the die roll</returns>
		public int D6()
		{
#if DEBUG
			LogF.WriteLine("Roll D6"); 
#endif

			return Roll(6);
		}
		/// <summary>
		/// Roll a number of Dice and add them together
		/// </summary>
		/// <param name="count">The number of Dice to roll</param>
		/// <returns>The sum of all rolled dice</returns>
		public int D6(int count)
		{
			return RollSum(6, count);
		}

		/// <summary>
		/// Roll a single die
		/// </summary>
		/// <returns>Returns the results of the die roll</returns>
		public int D8()
		{
#if DEBUG
			LogF.WriteLine("Roll D8"); 
#endif

			return Roll(8);
		}
		/// <summary>
		/// Roll a number of Dice and add them together
		/// </summary>
		/// <param name="count">The number of Dice to roll</param>
		/// <returns>The sum of all rolled dice</returns>
		public int D8(int count)
		{
			return RollSum(8, count);
		}

		/// <summary>
		/// Roll a single die
		/// </summary>
		/// <returns>Returns the results of the die roll</returns>
		public int D10()
		{
#if DEBUG
			LogF.WriteLine("Roll D10"); 
#endif

			return Roll(10);
		}
		/// <summary>
		/// Roll a number of Dice and add them together
		/// </summary>
		/// <param name="count">The number of Dice to roll</param>
		/// <returns>The sum of all rolled dice</returns>
		public int D10(int count)
		{
			return RollSum(10, count);
		}

		/// <summary>
		/// Roll a single die
		/// </summary>
		/// <returns>Returns the results of the die roll</returns>
		public int D12()
		{
#if DEBUG
			LogF.WriteLine("Roll D12"); 
#endif

			return Roll(12);
		}
		/// <summary>
		/// Roll a number of Dice and add them together
		/// </summary>
		/// <param name="count">The number of Dice to roll</param>
		/// <returns>The sum of all rolled dice</returns>
		public int D12(int count)
		{
			return RollSum(12, count);
		}

		/// <summary>
		/// Roll a single die
		/// </summary>
		/// <returns>Returns the results of the die roll</returns>
		public int D20()
		{
#if DEBUG
			LogF.WriteLine("Roll D20"); 
#endif

			return Roll(20);
		}
		/// <summary>
		/// Roll a number of Dice and add them together
		/// </summary>
		/// <param name="count">The number of Dice to roll</param>
		/// <returns>The sum of all rolled dice</returns>
		public int D20(int count)
		{
			return RollSum(20, count);
		}
	}
}
