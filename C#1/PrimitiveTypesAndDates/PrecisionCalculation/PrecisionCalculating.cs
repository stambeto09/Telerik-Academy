using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecisionCalculation
{
    class PrecisionCalculating
    {
        static void Main()
        {
            Console.Write("First value:  ");
            decimal firstValue = decimal.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            decimal secondValue = decimal.Parse(Console.ReadLine());

            bool comparedValues = (Math.Abs(firstValue - secondValue) <         0.000001m);
            if (comparedValues == true)
            {
                Console.WriteLine("Values are equal. ");
            }
            else
            {
                Console.WriteLine("Values are not equal. ");
            }

        }
    }
}
