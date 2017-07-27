using InterestCalculator.Logic.Calculators;
using Ninject.Modules;

namespace InterestCalculator.Tests
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ICalculator>().To<SimpleInterestCalculator>();
        }
    }
}
