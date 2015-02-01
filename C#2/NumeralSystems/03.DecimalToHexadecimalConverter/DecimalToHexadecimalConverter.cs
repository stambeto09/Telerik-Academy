using System;
using System.Linq;
using System.Collections.Generic;

namespace DecimalToHexadecimalConverter
{
    //Write a program to convert decimal numbers to their hexadecimal representation.
    class Converter
    {
        public static void ConvertDecimalNumberToHexadecimal(int decimalNumber)
        {
            List<int> numberInList = new List<int>();

            while (decimalNumber > 0)
            {
                numberInList.Add(decimalNumber & 15);
                decimalNumber = decimalNumber >> 4;
            }

            numberInList.Reverse();

            Console.Write("The number in binary representation is equal to: ");
            for (int index = 0; index < numberInList.Count; index++)
            {
                if (numberInList[index]==10)
                {
                    Console.Write("A");
                }
                else if (numberInList[index]==11)
                {
                    Console.Write("B");
                }
                else if (numberInList[index] == 12)
                {
                    Console.Write("C");
                }
                else if (numberInList[index] == 13)
                {
                    Console.Write("D");
                }
                else if (numberInList[index] == 14)
                {
                    Console.Write("E");
                }
                else if (numberInList[index] == 15)
                {
                    Console.Write("F");
                }
                else
                {
                    Console.Write("{0}", numberInList[index]);
                }
                
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Console.Write("Enter your number in decimal representation: ");
            int number = int.Parse(Console.ReadLine());

            ConvertDecimalNumberToHexadecimal(number);
        }
    }
}
