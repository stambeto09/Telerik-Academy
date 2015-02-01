using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.AllCombinations
{
    class AllCombinations
    {
        static int N = int.Parse(Console.ReadLine());
        static int K = int.Parse(Console.ReadLine());

        //Generates variations;
        static void Combinations(int[] array, int index, int currentNumber)
        {
            if (index == array.Length)
            {
                PrintArray(array);
            }
            else
            {
                for (int i = currentNumber; i <= N; i++)
                {
                    array[index] = i;
                    Combinations(array, index + 1, i + 1);
                }
            }
        }

        //Prints array;
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
