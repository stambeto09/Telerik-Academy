using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumberBetweenTwo
{
    class GreaterNumberBetweenTwo
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double maxValue = Math.Max(firstNumber, secondNumber);

            Console.WriteLine("The greater value between {0} and {1} is {2}. ", firstNumber, secondNumber, maxValue);



        }
    }
}
