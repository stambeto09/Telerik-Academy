using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinAndMaxFromLoop
{
    class MinAndMaxFromLoop
    {
        static void Main()
        {
            int maxValue =0;
            int minValue = 1;

            Console.Write("Enter a value for n: ");
            int number = int.Parse(Console.ReadLine());

            for (int index = 1; index <= number; index++)
            {
                if (index>maxValue)
                {
                    maxValue = index;
                }
                if (index<minValue)
	            {
                    minValue = index;
	            }
            }
            Console.WriteLine("MinValue is equal to {0}",minValue);
            Console.WriteLine("MaxValue is equal to {0}", maxValue);


        }
    }
}
