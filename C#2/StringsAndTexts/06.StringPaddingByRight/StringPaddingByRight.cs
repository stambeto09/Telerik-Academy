using System;
using System.Diagnostics;
    class StringPaddingByRight
    {
        static void Main()
        {
        
            Console.Write("Enter your string: ");
            string text = Console.ReadLine();
            
            if (text.Length<20)
            {
                Console.WriteLine(text.PadRight(20, '*'));
            }
            else if(text.Length==20)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Enter a string with length lower or equal to 20.");
            }

        }
    }

