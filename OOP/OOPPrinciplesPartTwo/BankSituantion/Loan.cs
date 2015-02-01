using System;
using System.Linq;

namespace BankSituantion
{
    public class Loan : Account , IDeposit
    {
        private decimal currentMoney;
        private decimal depositMoney;

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
                if (value<=0)
                {
                    throw new ArgumentException("Please, enter a valid value for money!");
                }

                this.depositMoney = value;
            }
        }

        public void AddDeposit(decimal money)
        {
            this.currentMoney += money;
        }

        public decimal CalculateInterestAmount(int numberOfMonth, decimal interestRate)
        {

            return numberOfMonth * interestRate;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customers.GetType().Name=="Individual")
            {
                if (months<=3)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months-2);
                }
            }

            return 0;
        }
    }
}
