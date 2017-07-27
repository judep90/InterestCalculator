using System;
using InterestCalculator.Models;
using InterestCalculator.Models.CreditCards;
using InterestCalculator.Models.Wallets;
using InterestCalculator.Models.CardHolders;
using System.Linq;

namespace InterestCalculator.Logic.Calculators
{
    public class SimpleInterestCalculator : ICalculator
    {
        public decimal CalculateInterest(CreditCard creditCard)
        {
            return creditCard.Balance * (creditCard.InterestRate / 100);
        }

        public decimal CalculateInterest(Wallet wallet)
        {
            return wallet.CreditCards.Select(cc => CalculateInterest(cc)).Sum();
        }

        public decimal CalculateInterest(CardHolder cardHolder)
        {
            return cardHolder.Wallets.Select(w => CalculateInterest(w)).Sum();
        }
    }
}
