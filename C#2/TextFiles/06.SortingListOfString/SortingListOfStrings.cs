using System;
using System.Linq;
using System.IO;

namespace _06.SortingListOfString
{
    class SortingListOfStrings
    {
        static void Main()
        {
            StreamReader fileReader = new StreamReader(@"../../fileWithNames.txt");
            
            string fullContent = null;
            using (fileReader)
            {
                string line = fileReader.ReadLine();
                while (line!=null)
                {
                    fullContent = fullContent + line + " ";
                    line = fileReader.ReadLine();
                }
            }

            string[] arrayOfNames = fullContent.Split(' ') ;
            Array.Sort(arrayOfNames);

            StreamWriter saveContent = new StreamWriter(@"../../saveContent.txt",false);

            using (saveContent)
            {
                for (int index = 0; index < arrayOfNames.Length; index++)
                {
                    saveContent.WriteLine(arrayOfNames[index]);
                }
            }

            Console.WriteLine("Done! Check your file");

        }
    }

}
