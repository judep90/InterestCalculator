using InterestCalculator.Logic.Calculators;
using InterestCalculator.Tests.SetupFactories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System.Linq;
using System.Reflection;
using InterestCalculator.Models.CardHolders;
using InterestCalculator.Models.Wallets;

namespace InterestCalculator.Tests
{
    /// <summary>
    /// Test case: 2 people, 1 wallet each
    /// Person 1 wallet -> 1 Visa, 1 MasterCard, 1 Discover
    /// Person 2 wallet -> 1 Visa, 1 MasterCard
    /// </summary>
    [TestClass]
    public class TestCase3
    {
        private ICalculator _interestCalculator;
        private StandardKernel _kernel;
        private CardHolder _person1;
        private CardHolder _person2;
        private Wallet _wallet1;

        [TestInitialize]
        public void Setup()
        {
            _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
            _interestCalculator = _kernel.Get<ICalculator>();

            _person1 = CardHolderFactory.CreatePersonCardHolder();

            var person1Wallet = _person1.WithPhysicalWallet();
            person1Wallet.WithVisaCreditCard().WithBalance(100);
            person1Wallet.WithDiscoverCreditCard().WithBalance(100);
            person1Wallet.WithMasterCardCreditCard().WithBalance(100);

            _person2 = CardHolderFactory.CreatePersonCardHolder();

            var person2Wallet = _person2.WithPhysicalWallet();
            person2Wallet.WithVisaCreditCard().WithBalance(100);
            person2Wallet.WithMasterCardCreditCard().WithBalance(100);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForPerson1()
        {
            //Act
            var interest = _interestCalculator.CalculateInterest(_person1);

            //Assert
            Assert.AreEqual(16, interest);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForPerson1Wallet()
        {
            //Act
            var interest = _interestCalculator.CalculateInterest(_person1.Wallets.First());

            //Assert
            Assert.AreEqual(16, interest);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForPerson2()
        {
            //Act
            var interest = _interestCalculator.CalculateInterest(_person2);

            //Assert
            Assert.AreEqual(15, interest);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForPerson2Wallet()
        {
            //Act
            var interest = _interestCalculator.CalculateInterest(_person2.Wallets.First());

            //Assert
            Assert.AreEqual(15, interest);
        }
    }
}
