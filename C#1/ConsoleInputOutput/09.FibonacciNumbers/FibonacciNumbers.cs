using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int number = 0;
            int twoBehind = 0;
            int oneBehind = 1;
            Console.WriteLine(twoBehind);
            Console.WriteLine(oneBehind);
            int n=100;

            for (int i = 1; i <= n; i++)
            {
                number = twoBehind + oneBehind;
                Console.WriteLine(number);
                twoBehind = oneBehind;
                oneBehind = number;
            }
        }
    }
}
