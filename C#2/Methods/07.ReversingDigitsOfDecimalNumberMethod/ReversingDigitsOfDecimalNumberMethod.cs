using System;
using System.Linq;


namespace _07.ReversingDigitsOfDecimalNumber
{
    //Write a method that reverses the digits of given decimal number.
     public class ReversingDigitsOfDecimalNumberMethod
    {
         public static decimal[] ReversingNumber(decimal number)
         {
             decimal[]numberArray=new decimal[11];
             decimal digit = 0;
             int index = 0;
             while (number!=0)
             {
                 digit=number% 10;

                 number = number / 10;
                 int number1 = (int)number ;
                 number = number1;
                 numberArray[index] = digit;
                 index++;
             }
             decimal[] newArray = new decimal[index+1];
             for (int i = 0; i < newArray.Length-1; i++)
             {
                 newArray[i] = numberArray[i];
             }
             return newArray;
         }
        static void Main()
        {
            Console.Write("Enter your decimal number: ");
            decimal num = int.Parse(Console.ReadLine());


           
            decimal[] array= ReversingNumber(num);

            //Printing the number
            for (int index = 0; index < array.Length-1; index++)
            {
                Console.Write(array[index]);
            }
            Console.WriteLine();

        }
    }
}
