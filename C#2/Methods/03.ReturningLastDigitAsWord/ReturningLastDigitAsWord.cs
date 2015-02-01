using System;
using System.Linq;


namespace FindLastDigitAsWord
{
    //Write a method that returns the last digit of given integer as an English word;
    class FindLastDigitAsWord
    {   

        //Checking what's the last digit of our number;
        public static string CheckLastDigit(string inputValue)
        {
           int value = int.Parse(inputValue);
           int lastDigit = value % 10;
           string bla="0";
           switch(lastDigit)
           {
               case 0: bla = "Null"; break;
               case 1: bla = "One"; break;
               case 2: bla = "Two"; break;
               case 3: bla = "Three"; break;
               case 4: bla = "Four"; break;
               case 5: bla = "Five"; break;
               case 6: bla = "Six"; break;
               case 7: bla = "Seven"; break;
               case 8: bla = "Eight"; break;
               case 9: bla = "Nine"; break;
           }
           return bla;
       }
        static void Main()
        {
            Console.Write("Enter a number :");
            string number=Console.ReadLine();

            Console.WriteLine(CheckLastDigit(number));
        }
    }
}
