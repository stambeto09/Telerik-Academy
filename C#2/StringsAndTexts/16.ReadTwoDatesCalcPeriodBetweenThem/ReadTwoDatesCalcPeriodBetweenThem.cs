using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDaysBetwinDates
{
    class NumberOfDaysBetwinDates
    {
        static void Main(string[] args)
        {

            string format = "dd.MM.yyyy";

            Console.WriteLine("Enter date in format - dd.MM.yyyy");
            string DateOne = Console.ReadLine();
            DateTime dateOne = DateTime.ParseExact(DateOne, format, CultureInfo.InvariantCulture);

            string DateTwo = Console.ReadLine();
            DateTime dateTwo = DateTime.ParseExact(DateTwo, format, CultureInfo.InvariantCulture);

            //DateTime result = (dateTwo - dateOne).TotalDays;

            Console.WriteLine((dateTwo - dateOne).TotalDays);




        }
    }
}