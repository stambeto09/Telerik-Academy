using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.BinaryToHexadecimalConverter
{
    class BinaryToHexadecimaConverter
    {
        static void Main()
        {
            Console.Write("Enter binary  number:\nbinary--> ");
            string binaryNum = Console.ReadLine();

            List<string> hexResult = new List<string>();
            StringBuilder fourBits = new StringBuilder();
            int index = 0;
            int setFourBits = 0;

            if (binaryNum.Length < 4)
            {

                binaryNum = binaryNum.PadLeft(4, '0');

            }


            else if ((binaryNum.Length - 4) < 4) 
            {

                int mising = (binaryNum.Length) + (4 - (binaryNum.Length - 4));
                binaryNum = binaryNum.PadLeft(mising, '0');

            }


            while (binaryNum.Length > index)
            {

                fourBits.Append(binaryNum[index]);
                setFourBits++;
                if (setFourBits == 4)
                {
                    string hexNum = fourBits.ToString();
                    setFourBits = 0;
                    switch (hexNum)
                    {
                        case "0000": hexResult.Add("0");
                            break;
                        case "0001": hexResult.Add("1");
                            break;
                        case "0010": hexResult.Add("2");
                            break;
                        case "0011": hexResult.Add("3");
                            break;
                        case "0100": hexResult.Add("4");
                            break;
                        case "0101": hexResult.Add("5");
                            break;
                        case "0110": hexResult.Add("6");
                            break;
                        case "0111": hexResult.Add("7");
                            break;
                        case "1000": hexResult.Add("8");
                            break;
                        case "1001": hexResult.Add("9");
                            break;
                        case "1010": hexResult.Add("A");
                            break;
                        case "1011": hexResult.Add("B");
                            break;
                        case "1100": hexResult.Add("C");
                            break;
                        case "1101": hexResult.Add("D");
                            break;
                        case "1110": hexResult.Add("E");
                            break;
                        case "1111": hexResult.Add("F");
                            break;
                        default: Console.WriteLine("Error !");
                            break;
                    }
                    fourBits.Clear();
                }
                index++;
            }


            Console.Write("Hex ----> ");
            for (int i = 0; i < hexResult.Count; i++)
            {
                Console.Write(hexResult[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
