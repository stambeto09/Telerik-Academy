using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace _04.SortingAlgorithms
{
    class SortingAlgorithms
    {

        private static string InsertionSort<T>(T[] array) where T : IComparable
        {
            Stopwatch stopwatch = new Stopwatch();
            int i, j;
            T index;
            stopwatch.Start();
            for (i = 1; i < array.Length; i++)
            {
                index = array[i];
                j = i;
                while ((j > 0) && (array[j - 1].CompareTo(index) > 0))
                {
                    array[j] = array[j - 1];
                    j = j - 1;
                }
                array[j] = index;
            }
            stopwatch.Stop();
            return stopwatch.Elapsed.ToString();
        }

        private static string SelectionSort<T>(T[] array) where T : IComparable
        {
            int _min = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < array.Length; i++)
            {
                _min = i;

                for (int j = i; j < array.Length; j++)
                {

                    if (array[j].CompareTo(array[_min]) < 0)

                        _min = j;

                }

                var _temp = array[i];

                array[i] = array[_min];

                array[_min] = _temp;

            }
            stopwatch.Stop();
            return stopwatch.Elapsed.ToString();
        }

        public static void Quicksort<T>(T[] elements, int left, int right) where T : IComparable
        {
            int i = left, j = right;
            T middle = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(middle) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(middle) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    T tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }
        }


        static void Main()
        {
            Console.WriteLine("Insertion sort.");
            // Sorted arrays with insertion sort
            Console.WriteLine("Sorted arrays:");
            int[] sortedArrayOfInts = new int[10];
            for (int index = 0; index < sortedArrayOfInts.Length; index++)
            {
                sortedArrayOfInts[index] = index + 1;
            }
            Console.WriteLine("Sorted array of ints: {0}", InsertionSort(sortedArrayOfInts));

            double[] sortedArrayOfDoubles = new double[10];
            for (int index = 0; index < sortedArrayOfDoubles.Length; index++)
            {
                sortedArrayOfDoubles[index] = index + 1;
            }
            Console.WriteLine("Sorted array of doubles: {0}", InsertionSort(sortedArrayOfDoubles));

            string[] sortedArrayOfString = new string[10];
            for (int index = 0; index < sortedArrayOfString.Length; index++)
            {
                sortedArrayOfString[index] = new string('a', index + 1);
            }
            Console.WriteLine("Sorted array of strings: {0}", InsertionSort(sortedArrayOfString));


            // Random array with insertion sort
            Console.WriteLine("Random array:");
            int[] randomArrayOfInts = new int[10];
            Random random = new Random();
            for (int index = 0; index < randomArrayOfInts.Length; index++)
            {
                randomArrayOfInts[index] = random.Next(int.MinValue, int.MaxValue);
            }
            Console.WriteLine("Random array of ints: {0}", InsertionSort(randomArrayOfInts));

            double[] randomArrayOfDoubles = new double[10];
            for (int index = 0; index < sortedArrayOfDoubles.Length; index++)
            {
                randomArrayOfDoubles[index] = random.NextDouble() * Math.PI;
            }
            Console.WriteLine("Random array of doubles: {0}", InsertionSort(randomArrayOfDoubles));

            string[] randomArrayOfStrings = new string[10];
            for (int index = 0; index < sortedArrayOfString.Length; index++)
            {
                randomArrayOfStrings[index] = random.Next(byte.MinValue, byte.MaxValue) + " symbols";
            }
            Console.WriteLine("Random array of strings: {0}", InsertionSort(randomArrayOfStrings));

            // Reversed array with insertion sort
            Console.WriteLine("Reversed array:");
            int[] reversedArrayOfInts = new int[10];
            for (int index = 0; index < reversedArrayOfInts.Length; index++)
            {
                reversedArrayOfInts[index] = reversedArrayOfInts.Length - index - 1;
            }
            Console.WriteLine("Reversed array of ints: {0}", InsertionSort(reversedArrayOfInts));

            double[] reversedArrayOfDoubles = new double[10];
            for (int index = 0; index < reversedArrayOfDoubles.Length; index++)
            {
                reversedArrayOfDoubles[index] = reversedArrayOfDoubles.Length - index - 1;
            }
            Console.WriteLine("Reversed array of doubles: {0}", InsertionSort(reversedArrayOfDoubles));

            string[] reversedArrayOfStrings = new string[10];
            for (int index = 0; index < sortedArrayOfString.Length; index++)
            {
                reversedArrayOfStrings[index] = new string('a', reversedArrayOfStrings.Length - index - 1);
            }
            Console.WriteLine("Reversed array of strings: {0}", InsertionSort(reversedArrayOfStrings));

            Console.WriteLine("Selection sort");
            Console.WriteLine("Sorted arrays:");
            Console.WriteLine("Sorted array of ints: {0}", SelectionSort(sortedArrayOfInts));
            Console.WriteLine("Sorted array of doubles: {0}", SelectionSort(sortedArrayOfDoubles));
            Console.WriteLine("Sorted array of strings: {0}", SelectionSort(sortedArrayOfString));

            Console.WriteLine("Random arrays:");
            Console.WriteLine("Sorted array of ints: {0}", SelectionSort(randomArrayOfInts));
            Console.WriteLine("Sorted array of doubles: {0}", SelectionSort(randomArrayOfDoubles));
            Console.WriteLine("Sorted array of strings: {0}", SelectionSort(randomArrayOfStrings));

            Console.WriteLine("Reversed arrays");
            Console.WriteLine("Reversed array of ints: {0}", SelectionSort(reversedArrayOfInts));
            Console.WriteLine("Reversed array of doubles: {0}", SelectionSort(reversedArrayOfDoubles));
            Console.WriteLine("Reversed array of strings: {0}", SelectionSort(reversedArrayOfStrings));

        }
    }
}
