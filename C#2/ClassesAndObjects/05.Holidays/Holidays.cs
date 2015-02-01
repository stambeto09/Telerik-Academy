using System;
using System.Linq;

namespace Holidays
{
    class Holidays

    {
        public static void CalcHolidays(DateTime date, out int days, out int holidays)
        {
            DateTime dateToday = DateTime.Today;
            int currYear = DateTime.Today.Year;
            holidays = 0;
            days = 0;

            
            DateTime[] hdays =
            {
                new DateTime(currYear, 1, 1),
                new DateTime(currYear, 3, 3),
                new DateTime(currYear, 5, 1),
                new DateTime(currYear, 5, 2),
                new DateTime(currYear, 5, 6),
                new DateTime(currYear, 5, 24),
                new DateTime(currYear, 9, 22),
                new DateTime(currYear, 12, 24),
                new DateTime(currYear, 12, 25),
                new DateTime(currYear, 12, 26),
                new DateTime(currYear, 12, 31)
             };

            while (dateToday <= date)
            {
                //check if it is weekend
                if (dateToday.DayOfWeek == DayOfWeek.Saturday || dateToday.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidays++;
                }
                else
                {
                    //check for a holiday
                    foreach (var element in hdays)
                    {
                        if (element.DayOfYear == dateToday.DayOfYear)
                        {
                            holidays++;
                        }
                    }
                }
                days++;
                dateToday = dateToday.AddDays(1);
            }
        }

        static void Main()
        {

            DateTime date2;
            int days = 0;
            int holidays = 0;

            //Enter date in the future
            do
            {
                Console.Write("dd mm yyyy: ");
                date2 = DateTime.Parse(Console.ReadLine());
            } while (date2 < DateTime.Today);


            //Calculating holidays in the time interval
            CalcHolidays(date2, out days, out holidays);

            //printing results
            Console.WriteLine("{0} days in the time interval", days);
            Console.WriteLine("{0} holidays in the time interval", holidays);
            Console.WriteLine("{0} workdays in the time interval", days - holidays);
        }
    }
}