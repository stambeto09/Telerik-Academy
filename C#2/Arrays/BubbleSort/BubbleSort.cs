using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort
    {
                
        static void Main()
        {
            //Inputting the array;
            Console.Write("Enter a length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            for (int index = array.Length-1; index >0; index--)
            {
                for (int current =0; current < index; current++)
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
