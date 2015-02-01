using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestIntegerNumber
{
    class BiggestIntegerNumber
    {
        static void Main()
        {
            Console.Write("Enter a value for first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine(firstNumber);
                }
            }
            else if(secondNumber>firstNumber)
            {
                if (secondNumber>thirdNumber)
                {
                    Console.WriteLine(secondNumber);
                }
            }
            else if (thirdNumber > firstNumber)
            {
                if (thirdNumber>secondNumber)
                {
                    Console.WriteLine(thirdNumber);
                }
            }
        }
    }
}
