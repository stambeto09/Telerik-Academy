using System;
using System.Linq;

namespace _02.BinaryToDecimalConverter
{
    //Write a program to convert binary numbers to their decimal representation.
    class Converter
    {
        public static void ConvertDecimalNumberToBinary(int numberParameter)
        {
            double sum=0;
            double position = 0;
            double currentDigitInBinary = 0;
            double currentDigitInDecimal = 0;

           while(numberParameter>0)
           {
               currentDigitInBinary = numberParameter % 10;
               currentDigitInDecimal = currentDigitInBinary * Math.Pow(2, position);
               numberParameter = numberParameter / 10;
               sum += currentDigitInDecimal;
               position++;
           }

           Console.WriteLine("Your number in decimal representation is equal to: {0}", sum);

        }
        static void Main()
        {
            Console.Write("Enter your number in binary representation: ");
            int number = int.Parse(Console.ReadLine());

            ConvertDecimalNumberToBinary(number);
            
        }
    }
}
