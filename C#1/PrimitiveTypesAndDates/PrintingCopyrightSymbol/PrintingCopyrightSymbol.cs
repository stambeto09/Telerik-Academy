using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingCopyrightSymbol
{
    class PrintingCopyrightSymbol
    {
        static void Main()
        {
            char symbol = '\u00a9';

            Console.WriteLine(" " + " " + " " + symbol);
            Console.WriteLine(" " + " " + symbol + " " + symbol);
            Console.WriteLine(" " + symbol + " " + " " + " " + symbol);
            Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);

        }
    }
}
