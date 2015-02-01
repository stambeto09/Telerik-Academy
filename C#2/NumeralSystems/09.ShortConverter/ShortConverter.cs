using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ShortConverter
{
    class ShortConverter
    {

        public static void ConvertNumber(int  numberParameter)
        {
            List<int> numberInList = new List<int>();

            while (numberParameter > 0)
            {
                numberInList.Add(numberParameter & 1);
                numberParameter = numberParameter >> 1;
            }

            numberInList.Reverse();
          
            Console.Write("The number in binary representation is equal to: ");
            Console.Write(new string('0', 16 - numberInList.Count));
            for (int index = 0; index < numberInList.Count; index++)
            {
                Console.Write("{0}", numberInList[index]);
            }
            Console.WriteLine();

        }
        static void Main()
        {
            Console.Write("Enter your decimal number: ");
            short number = short.Parse(Console.ReadLine());

            ConvertNumber(number);
        }
    }

}
