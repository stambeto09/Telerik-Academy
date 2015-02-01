using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSumSequence
{
    class MaximalSumSequence
    {
        //Write a program that finds the sequence of maximal sum in given array;
        static void Main()
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int bestSum = 0;
            int start = 0;
            int end = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int Sum = 0;
                for (int index = i; index < array.Length - 1; index++)
                {
                    Sum += array[index];
                    if (Sum>bestSum)
                    {
                        bestSum = Sum;
                        start = i;
                        end = index;
                    }
                    
                }

            }
            for (int index = start; index <=end; index++)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}
