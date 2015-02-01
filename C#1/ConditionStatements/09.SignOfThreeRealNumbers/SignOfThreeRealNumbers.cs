using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SignOfThreeRealNumbers
{
    class SignOfThreeRealNumbers
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("Multiplying by 0 is not allowed.");
            }
            else
            {
                if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
                {
                    Console.WriteLine("The sign of the three numbers product is +");
                }
                else if (firstNumber < 0 && thirdNumber < 0 && secondNumber > 0)
                {
                    Console.WriteLine("The sign of the three numbers product is +");
                }
                else if (secondNumber < 0 && thirdNumber < 0 && firstNumber > 0)
                {
                    Console.WriteLine("The sign of the three numbers product is +");
                }
                else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
                {
                    Console.WriteLine("The sign of the three numbers product is +");
                }
                else
                {
                    Console.WriteLine("The sight of the three numbers product is -");
                }
            }
        }
    }
}
