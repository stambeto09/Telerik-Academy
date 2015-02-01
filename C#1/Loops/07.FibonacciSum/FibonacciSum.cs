using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FibonacciSum
{
    class FibonacciSum
    {
        static void Main()
        {
            int number = 0;
            int twoBehind = 0;
            int oneBehind = 1;
            Console.Write("Enter a number n: ");
            int n = int.Parse(Console.ReadLine());
            int sum=0;

            for (int i = 1; i <= n; i++)
            {
                number = twoBehind + oneBehind;
                twoBehind = oneBehind;
                oneBehind = number;
                sum += number;
            }
            Console.WriteLine("The sum of the first {0} numbers is equal to: {1}", n, sum);
        }
    }
}