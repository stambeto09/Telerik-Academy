using System;

class SearchingSubstringInString
{
    static int CalculateSubstringInString(string text,string substringParam)
    {
        int counterOfSubstring=0;
        int index=text.IndexOf(substringParam);

        while (index!=-1)
        {
            index = text.IndexOf(substringParam, index + 1);
            counterOfSubstring++;
        }
        return counterOfSubstring;
    }
    static void Main()
    {
        //return -1 if there is no such a string anymore 

        Console.Write("Now, it's time to write down your string: ");
        string stringInText = Console.ReadLine();
        Console.Write("Now enter your substring you want to search: ");
        string substring= Console.ReadLine();

        int numberOfSubstrings = CalculateSubstringInString(stringInText,substring);
        Console.WriteLine("Your number of substrings in the current string is equal to {0}",numberOfSubstrings);
    }
}