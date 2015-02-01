using System;
using System.Linq;

namespace BankSituantion
{
    interface IInterest
    {
        decimal CalculateInterestAmount(int numberOfMonth);
    }
}
