using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenatingTwoStrings
{
    class ConcatenatingTwoStrings
    {
        static void Main()
        {
            string firstString = "Hello ";
            string secondString = "World";
            object stringConcat = firstString + secondString;
            string thirdString = (string)stringConcat;
            
        }
    }
}
