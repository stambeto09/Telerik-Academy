using System;
using System.Linq;


namespace _04.SearchingFirstSmallerElementThanKInArray
{
    class SearchingFirstSmallerElementThanKInArray
    {
        static void Main()
        {
            Console.Write("Enter a value for length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] sequenceOfNumbers = new int[length + 1];

            for (int index = 0; index < sequenceOfNumbers.Length-1; index++)
            {
                
                sequenceOfNumbers[index] = int.Parse(Console.ReadLine());

            }

            Console.Write("Now enter your K number: ");
            int K = int.Parse(Console.ReadLine());
            sequenceOfNumbers[sequenceOfNumbers.Length - 1] = K;

            int indexOf=Array.BinarySearch(sequenceOfNumbers, K);

            Console.WriteLine("The searched number is equal to: {0}",sequenceOfNumbers[indexOf-1]);
        }
    }
}
