using System;
using InterestCalculator.Models;

namespace InterestCalculator.Logic
{
    public class SimpleInterestCalculator : ICalculator
    {
        public decimal CalculateInterest(CreditCard creditCard)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateInterest(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateInterest(CardHolder cardHolder)
        {
            throw new NotImplementedException();
        }
    }
}
