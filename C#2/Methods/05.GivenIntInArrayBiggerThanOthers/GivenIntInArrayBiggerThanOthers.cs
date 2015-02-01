using System;
using System.Linq;

namespace _05.GivenIntInArrayBiggerThanOthers
{
    //Write a method that checks if the element at given position in given array of integers is bigger 
    //than its two neighbors (when such exist).

   public class GivenIntInArrayBiggerThanOthers
    {
       public static bool CheckElement(int[]searchedArray,int searchedElement)
       {
            var isBigger = false;
            //Checking the special cases when the index is 0 or lenght-1, in other words when is at first or last position;
           if ((searchedElement==0) && (searchedArray[searchedElement]>searchedArray[searchedElement+1]))
           {
               return isBigger = true;
           }
           if ((searchedElement ==searchedArray.Length-1) && (searchedArray[searchedElement] > searchedArray[searchedElement - 1]))
           {
               return isBigger = true;
           }
           //The normal case when the index is between two other elements;
           else if ((searchedArray[searchedElement] > searchedArray[searchedElement + 1]) && (searchedArray[searchedElement] > searchedArray[searchedElement]-1))
           {
               return isBigger = true;
           }
           else
           {
               return isBigger = false;
           }
          
       }
        static void Main()
        {
            Console.Write("Enter a length for array: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter a postion for element: ");
            int position = int.Parse(Console.ReadLine());
            

            int[] array = new int[length];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Is your number greater than his neighbors: {0}. ", CheckElement(array, position));
        }
    }
}
