using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        //Write a program that finds the maximal increasing sequence in an array;
        static void Main()
        {
            //Inputting the lenght of the array;
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            int[] thimes = new int[n];
            int[] numbers = new int[n];

            for (int index = 0; index < array.Length; index++)
            {
                numbers[index] = array[index];
                thimes[index] = 1;

                for (int l = index; l < array.Length; l++)
                {
                    //Checking if the current element is last;
                    if (l == array.Length - 1)
                    {
                        break;
                    }
                    //Checking if next element is equal to next one;
                    if (numbers[index] < array[l + 1])
                    {
                        thimes[index]++;
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
            //Write position times the element from numbers in position [position] :D ;
            for (int i = 0; i < thimes[position]; i++)
            {
                Console.Write(numbers[position+i]);
            }
            Console.Write("}");
        }
    }
}