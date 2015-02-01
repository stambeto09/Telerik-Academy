using System;

    class ReversingWordInString
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi !";
            string[] words = text.Split(' ');

            Array.Reverse(words);

            for (int index = 1; index < words.Length; index++)
            {
                Console.Write(words[index]+ " ");
            }
            
        }
    }

