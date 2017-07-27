using InterestCalculator.Models;
using InterestCalculator.Models.CardHolders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System.Collections.Generic;
using System.Reflection;

namespace InterestCalculator.Tests
{
    /// <summary>
    /// Test case: 1 person, 1 wallet, 3 cards
    /// </summary>
    [TestClass]
    public class TestCase1
    {
        private StandardKernel _kernel;
        private Person _person;

        [TestInitialize]
        public void Setup()
        {
            _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
        }
    }
}
