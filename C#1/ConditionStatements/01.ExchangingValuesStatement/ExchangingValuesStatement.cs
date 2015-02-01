using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangingValuesStatement
{
    class ExchangingValuesStatement
    {
        static void Main()
        {
            Console.Write("Enter the first value: ");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Enter the second value: ");
            int secondValue = int.Parse(Console.ReadLine());
            int helpingValue = 0;

            if (firstValue>secondValue)
            {
                helpingValue = firstValue;
                firstValue = secondValue;
                secondValue = helpingValue;
                Console.WriteLine("The first value is greater than second value so we are swapping it: firstValue={0} and secondValue={1}. ", firstValue, secondValue);

   
            }
        }
    }
}
