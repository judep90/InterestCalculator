using InterestCalculator.Models;
using InterestCalculator.Models.CardHolders;
using InterestCalculator.Models.CreditCards;
using InterestCalculator.Models.Wallets;

namespace InterestCalculator.Logic.Calculators
{
    /// <summary>
    /// Interface defining the contract for interest rate calculators
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Calculate the total interest for a CardHolder
        /// </summary>
        /// <param name="cardHolder"></param>
        /// <returns></returns>
        decimal CalculateInterest(CardHolder cardHolder);

        /// <summary>
        /// Calculate the total interest for a Wallet
        /// </summary>
        /// <param name="wallet"></param>
        /// <returns></returns>
        decimal CalculateInterest(Wallet wallet);
        /// <summary>
        /// Calculate the interest for a CreditCard
        /// </summary>
        /// <param name="creditCard"></param>
        /// <returns></returns>
        decimal CalculateInterest(CreditCard creditCard);
    }
}
