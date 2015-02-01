using System;
using System.Linq;

namespace _01.NameMethod
{
    //Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method;

    public class NameMethod
    {   
        //PrintName method
        public static string PrintName(string yourName)
        {
            return yourName;
        }

        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine(PrintName(name));
        }
    }
}
