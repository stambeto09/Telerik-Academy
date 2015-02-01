using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNNumbersSum
{
    class PrintNNumbersSum
    {
        static void Main()
        {
            Console.Write("Enter a value for n: ");
            int number=int.Parse(Console.ReadLine());
            int numberSum = 0;
            for (int index = 1; index <= number; index++)
            {
                Console.Write("Enter the {0} number: ",index);
                int dynamicNumber = int.Parse(Console.ReadLine());
                numberSum += dynamicNumber;
            }

            Console.WriteLine("The sum of the \"n\" numbers is equal to: {0}", numberSum);


        }
    }
}
