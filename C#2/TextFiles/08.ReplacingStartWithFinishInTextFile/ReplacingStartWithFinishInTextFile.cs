using System;
using System.Linq;
using System.IO;

namespace _08.ReplacingStartWithFinishInTextFile
{
    class ReplacingStartWithFinishInTextFile
    {
        static void Main()
        {
            StreamReader textReader = new StreamReader(@"../../textFile.txt");
            string fullContent = textReader.ReadToEnd();
            
            StreamWriter textWriter = new StreamWriter(@"../../resultText.txt");

            using (textReader)
            {
                string line = textReader.ReadLine();
                string fixedContent = fullContent.Replace(" start ", " finish ");
                textWriter.WriteLine(fixedContent);
                using (textWriter)
                {


                    while (line != null)
                    {
                        line = Console.ReadLine();
                        fixedContent = fullContent.Replace(" start ", " finish ");
                        textWriter.WriteLine(fixedContent);
                    }
                }
            }


            Console.WriteLine("Done! Check your solution in the resultText.txt");
           
        }
    }
}
