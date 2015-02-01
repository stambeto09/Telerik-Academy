using System;
using System.Linq;


namespace _03.ComparingLexicographyTwoArrays
{
    class ComparingLexicographyTwoArrays
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).

        static void Main()
        {
            Console.Write("Enter your first word: ");
            string firstWord = Console.ReadLine();
            Console.Write("Enter your second word: ");
            string secondWord = Console.ReadLine();

            int maxLength=Math.Max(firstWord.Length,secondWord.Length);
            int minLength=Math.Min(firstWord.Length,secondWord.Length);

            bool firstBefore = false;
            bool secondBefore = false;
            bool Equal = false;

            //IF WORDS ARE WITH DIFFERENT SIZES;
            if (firstWord.Length != secondWord.Length)
            {
                for (int index = 0; index < minLength - 1; index++)
                {
                    //Converting our current indexes into chars;
                    char firstStringCurrentSymbol = firstWord[index];
                    char secondStringCurrentSymbol = secondWord[index];

                    //Checking if they are not same;
                    if (firstStringCurrentSymbol != secondStringCurrentSymbol)
                    {
                        //Checking which one ASCII code is greater and giving the bool variables values;
                        if (firstStringCurrentSymbol < secondStringCurrentSymbol)
                        {
                            firstBefore = true;
                            secondBefore = false;
                            break;
                        }
                        else
                        {
                            secondBefore = true;
                            firstBefore = true;
                            break;
                        }
                    }
                    //If they are equal untill smaller string length- the first is the string with smaller length;
                    //Else if all symbols are equal;
                    else
                    {
                        //If first word length is smaller than second's word lenght;
                        if (firstWord.Length < secondWord.Length)
                        {
                            firstBefore = true;
                            secondBefore = false;
                            
                        }
                        //Or if other case;
                        else
                        {
                            secondBefore = true;
                            firstBefore = true;
                        }

                    }

                }
            }
            if (firstWord.Length == secondWord.Length)
            {


                //IF WORDS ARE WITH SAME SIZES;
                for (int index = 0; index < firstWord.Length; index++)
                {
                    //Converting our current indexes into chars;
                    char firstStringCurrentSymbol = firstWord[index];
                    char secondStringCurrentSymbol = secondWord[index];

                    //Checking if first string is before second;
                    if (firstStringCurrentSymbol < secondStringCurrentSymbol)
                    {
                        firstBefore = true;
                        secondBefore = false;
                        Equal = false;
                        break;
                    }
                    //Checking if second string is before first;
                    else if (firstStringCurrentSymbol > secondStringCurrentSymbol)
                    {
                        secondBefore = true;
                        firstBefore = false;
                        Equal = false;
                        break;
                    }
                    //Checking if both are equal
                    else if (firstStringCurrentSymbol == secondStringCurrentSymbol)
                    {
                        Equal = true;
                        firstBefore = false;
                        secondBefore = false;
                        
                    }

                }
            }
            //Printing the result;
            if (Equal==true)
            {
                Console.WriteLine("Both words are equal lexicographically");
            }
            else if (secondBefore==true)
            {
                Console.WriteLine("Second word is first lexicographically");
            }
            else if (firstBefore==true)
            {
                Console.WriteLine("First word is first lexicographically");
            }
        }
    }
}
