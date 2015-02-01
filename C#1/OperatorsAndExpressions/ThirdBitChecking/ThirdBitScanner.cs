using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBitChecking
{
    class ThirdBitScanner
    {
        static void Main()
        {
            Console.Write("Enter your integer value: ");
            int variable = int.Parse(Console.ReadLine());
            int position = 4;         
            int mask = 1 << position;        
            int logicalAndResult = variable & mask;  
            int bit = logicalAndResult >> position;  
            Console.WriteLine(bit);



           


        }
    }
}
