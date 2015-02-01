using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TwoFactorielsDividing
{
    class TwoFactorielsDividing
    {
        static void Main()
        {
            int fact = 1;
            Console.Write("Enter the value of N:");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Ente the value of K:");
            int K = int.Parse(Console.ReadLine());

            if ((K < 1) || (N < K))
            {
                Console.WriteLine("Enter a value greater that 1. ");
            }
            else
            {
                for (int i = 0; i <= N - K - 1; i++)
                {
                    fact = fact * (N - i);

                }
                Console.WriteLine("The dividing N!/K! is equal to:"+ fact);
            }
        }
    }
}
