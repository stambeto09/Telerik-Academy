using System;
using System.Linq;

namespace HumanSituation
{
    public class Worker:Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        
        public decimal WeekSalary 
        { 
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("The week salary can not be negative number!");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Please enter a valid number for hours");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public Worker()
        {
        }

        public Worker(string firstName, string lastName, decimal weekSalary):base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
        }

        public Worker(string firstName,string lastName, decimal weekSalary, int workHoursPerDay):base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
     
        public decimal MoneyPerDay(int hours)
        {
            return hours * 10;
        }



    }
}
