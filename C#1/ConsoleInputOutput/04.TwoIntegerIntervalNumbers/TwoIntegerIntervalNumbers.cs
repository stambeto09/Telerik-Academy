using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegerIntervalNumbers
{
    class TwoIntegerIntervalNumbers
    {
        static void Main()
        {
            Console.Write("Enter the lower number of the interval: ");
            int lowerNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the higher number of the interval: ");
            int higherNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int index = lowerNumber; index <= higherNumber; index++)
            {
                if (index % 5 == 0)
                {
                    counter++;
                }
                
            }
            Console.WriteLine("The number of the existing values between interval [{0} ; {1}] is equal to {2}. ", lowerNumber, higherNumber, counter);
        }
    }
}
