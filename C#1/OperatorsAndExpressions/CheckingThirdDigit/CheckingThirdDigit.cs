using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingThirdDigit
{
    class CheckingThirdDigit
    {
        static void Main()
        {
            int hundreds = 0;
            int thousand = 0;
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            thousand = number / 1000;
            hundreds = ((number / 100) % 100) % 10;

            if (hundreds == 7)
            { 
                Console.WriteLine("The third digit is   7.");
            }
            else
            {
                Console.WriteLine("The third digit is not 7.");
            }

        }
    }
}
