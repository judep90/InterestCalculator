using InterestCalculator.Logic.Calculators;
using InterestCalculator.Models;
using InterestCalculator.Models.CardHolders;
using InterestCalculator.Models.CreditCards;
using InterestCalculator.Tests.SetupFactories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace InterestCalculator.Tests
{
    /// <summary>
    /// Test case: 1 person, 1 wallet, 3 cards (1 visa, 1 MC, 1 Discover)
    /// </summary>
    [TestClass]
    public class TestCase1
    {
        private StandardKernel _kernel;
        private ICalculator _interestCalculator;
        private CardHolder _person;

        [TestInitialize]
        public void Setup()
        {
            _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
            _interestCalculator = _kernel.Get<ICalculator>();

            _person = CardHolderFactory.CreatePersonCardHolder();
            var wallet = _person.WithPhysicalWallet();
            wallet.WithVisaCreditCard().WithBalance(100);
            wallet.WithDiscoverCreditCard().WithBalance(100);
            wallet.WithMasterCardCreditCard().WithBalance(100);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForVisa()
        {
            //Arrange
            var visa = _person.Wallets.First().CreditCards.First(cc => cc is Visa);

            //Act
            var interest = _interestCalculator.CalculateInterest(visa);

            //Assert
            Assert.AreEqual(10, interest);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForMasterCard()
        {
            //Arrange
            var visa = _person.Wallets.First().CreditCards.First(cc => cc is MasterCard);

            //Act
            var interest = _interestCalculator.CalculateInterest(visa);

            //Assert
            Assert.AreEqual(5, interest);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForDiscover()
        {
            //Arrange
            var visa = _person.Wallets.First().CreditCards.First(cc => cc is Discover);

            //Act
            var interest = _interestCalculator.CalculateInterest(visa);

            //Assert
            Assert.AreEqual(1, interest);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForPerson()
        {
            //Act
            var totalInterest = _interestCalculator.CalculateInterest(_person);

            //Assert
            Assert.AreEqual(16, totalInterest);
        }
    }
}
