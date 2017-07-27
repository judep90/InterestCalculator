namespace InterestCalculator.Models.CreditCards
{
    /// <summary>
    /// An abstraction to represent a credit card
    /// Eg: Visa, MasterCard, Discover, Amex
    /// </summary>
    public abstract class CreditCard
    {
        /// <summary>
        /// Interest rate for this CreditCard
        /// </summary>
        public decimal InterestRate { get; protected set; }

        /// <summary>
        /// Balance on this CreditCard
        /// </summary>
        public decimal Balance { get; set; }
    }
}