using System;
using System.Linq;

namespace _02._3x3MaximalSumSegment
{
    class SearchingMaximalSegment
    {

        static void Main()
        {
            Console.Write("Enter a value for N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for M: ");
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, M];
            string inputNumber;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    inputNumber = Console.ReadLine();
                    matrix[row, col] = int.Parse(inputNumber);
                }
            }
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                              + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                              + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                    sum = 0;
                }
            }

            Console.WriteLine(bestSum);

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("{0,3} ", matrix[bestRow, bestCol]);
                    bestCol++;
                }
                bestCol -= 3;
                bestRow++;
                Console.WriteLine();
            }
        }
    }
}

