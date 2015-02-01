using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MostFrequentNumberInArray
{
    class MostFrequentNumberInArray
    {
        //Write a program that finds the most frequent number in an array.
        static void Main()
        {
            //<<<<<<<<<<<<<THE MAIN IDEA>>>>>>>> - I am getting all the code from 04.MaximalSequenceInArray 
            //and instead of printing the maximal sequence, first I'm sorting the array, and then find the maximal sequence :) ;
            
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
            }

            int[] thimes = new int[arr.Length];
            int[] numbers = new int[arr.Length];

            //The main sorting;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = arr[i];
                thimes[i] = 1;

                for (int l = i; l < arr.Length; l++)
                {
                    //Checking if the current element is last;
                    if (l == arr.Length - 1)
                    {
                        break;
                    }
                    //Checking if next element is equal to next one;
                    if (numbers[i] == arr[l + 1])
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

            Console.WriteLine("The most frequent number is {0}.",arr[position]);

        }
    }
}
