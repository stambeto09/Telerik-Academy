using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVariables
{
    class StringVariables
    {
        static void Main()
        {
            string firstString = "The  \"use\" of quatations causes difficulties.";
            string secondString = @"The ""use"" of quatations causes difficulties.";
            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
        }
    }
}
