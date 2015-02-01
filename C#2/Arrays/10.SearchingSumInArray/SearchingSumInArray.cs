using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SearchingSumInArray
{
    //Write a program that finds in given array of integers a sequence of given sum S (if present);
    class SearchingSumInArray
    {
        static void Main()
        {
            Console.Write("Enter the length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int index = 0; index < array.Length-1; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            //Declaring two variables for end and start indexes of the sequence;
            int start = 0;
            int end = 0;
            //We are using two nested arrays for finding the sequence- check the book at page 266;
            for (int i = 0; i < array.Length-1; i++)
            {
                int Sum = 0;
                for (int index = i; index < array.Length-1; index++)
                {
                    Sum += array[index];
                    if (Sum>11)
                    {
                        break;
                    }
                    if (Sum==11)
                    {
                         start = i;
                         end= index;
                        break;
                        
                    }
                }
                
            }
            //Printing the result;
            for (int index = start; index <=end;index++)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}
