using System;
using System.Collections.Generic;

namespace SemesterTest
{
	public class Program
	{
		static void Main(string[] args)
		{
			MinMaxSummary minmaxstrategy = new MinMaxSummary();
			AverageSummary averagesummary = new AverageSummary();

			List<int> numbers = new List<int> { 1, 0, 3, 8, 4, 4, 3, 2, 4 };
			DataAnalyser dataanalyser = new DataAnalyser(minmaxstrategy, numbers);

			dataanalyser.Summarise();

			dataanalyser.AddNumbers(1);
			dataanalyser.AddNumbers(4);
			dataanalyser.AddNumbers(9);

			dataanalyser.Strategy = averagesummary;
			dataanalyser.Summarise();
		}
	}
}

