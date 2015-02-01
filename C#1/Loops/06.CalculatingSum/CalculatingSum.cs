using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculatingSum
{
    class CalculatingSum
    {
        static void Main()
        {
            Console.Write("Enter a value for N: ");
            int NValue = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for X: ");
            int XValue = int.Parse(Console.ReadLine());
            int currentFactoriel = 1;
            double sum = 1;

            for (int index = 1; index <= NValue; index++)
            {

                for (int i = 1; i <= NValue; i++)
                {
                    currentFactoriel *= i;
                }
                
                sum += (currentFactoriel / Math.Pow(XValue, NValue));

            }
            Console.WriteLine(sum);
        }
    }
}
