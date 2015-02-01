using System;
using System.Linq;


namespace _01.ArrayMutipliedIndexByFive
{
    class ArrayMutipliedIndexByFive
    {   //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

        static void Main()
        {   
            //Declaring the array
            int[] array = new int[20];

            //Multiplying the array index with five;
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = index * 5;
                Console.WriteLine(array[index]);
            }



        }
    }
}
