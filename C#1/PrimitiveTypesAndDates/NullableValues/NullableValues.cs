using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableValues
{
    class NullableValues
    {
        static void Main()
        {
            int? a=null;
            double? b=null;
            Console.WriteLine("a={0}",a);
            Console.WriteLine("b={0}",b);
            Console.WriteLine(a+2);
            Console.WriteLine(b+3);


        }
    }
}
