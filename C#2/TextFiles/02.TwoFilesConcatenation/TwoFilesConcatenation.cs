using System;
using System.Linq;
using System.Text;
using System.IO;


namespace _02.TwoFilesConcatenation
{
    class TwoFilesConcatenation
    {
        static void Main()
        {
            StreamReader firstReader = new StreamReader(@"..\..\firstText.txt");
            StreamReader secondReader = new StreamReader(@"..\..\secondText.txt");


            StreamWriter newFile = new StreamWriter(@"..\..\concatenatedText.txt",false,Encoding.GetEncoding("windows-1251"));
            using (newFile)
            {
                string firstFileContent = firstReader.ReadToEnd();
                Console.Write(firstFileContent+" ");
            }
            using (secondReader)
            {
                string secondFileContent = secondReader.ReadToEnd();
                Console.WriteLine(secondFileContent);
            }
        }
    }
}
