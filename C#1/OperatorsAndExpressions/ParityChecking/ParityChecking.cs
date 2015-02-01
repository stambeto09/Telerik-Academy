using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParityChecking
{
    class ParityChecking
    {
        static void Main()
        {
            Console.Write("Enter the value of the integer: " );
            int variable =int.Parse (Console.ReadLine());
            
            Console.Write("Is your variable odd?-");
            Console.WriteLine(variable % 2 == 0 ? false : true);

        }
    }
}
