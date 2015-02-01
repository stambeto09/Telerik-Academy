using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingValues
{
    class SwappingValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c = 0;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("The value of swapped a with b is "+a);
            Console.WriteLine("The value of swapped b with a is "+b);

        }
    }
}
