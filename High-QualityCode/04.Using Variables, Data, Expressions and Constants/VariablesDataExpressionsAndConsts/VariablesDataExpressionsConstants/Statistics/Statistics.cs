using System;
using System.Linq;

namespace Statistics
{
    class Statistics
    {
        static void Main()
        {
        }

        public void PrintMaxValue(double maxValue)
        {
            Console.WriteLine("The maximal value is: {0}", maxValue);
        }

        public void PrintMinValue(double minValue)
        {
            Console.WriteLine("The minimal value is: {0}", minValue);
        }

        public void PrintAverageValue(double averageValue)
        {
            Console.WriteLine("The average value is: {0}", averageValue);
        }

        public void PrintStatistics(double[] statistics, int statisticsCount)
        {
            double maxValue = double.MinValue;
            for (int index = 0; index < statisticsCount; index++)
            {
                if (statistics[index] > maxValue)
                {
                    maxValue = statistics[index];
                }
            }
            PrintMaxValue(maxValue);

            double minValue = double.MaxValue;
            for (int index = 0; index < statisticsCount; index++)
            {
                if (statistics[index] < maxValue)
                {
                    minValue = statistics[index];
                }
            }
            PrintMinValue(minValue);

            double sumOfStatistics = 0;
            for (int index = 0; index < statisticsCount; index++)
            {
                sumOfStatistics += statistics[index];
            }
            double averageValueOFStatistics = sumOfStatistics / statisticsCount;
            PrintAverageValue(averageValueOFStatistics);

        }
    }
}