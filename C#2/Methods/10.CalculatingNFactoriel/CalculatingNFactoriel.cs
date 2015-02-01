using System;
using System.Linq;
using System.Numerics;

namespace _10.CalculatingNFactoriel
{

    class CalculatingNFactoriel
    {
        //Write a program to calculate n! for each n in the range [1..100]. 
        //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
        public static BigInteger CalculateFactoriel(BigInteger number)
        {
            BigInteger Factorial = 1;

            for (BigInteger i = number; i >0 ; i--)
            {
                Factorial *= i;
            }
            return Factorial;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            
            Console.WriteLine( CalculateFactoriel(n));

        }
    }
    
}
