using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequenceInArray
{
    class MaximalSequenceInArray
    {
        //Write a program that finds the maximal sequence of equal elements in an array.

        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
            }
            
            int[] thimes = new int[arr.Length];
            int[] numbers = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = arr[i];
                thimes[i] = 1;

                for (int l = i; l < arr.Length; l++)
                {   
                    //Checking if the current element is last;
                    if (l == arr.Length-1)
                    {
                        break;
                    }
                    //Checking if next element is equal to next one;
                    if (numbers[i] == arr[l+1])
                    {
                        thimes[i]++;
                    }
                    //If it's not-break;
                    else
                    {
                        break;
                    }
                }
            }
            //Getting the max value from thimes array.
            int maxTimes = thimes.Max();
            //Create a new variable that is equal to INDEX of maxTimes value;
            int position = Array.IndexOf(thimes, maxTimes);
            
            Console.Write("{");
            //Write position times the element from numbers in position [position+i] :D ;
            for (int i = 0; i <thimes[position]; i++)
            { 
                Console.Write(numbers[position+i]);
            }
            Console.Write("}");

            

        }
    }
}
