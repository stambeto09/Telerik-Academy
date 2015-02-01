using System;
using System.Linq;

namespace _01c.PrintingMultidimensionalMatrixC
{
    class PrintingMultidimensionalMatrixC
    {
        static void ExamC(int[,] arr)
        {
            int counter = 1;
            int curLen = arr.GetLength(0) - 1;

            while (curLen >= 0)
            {
                for (int i = curLen; i < arr.GetLength(0); i++)
                {
                    arr[i, i - curLen] = counter;
                    counter++;
                }

                curLen--;
            }

            curLen = 1;

            while (curLen <= arr.GetLength(0) - 1)
            {
                for (int i = curLen; i < arr.GetLength(0); i++)
                {
                    arr[i - curLen, i] = counter;
                    counter++;
                }

                curLen++;
            }

            PrintMatrix(arr);
        }
        static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0, -4}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.Write("Please enter N: ");
            int N = int.Parse(Console.ReadLine());

            int[,] arr = new int[N, N];

           
            ExamC(arr);
        }  
    }
}
