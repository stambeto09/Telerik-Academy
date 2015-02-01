using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MatrixLoop
{
    class MatrixLoop
    {
        static void Main()
        {
            Console.Write("Enter n=");
            int n = int.Parse(Console.ReadLine());
            if (n > 20)
            {
                return;
            }
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= row + n - 1; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
