using System;
using System.Linq;
using System.IO;

namespace _01.TextFileReader
{
    class TextFileReader
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("TextFileForReading.txt",false);

            using (reader)
            {
                string line = reader.ReadLine();
                int lineNumber = 0;
                while (line!=null)
                {
                    lineNumber++;
                    if (lineNumber%2!=0)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);    
                    }

                    line = reader.ReadLine();
                        
                }
                
            }
        }
    }
}
