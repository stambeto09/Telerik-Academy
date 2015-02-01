using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNumbersSum
{
    class ThreeNumbersSum
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine("The sum of first, second and third number is: {0}", sum);

        }
    }
}
