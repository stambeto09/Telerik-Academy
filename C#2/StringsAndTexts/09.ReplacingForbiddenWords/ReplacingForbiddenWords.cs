using System;
using System.Text.RegularExpressions;
    class ReplacingForbiddenWords
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string microsoftReplacedText=Regex.Replace(text,"Microsoft","*******");
            string CLRText = Regex.Replace(microsoftReplacedText, "CLR", "***");
            string PHPText = Regex.Replace(CLRText, "PHP", "***");
            Console.WriteLine(PHPText);

        }
    }

