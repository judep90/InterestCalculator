using InterestCalculator.Logic.Calculators;
using InterestCalculator.Models.CardHolders;
using InterestCalculator.Models.Wallets;
using InterestCalculator.Tests.SetupFactories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System.Reflection;

namespace InterestCalculator.Tests
{
    /// <summary>
    /// Test Case: 1 person, 2 wallets, wallet 1 -> Visa + Discover, wallet 2 -> MasterCard
    /// </summary>
    [TestClass]
    public class TestCase2
    {
        private ICalculator _interestCalculator;
        private StandardKernel _kernel;
        private CardHolder _person;
        private Wallet _wallet1;
        private Wallet _wallet2;

        [TestInitialize]
        public void Setup()
        {
            _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
            _interestCalculator = _kernel.Get<ICalculator>();

            _person = CardHolderFactory.CreatePersonCardHolder();

            _wallet1 = _person.WithPhysicalWallet();
            _wallet1.WithVisaCreditCard().WithBalance(100);
            _wallet1.WithDiscoverCreditCard().WithBalance(100);

            _wallet2 = _person.WithPhysicalWallet();
            _wallet2.WithMasterCardCreditCard().WithBalance(100);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForWallet1()
        {
            //Act
            var interest = _interestCalculator.CalculateInterest(_wallet1);

            //Assert
            Assert.AreEqual(11, interest);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForWallet2()
        {
            //Act
            var interest = _interestCalculator.CalculateInterest(_wallet2);

            //Assert
            Assert.AreEqual(5, interest);
        }

        [TestMethod]
        public void ItCalculatesSimpleInterestForPerson()
        {
            //Act
            var interest = _interestCalculator.CalculateInterest(_person);

            //Assert
            Assert.AreEqual(16, interest);
        }
    }
}
