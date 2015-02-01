using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {


            Dictionary<string, string> Dictionary = new Dictionary<string, string>();

            string input = @".NET - platform for applications from Microsoft
                                CLR - managed execution environment for .NET
                                namespace - hierarchical organization of classes";

            string[] stringArray = input.Split((new char[] { '-', '\r', '\n' }), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < stringArray.Length; i = i + 2)
            {

                string firstword = stringArray[i].Trim();
                string meaning = stringArray[i + 1].Trim();
                Dictionary.Add(firstword, meaning);
            }


            string userInput = Console.ReadLine();

            Console.WriteLine("{0} ---- {1} ", userInput, Dictionary[userInput]);


        }
    }
}