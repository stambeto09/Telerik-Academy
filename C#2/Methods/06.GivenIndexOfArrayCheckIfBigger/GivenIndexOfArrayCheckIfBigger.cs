using System;
using System.Linq;

namespace GivenIndexOfArrayCheckIfBigerNameSpace
{
    //Write a method that returns the index of the first element in array that is bigger than its neighbors, 
    //or -1, if there’s no such element;

    class GivenIndexOfArrayCheckIfBigger
    {
        public static int CheckElement(int[] searchedArray)
        {
            for (int index = 0; index < searchedArray.Length - 1; index++)
            {


                //Checking the special cases when the index is 0 or lenght-1, in other words when is at first or last position;
                if ((index == 0) && (searchedArray[index] > searchedArray[index + 1]))
                {
                    return index;
                }
                if ((index == searchedArray.Length - 1) && (searchedArray[index] > searchedArray[index - 1]))
                {
                    return index;
                }
                //The normal case when the index is between two other elements;
                else if (searchedArray[index] > searchedArray[index + 1]&&searchedArray[index]>searchedArray[index-1])
                {
                    return index;
                }
               
            }
            return -1;
        }
        static void Main()
        {
            Console.Write("Enter a length for array: ");
            int length = int.Parse(Console.ReadLine());
            

            int[] array = new int[length];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The returning index which have element greater than his neighbors- {0} ", CheckElement(array));
        }
    }
}
