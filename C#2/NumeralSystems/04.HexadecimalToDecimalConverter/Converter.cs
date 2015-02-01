using System;
using System.Linq;

namespace HexadecimalToDecimalConverter
{
    //Write a program to convert hexadecimal numbers to their decimal representation.
    class Converter
    {
        public static void HexadecimalToDecimalConverter(string hexadecimalNumber)
        {
            //Intializing a new array to place the values of the letters on it;
            int[] hexadecimalNumberInArray = new int[hexadecimalNumber.Length];

            //Checking for inputted letters and convert them into numbers;
            for (int index = 0; index < hexadecimalNumber.Length; index++)
            {
                if (hexadecimalNumber[index]=='A')
                {
                    hexadecimalNumberInArray[index] = 10;
                }

                else if (hexadecimalNumber[index]=='B')
                {
                    hexadecimalNumberInArray[index] = 11;
                }

                else if (hexadecimalNumber[index] == 'C')
                {
                    hexadecimalNumberInArray[index] = 12;
                }

                else if (hexadecimalNumber[index] == 'D')
                {
                    hexadecimalNumberInArray[index] = 13;
                }

                else if (hexadecimalNumber[index] == 'E')
                {
                    hexadecimalNumberInArray[index] = 14;
                }

                else if (hexadecimalNumber[index] == 'F')
                {
                    hexadecimalNumberInArray[index] = 15;
                }

                else 
                {
                    hexadecimalNumberInArray[index] = (int)Char.GetNumericValue(hexadecimalNumber[index]);
                }
                
            }
            //Reversing the array to use the index for degree and declaring a new sum variable for the final result;
            Array.Reverse(hexadecimalNumberInArray);
            double numberInDecimal=0;


            for (int index = 0; index < hexadecimalNumberInArray.Length; index++)
            {

                numberInDecimal += hexadecimalNumberInArray[index] * Math.Pow(16, index);

            }

            Console.WriteLine("Your number in decimal numeral system is equal to: {0}",numberInDecimal);
        }
        static void Main()
        {
            string number = Console.ReadLine();

            HexadecimalToDecimalConverter(number);

        }
    }
}
