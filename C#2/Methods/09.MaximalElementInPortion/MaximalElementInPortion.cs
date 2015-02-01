using System;
using System.Linq;

namespace MaximalElementInPortion
{
    class MaximalElementInPortion
    {
        //Write a method that return the maximal element in a portion of array of integers starting at given index. 
        //Using it write another method that sorts an array in ascending / descending order.

        public static int MaximalElement(int[] theArray, int start, int end)
        {
            Array.Sort(theArray);
            int maxValue = 0;
            for (int index = start; index <=end; index++)
            {
                if (theArray[index]>=maxValue)
                {
                    maxValue = theArray[index];
                }
            }
            return maxValue;
        }
        static void Main()
        {
            Console.WriteLine("Enter the start of the portions(The element should be part of the array): ");
            int startPortion = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end of the portion (the end value should be greater than starting)(The element should be part of the array): ");
            int endPortion = int.Parse(Console.ReadLine());

            Console.Write("Enter a value for length of the array: ");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(MaximalElement(array, startPortion, endPortion));
            
        }
    }
}
