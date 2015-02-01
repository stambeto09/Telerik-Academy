using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.AlphabeticalArrayWordChecking
{
    

    class AlphabeticalArrayWordChecking
    {
        //Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array;
        static void Main()
        {
            //Decharing the array with length equal to number of letters in english alphabet;
            char[] array = new char[27];
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            
            
            for (int index = 0; index < array.Length-1; index++)
            {
                array[index] = (char)(65 + index);
            }
            
            for (int index = 0; index < word.Length; index++)
            {
                for (int i = 0; i <array.Length-1; i++)
                {
                    
                    if (word[index]==array[i])
                    {
                        Console.WriteLine("Letter number {0}, index {1}",index,i);
                    }
                }
            }
        }
    }
}
