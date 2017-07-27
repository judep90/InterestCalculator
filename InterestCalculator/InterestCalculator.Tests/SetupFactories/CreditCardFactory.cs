using InterestCalculator.Models;
using InterestCalculator.Models.CreditCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Tests.SetupFactories
{
    public static class CreditCardFactory
    {
        public static decimal WithBalance(this CreditCard creditCard, decimal balance)
        {
            creditCard.Balance = balance;
            return creditCard.Balance;
        }
    }
}
