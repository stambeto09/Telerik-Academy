using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingIntToBitNumber
{
    class ExtractingIntToBitNumber

    {
        static void Main()
        {

            Console.Write("Enter your integer value: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the position p: ");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int logicalAndResult = n & mask;
            int bit = logicalAndResult >> p;
            if (bit==1)
            {
                Console.WriteLine(bit);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
