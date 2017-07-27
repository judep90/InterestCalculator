using InterestCalculator.Models.CreditCards;
using System.Collections.Generic;

namespace InterestCalculator.Models.Wallets
{
    /// <summary>
    /// An abstraction to represent a wallet
    /// Eg: Physical wallet, digital wallet
    /// </summary>
    public abstract class Wallet
    {
        /// <summary>
        /// Collection of CreditCards in this Wallet
        /// </summary>
        public IList<CreditCard> CreditCards { get; set; } = new List<CreditCard>();
    }
}