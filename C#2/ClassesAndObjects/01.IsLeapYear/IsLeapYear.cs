using System;
using System.Linq;


namespace _01.IsLeapYear
{
    class IsLeapYear
    {
        static void Main()
        {
            Console.Write("Enter your year: ");
            int date = int.Parse(Console.ReadLine());
            bool leapYear = DateTime.IsLeapYear(date);

            Console.WriteLine("Is your year leap; {0}", leapYear);
            
        }
    }
}
