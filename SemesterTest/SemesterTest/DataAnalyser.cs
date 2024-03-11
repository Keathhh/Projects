using System;
using System.Collections.Generic;

namespace SemesterTest
{
    public class DataAnalyser
    {
        private List<int> _numbers;
        private SummaryStrategy _strategy;

        public DataAnalyser(SummaryStrategy strategy)
               : this(strategy, new List<int>())
        {
        }

        public DataAnalyser()
           : this(new AverageSummary(), new List<int>())
        {
        }

        public DataAnalyser(SummaryStrategy strategy, List<int> numbers)
        {
            _strategy = strategy;
            _numbers = numbers;
        }
        public DataAnalyser(List<int> numbers)
               : this(new AverageSummary(), numbers)
        {
        }

        public SummaryStrategy Strategy
        {
            get => _strategy;
            set => _strategy = value;
        }

        public void AddNumbers(int number)
        {
            _numbers.Add(number);
        }

        public void Summarise()
        {
            _strategy.PrintSummary(_numbers);
        }


    }

}