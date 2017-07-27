using InterestCalculator.Models;
using InterestCalculator.Models.CreditCards;
using InterestCalculator.Models.Wallets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Tests.SetupFactories
{
    public static class WalletFactory
    {
        public static CreditCard WithVisaCreditCard(this Wallet wallet)
        {
            wallet.CreditCards.Add(new Visa());
            return wallet.CreditCards.Last();
        }

        public static CreditCard WithMasterCardCreditCard(this Wallet wallet)
        {
            wallet.CreditCards.Add(new MasterCard());
            return wallet.CreditCards.Last();
        }

        public static CreditCard WithDiscoverCreditCard(this Wallet wallet)
        {
            wallet.CreditCards.Add(new Discover());
            return wallet.CreditCards.Last();
        }
    }
}
