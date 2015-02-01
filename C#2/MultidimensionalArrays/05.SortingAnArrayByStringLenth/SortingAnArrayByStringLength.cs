using System;
using System.Linq;

namespace _05.SortingAnArrayByStringLenth
{
    class SortingAnArrayByStringLength
    {
        public static void SortingStringArrayByLength(string [] array)
        {
            
            for (int index = 0; index < array.Length-1; index++)
            {
                for (int wordPosition = 0; wordPosition < array.Length-1; wordPosition++)
                {
                    if (array[wordPosition].Length>array[wordPosition+1].Length)
                    {
                        string swapValue = array[wordPosition];
                        array[wordPosition] = array[wordPosition + 1];
                        array[wordPosition + 1] = swapValue;
                        swapValue = "";
                    }
                }
            }

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }
        static void Main()
        {
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            string[] sequenceOfStrings = new string[length];

            for (int index = 0; index < sequenceOfStrings.Length; index++)
            {

                sequenceOfStrings[index] = Console.ReadLine();

            }

            SortingStringArrayByLength(sequenceOfStrings);
        }
    }
}
