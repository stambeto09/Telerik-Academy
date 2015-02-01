using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TwoFactMultiplying
{
    class TwoFactMultiplying
    {
        static void Main()
        {

            Console.Write("Enter a value for N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for K: ");
            int K = int.Parse(Console.ReadLine());
            int factN=1;
            int factK=1;
            int result = 0;

            for (int i = 0; i < N; i++)
            {
                factN *= (N - i);
            }

            Console.WriteLine(factN);

            for (int i = 0; i < K; i++)
            {
                factK *= (K - i);
            }
            Console.WriteLine(factK);

            result = factN * factK;

            Console.WriteLine("The result is equal to:{0}", result/(K-N));


        }
    }
}
