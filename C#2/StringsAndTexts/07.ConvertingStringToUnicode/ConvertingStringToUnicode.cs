using System;

    class ConvertingStringToUnicode
    {
        static void Main()
        {
            char c = 'a';
            ushort someVariable = Convert.ToUInt16(c);
            Console.WriteLine(someVariable);
            
        }
    }

