using System;
using System.Linq;

namespace _05.HexadecimalToBinaryConverter
{
    class Converter
    {
        //Write a program to convert hexadecimal numbers to binary numbers (directly).
        static void Main()
        {
            Console.Write("Enter your hexadecimal number here: ");
            string hexadecimalString = Console.ReadLine();
            string result = AddBinDigits(hexadecimalString);
            Console.WriteLine("Your number in binary representation is equal to : {0}. ", result);
        }

        static string AddBinDigits(string h)
        {
            string res = "";
            for (int i = 0; i < h.Length; i++)
            {
                switch (h.Substring(i, 1))
                {
                    case "0":
                        res += "0000";
                        break;
                    case "1":
                        res += "0001";
                        break;
                    case "2":
                        res += "0010";
                        break;
                    case "3":
                        res += "0011";
                        break;
                    case "4":
                        res += "0100";
                        break;
                    case "5":
                        res += "0101";
                        break;
                    case "6":
                        res += "0110";
                        break;
                    case "7":
                        res += "0111";
                        break;
                    case "8":
                        res += "1000";
                        break;
                    case "9":
                        res += "1001";
                        break;
                    case "A":
                        res += "1010";
                        break;
                    case "B":
                        res += "1011";
                        break;
                    case "C":
                        res += "1100";
                        break;
                    case "D":
                        res += "1101";
                        break;
                    case "E":
                        res += "1110";
                        break;
                    case "F":
                        res += "1111";
                        break;
                    default:
                        res += "";
                        break;
                }
            }
            return res;
        }
    }
}