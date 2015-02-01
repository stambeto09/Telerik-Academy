using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ComparingTwoArrays
{
    class ComparingTwoArrays
    {

        //Write a program that reads two arrays from the console and compares them element by element.

        static void Main()
        {   //Declaring a lenght of the arrays;
            Console.Write("Enter a lenght for arrays: ");
            int arraysLenght = int.Parse(Console.ReadLine());

          //Declaring two arrays;
            int[] firstArray = new int[arraysLenght];
            int[] secondArray = new int[arraysLenght];

            //Inputting the elements of first and second array

            for (int index = 0; index < arraysLenght; index++)
            {
                firstArray[index] = int.Parse(Console.ReadLine());
                secondArray[index] = int.Parse(Console.ReadLine());
            }

            //Comparing the two arrays element by element;
            bool isEqual=false;

            for (int index = 0; index < arraysLenght; index++)
            {
                if (firstArray[index]==secondArray[index])
                {
                    isEqual = true;
                }

                else
                {
                    isEqual = false;
                    break;
                    break;
                }
            }

            Console.WriteLine(isEqual);
            
        }
    }
}
