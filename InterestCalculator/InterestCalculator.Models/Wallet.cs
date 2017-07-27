using System.Collections.Generic;

namespace InterestCalculator.Models
{
    /// <summary>
    /// A class to represent a wallet
    /// </summary>
    public class Wallet
    {
        /// <summary>
        /// Collection of CreditCards in this Wallet
        /// </summary>
        public IEnumerable<CreditCard> CreditCards { get; set; }
    }
}