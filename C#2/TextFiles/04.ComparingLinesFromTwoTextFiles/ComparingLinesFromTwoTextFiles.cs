using System;
using System.Linq;
using System.IO;


namespace _04.ComparingLinesFromTwoTextFiles
{
    class ComparingLinesFromTwoTextFiles
    {
        static void Main()
        {
            StreamReader firstFile = new StreamReader(@"../../firstText.txt");
            StreamReader secondFilie = new StreamReader(@"../../secondText.txt");

            
            using (firstFile)
            {
                int sameLinesCounter = 0;
                int differentLinesCounter = 0;
                using (secondFilie)
                {
                    int lineNumber = 0;
                    string lineFirstFile = firstFile.ReadLine();
                    string lineSecondFile = secondFilie.ReadLine();

                    while (lineFirstFile != null)
                    {
                        lineNumber++;
                        if (lineFirstFile==lineSecondFile)
                        {
                            sameLinesCounter++;
                        }
                        else if (lineFirstFile!=lineSecondFile)
                        {
                            differentLinesCounter++;
                        }

                        lineFirstFile = firstFile.ReadLine();
                        lineSecondFile = secondFilie.ReadLine();
                    }
                }
                Console.WriteLine("The number of lines with same content is: {0}"
                    ,sameLinesCounter);
                Console.WriteLine("The number of lines with different content is: {0}"
                    , differentLinesCounter);
            }


        }
    }
}
