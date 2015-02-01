using System;
using System.Collections.Generic;
using System.Linq;


namespace BankSituantion
{
    public abstract class Account
    {
        private List<Customer> customers;
        private double balance;
        private double interestRate;
        
        public List<Customer> Customers 
        {
            get
            {
                return this.customers;
            }
            set
            {
                this.customers = value;
            }
        }

        public double Balance
        {
            get 
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount (int months)
        {
            return (decimal)(months * (this.balance / 100) * this.interestRate);
        }

        static void Main()
        {

            Deposit IvanDeposit = new Deposit();
            Console.WriteLine(IvanDeposit.CurrentMoney);
            IvanDeposit.AddDeposit(15);
            Console.WriteLine(IvanDeposit.CurrentMoney);
            IvanDeposit.Withraw(10);
            Console.WriteLine(IvanDeposit.CurrentMoney);


        }
    }
}
