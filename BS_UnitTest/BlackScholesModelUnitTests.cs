using System;
using BlackSholesPricer;
using NUnit.Framework;

namespace BlackSholesPricerUnitTest
{
    [TestFixture]
    public class BlackScholesModelUnitTests
    {
        [Test]
        public void SetParamsShouldInitializeModelParameters()
        {
            BlackScholesModel model = new BlackScholesModel();
            var modelParams = new BlackSholesParams(50, 55, 1, 0.2, 0.09);
            model.SetParams(modelParams);
            Assert.IsTrue(model.modelParams.Equals (modelParams));
        }

        [Test]
        public void TestPriceCallOption()
        {
            const double exprectedPrice = 3.8617;
            IBlackScholesModel model = new BlackScholesModel();
            var modelParams = new BlackSholesParams(50, 55, 1, 0.2, 0.09);
            model.SetParams(modelParams);
            var result = Math.Round(model.PriceCallOption(), 4, MidpointRounding.AwayFromZero);
            Assert.Zero(exprectedPrice.CompareTo(result));
        }

        [Test]
        public void TestPricePutOption()
        {
            const double exprectedPrice = 4.1279;
            IBlackScholesModel model = new BlackScholesModel();
            var modelParams = new BlackSholesParams(50, 55, 1, 0.2, 0.09);
            model.SetParams(modelParams);
            var result = Math.Round(model.PricePutOption(), 4, MidpointRounding.AwayFromZero);
            Assert.Zero(exprectedPrice.CompareTo(result));
        }
    }
}
