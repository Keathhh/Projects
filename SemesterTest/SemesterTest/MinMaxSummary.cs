using System;
using System.Collections.Generic;

namespace SemesterTest
{
	public class MinMaxSummary:SummaryStrategy
	{
		public override void PrintSummary(List<int> numbers)
		{
			Console.WriteLine($"Minimum:{Minimum(numbers)}\nMaximum:{Maximum(numbers)}");
		}

		private int Minimum(List<int> numbers)
		{
			int result = numbers[0];
			for (int i = 0; i < numbers.Count; i++)
			{
				int number = numbers[i];
				if (number < result)
					result = number;
			}
			return result;
		}

		private int Maximum(List<int> numbers)
		{
			int result = numbers[0];
			for (int i = 0; i < numbers.Count; i++)
			{
				int number = numbers[i];
				if (number > result)
					result = number;
			}
			return result;
		}
		
	}
}

