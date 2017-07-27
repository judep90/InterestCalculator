using InterestCalculator.Models.Wallets;
using System.Collections.Generic;

namespace InterestCalculator.Models.CardHolders
{
    /// <summary>
    /// An abstraction to represent an entity that can have wallets
    /// Eg: Person, Family, Business
    /// </summary>
    public abstract class CardHolder
    {
        /// <summary>
        /// A collection of wallets owned by this CardHolder
        /// </summary>
        public IList<Wallet> Wallets { get; set; } = new List<Wallet>();
    }
}
