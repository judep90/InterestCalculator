using System;
using InterestCalculator.Models;
using InterestCalculator.Models.CreditCards;
using InterestCalculator.Models.Wallets;
using InterestCalculator.Models.CardHolders;

namespace InterestCalculator.Logic.Calculators
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
