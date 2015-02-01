using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ConvertingFromSToDSystem
{
    class ConvertingFromStoDsystem
    {
        static void ConverterFromStoDNumeralSystem(int numberS,int numberD)
        {
            double sum = 0;
            double position = 0;
            double currentDigitInBinary = 0;
            double currentDigitInDecimal = 0;

            while (numberS > 0)
            {
                currentDigitInBinary = numberS % 10;
                currentDigitInDecimal = numberS * Math.Pow(2, position);
                numberS = numberS / 10;
                sum += currentDigitInDecimal;
                position++;
            }

            int numberInDecimal = Convert.ToInt32(sum);
            List<int> numberInList = new List<int>();

            while (sum > 0)
            {
                numberInList.Add(numberInDecimal & numberD-1);
                sum = numberInDecimal >> numberD-1;
            }

            numberInList.Reverse();

            Console.Write("The number in binary representation is equal to: ");
            for (int index = 0; index < numberInList.Count; index++)
            {
                Console.Write("{0}", numberInList[index]);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Console.Write("Enter your number in S-numeral system: ");
            int snumber = int.Parse(Console.ReadLine());
            Console.Write("Now enter the base of the other numeral system: ");
            int dNumber = int.Parse(Console.ReadLine());

            ConverterFromStoDNumeralSystem(snumber,dNumber);
        }
    }
}
