using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.DecimalToBinaryConverter
{
    //Write a program to convert decimal numbers to their binary representation.
    class DecimalToBinaryConverter
    {
        public static void ConvertNumber(int numberParameter)
        {
            List<int> numberInList = new List<int>();

            while (numberParameter>0)
            {
                numberInList.Add(numberParameter&1);
                numberParameter = numberParameter >> 1;
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
            Console.Write("Enter your decimal number: ");
            int number = int.Parse(Console.ReadLine());

            ConvertNumber(number);
        }
    }
}
