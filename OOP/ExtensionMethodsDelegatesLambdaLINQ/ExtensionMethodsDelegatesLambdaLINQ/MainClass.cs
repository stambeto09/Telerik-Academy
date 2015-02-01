using System;
using System.Linq;

namespace ExtensionMethods
{
    class MainClass
    {
        static void Main()
        {
            string[] arrayOfString = new[]
            {
                "a","abc","abcd","abcde","abcdef"
            };

            var stringWithMaximalLength = arrayOfString.Aggregate((max, current) => max.Length > current.Length ? max : current);

            Console.WriteLine(stringWithMaximalLength);
        }
    }
}
