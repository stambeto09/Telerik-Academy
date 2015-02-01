using System;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string inputFile = @"..\..\fileText.txt";
        string tempFile = Path.GetTempFileName();

        try
        {
            StreamReader reader = new StreamReader(inputFile);
            using (reader)
            {
                using (var writer = new StreamWriter(tempFile))
                {
                    int lineNumber = 1;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (lineNumber % 2 == 0)
                            writer.WriteLine(line);
                        lineNumber++;
                    }
                }
            }
            File.Delete(inputFile);
            File.Move(tempFile, inputFile);
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Invalid directory in the file path.");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }
}