using System;
using System.Linq;

namespace BankSituantion
{
    public class Mortage : Account , IDeposit , IInterest
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
                if (value <= 0)
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

       public override decimal CalculateInterestAmount(int months)
        {
            if (base.Customers.GetType().Name=="Companies")
            {
                if (months<=12)
                {
                    CalculateInterestAmount(months/2);
                }
                else
                {
                    return CalculateInterestAmount(months / 2);
                }
            }
            else if (base.Customers.GetType().Name == "Individual")
            {
                if (months<=6)
                {
                    return 0;
                }
                else
                {
                    return CalculateInterestAmount(months / 2);
                }
            }
            return 0;
        }
    }
}
