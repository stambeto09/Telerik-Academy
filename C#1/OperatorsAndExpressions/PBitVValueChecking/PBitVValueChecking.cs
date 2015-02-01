using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBitVValueChecking
{
    class PBitVValueChecking
    {
        static void Main()
        {
            Console.Write("Enter your integer value: ");
            int variable = int.Parse(Console.ReadLine());
            Console.Write("Enter your position p: ");
            int position =int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int logicalAndResult = variable & mask;
            int bit = logicalAndResult >> position;
            if (bit==1)
            {
            Console.WriteLine(true);    
            }
            else
            {
                Console.WriteLine(false);
            }   
        }
    }
}
