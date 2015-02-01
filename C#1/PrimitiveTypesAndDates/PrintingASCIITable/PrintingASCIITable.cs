using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingASCIITable
{
    class PrintingASCIITable
    {
        static void Main()
        {
            for (int index= 0; index <= 255; index++)
            {
                char symbol = (char)index;
                Console.Write(" "+symbol);
            }
        }
    }
}
