using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.ArrayNElementsKMaxSum
{
    class ArrayNElementsKMaxSum
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum;

        static void Main()
        {   //Entering the N- the length of the array;
            Console.Write("Enter N: ");            
            int N = int.Parse(Console.ReadLine());
            //Entering the K- for sum;
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());
            //Declarating the array and his values;
            int[] array = new int[N];
            for (int index = 0; index < N; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            //Sorting the array;
            Array.Sort(array);
            List<int> range = array.ToList().GetRange(N - K, K);
            Console.WriteLine(string.Join(" ", range));
            Console.WriteLine(range.Sum());



        }
    }
}
