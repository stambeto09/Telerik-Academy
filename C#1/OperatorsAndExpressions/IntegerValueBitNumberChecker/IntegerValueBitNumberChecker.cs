using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerValueBitNumberChecker
{
    class IntegerValueBitNumberChecker
    {
        static void Main()
        {
            Console.Write("Enter your integer value: ");
            int variable = int.Parse(Console.ReadLine());
            Console.Write("Enter bit number: ");
            int bitNumber =int.Parse(Console.ReadLine());
            int mask = 1 << bitNumber;
            int logicalAndResult = variable & mask;
            int bit = logicalAndResult >> bitNumber;
            Console.WriteLine(bit);
        }
        }
    }

