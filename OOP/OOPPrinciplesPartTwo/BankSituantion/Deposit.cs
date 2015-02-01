using System;
using System.Linq;

namespace BankSituantion
{
    public class Deposit : Account , IWithraw , IDeposit , IInterest
    {
        private decimal currentMoney;
        private decimal depositMoney;
        private decimal withrawMoney;

        public decimal CurrentMoney 
        {
            get
            {
                return this.currentMoney;
            }
        }

        public decimal DepositMoney
        {
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("The deposit money's can not be negative number!");
                }
                this.depositMoney = value;
            }
        }

        public decimal WithrawMoney
        {
           set
           {
               if (value<0)
               {
                   throw new ArgumentException("The deposit money's can not be negative number!");
               }
               this.withrawMoney = value;
           }
        }

        public void AddDeposit(decimal money)
        {
            this.currentMoney += money;
        }

        public void Withraw(decimal money)
        {
            this.currentMoney -= money;
        }

        public decimal CalculateInterestAmount(int numberOfMonth, decimal interestRate)
        {
            return numberOfMonth * interestRate;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (base.Balance>0 && base.Balance<1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount(months);
        }

    }
}
