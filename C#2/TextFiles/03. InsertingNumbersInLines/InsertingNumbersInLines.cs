using System;
using System.Linq;
using System.IO;

namespace _03.InsertingNumbersInLines
{
    class InsertingNumbersInLines
    {
        static void Main()
        {
            StreamReader fileReader = new StreamReader(@"..\..\textForReading.txt");
            StreamWriter newFile = new StreamWriter(@"..\..\newFile.txt");

            using (fileReader)
            {
                int lineNumber = 0;
                string line = fileReader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    newFile.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = fileReader.ReadLine();
                }
            }
        }
    }
}
