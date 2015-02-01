using System;
using System.Text;
class ReversingString
{
    static void Main()
    {
        Console.Write("Enter your string over here: ");
        string word = Console.ReadLine();
        char[] wordInArray = word.ToCharArray();
        Array.Reverse(wordInArray);

        for (int index = 0; index < wordInArray.Length; index++)
        {
            Console.Write(wordInArray[index]);
        }
        Console.WriteLine();
        
    }
}
