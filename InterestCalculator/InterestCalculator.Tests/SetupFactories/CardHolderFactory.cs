using InterestCalculator.Models.CardHolders;
using InterestCalculator.Models.CreditCards;
using InterestCalculator.Models.Wallets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Tests.SetupFactories
{
    public static class CardHolderFactory
    {
        public static CardHolder CreatePersonCardHolder()
        {
            return new Person();
        }

        public static Wallet WithPhysicalWallet(this CardHolder cardHolder)
        {
            cardHolder.Wallets.Add(new PhysicalWallet());
            return cardHolder.Wallets.Last();
        }
    }
}
