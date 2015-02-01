using System;
using System.Linq;


namespace NumberInArrayMethodNamespace
{

   public class NumberInArrayMethod
    {
        //Write a method that counts how many times given number appears in given array. 
        //Write a test program to check if the method is working correctly;

       public static int FindNumber(int[] numbers,int number)
       {
           int times = 0;
           for (int index = 0; index < numbers.Length-1; index++)
           {
               if (numbers[index]==number)
               {
                   times++;
               }
           }
           return times;
       }
        static void Main()
        {
            Console.Write("Enter a number for length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter a searched number: ");
            int searchedNumber = int.Parse(Console.ReadLine());

            int[] array = new int[length];
            for (int index = 0; index < array.Length-1; index++)
            {
                Console.Write("Enter the element number {0}:", index);
                 array[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number {0} is founded {1} times in the array.",searchedNumber,FindNumber(array, searchedNumber));

        }
    }
}
