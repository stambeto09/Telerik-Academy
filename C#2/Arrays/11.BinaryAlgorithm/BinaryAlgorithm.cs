using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinaryAlgorithm
{
    class BinaryAlgorithm
    {
        //Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm;

        static void Main(string[] args)
        {
            Console.Write("Enter a length for array: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int searchedNumber = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int startSearch = 0;
            int endSearch = array.Length - 1;
            int middle;

            while (startSearch <= endSearch)
            {
                middle = (startSearch + endSearch) / 2;

                if (array[middle] == searchedNumber)
                {
                    Console.WriteLine("Index is: {0}.", middle);
                    break;
                }

                if (array[middle] < searchedNumber)
                {
                    startSearch = middle + 1;
                }

                if (array[middle] > searchedNumber)
                {
                    endSearch = middle - 1;
                }
            }
        }
    }
}
