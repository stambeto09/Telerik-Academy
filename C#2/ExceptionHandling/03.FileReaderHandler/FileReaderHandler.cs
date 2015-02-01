using System;
using System.IO;
class FileReaderHandler
{
    static void Main()
    {
        Console.Write("Enter your path file: ");
        string pathFile = Console.ReadLine();
        try
        {
            StreamReader fileReader = new StreamReader(pathFile);
            string line = fileReader.ReadLine();
            using (fileReader)
            {
                while (line!=null)
                {
                    Console.WriteLine(line);
                    line = fileReader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("File not found");
        }
        catch(DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Wrong directory. Please try again.");
        }
        catch(IOException)
        {
            Console.Error.WriteLine("System IO Exception.");
        }
        finally
        {
            Console.WriteLine("Done!");
        }
    }
}
