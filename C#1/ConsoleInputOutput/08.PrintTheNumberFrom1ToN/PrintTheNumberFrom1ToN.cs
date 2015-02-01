using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrintTheNumberFrom1ToN
{
    class PrintTheNumberFrom1ToN
    {
        static void Main()
        {
            Console.Write("Enter a value for n: ");
            int number = int.Parse(Console.ReadLine());

            for (int index = 1; index <= number; index++)
            {
                Console.WriteLine(index);
            }
        }
    }
}
