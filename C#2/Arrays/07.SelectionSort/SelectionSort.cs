using System;
using System.Linq;


namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            //Inputting the array;
            Console.Write("Enter a length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array= new int[length];

            for (int index = 0; index <array.Length; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
           //Checking with two nested loops if the current number is bigger than the other ones and swap it if it's;
            for (int index = 0; index < array.Length-1; index++)
            {
                for (int current = index+1; current < array.Length; current++)
                {
                    int variable = 0;
                    if (array[index]>array[current])
                    {
                        variable = array[index];
                        array[index] = array[current];
                        array[current] = variable;
                    }
                }
            }
            //Printing the array;
            Console.WriteLine("The sorted array:");
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
           
            
        }
    }
}
