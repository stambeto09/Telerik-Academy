using System;

    class ConvertingStringToUnicode
    {
        static void Main()
        {
            Console.Write("Enter your string");
            string text = Console.ReadLine();
            for (int index = 0; index < text.Length; index++)
            {
                char symbol = text[index];
                int symbolUnicode = (int)symbol;
                string hexValue = symbolUnicode.ToString("X");
                Console.Write("\\u00{0}", hexValue);
            }

            Console.WriteLine();
        }
    }

