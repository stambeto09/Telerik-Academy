using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EuclideanAlgorithm
{
    class EuclideanAlgorithm
    {
        static void Main()
        {
            Console.Write("Enter your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int current;
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("Both numbers are equal. ");
            }

            if (firstNumber > secondNumber)
            {
                while (firstNumber % secondNumber != 0)
                {
                    current = firstNumber % secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = current;
                }
                Console.WriteLine("The gratest common divisor is: {0}", secondNumber);
            }
            if (secondNumber > firstNumber)
            {
                while (secondNumber % firstNumber != 0)
                {
                    current = secondNumber % firstNumber;
                    secondNumber = firstNumber;
                    firstNumber = current;
                }
                Console.WriteLine("The gratest common divisor is: {0}", firstNumber);

            }
        }
    }
}
