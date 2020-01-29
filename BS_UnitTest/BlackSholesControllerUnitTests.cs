using System;
using BlackSholesPricer;
using Moq;
using NUnit.Framework;

namespace BlackSholesPricerUnitTest
{
    [TestFixture]
    public class BlackSholesViewAndControllerUnitTests
    {
        Mock<IBlackSholesView> viewMock = new Mock<IBlackSholesView>();
        Mock<IBlackScholesModel> modelMock = new Mock<IBlackScholesModel>();
        
        [SetUp]
        public void Init()
        {
            viewMock.Setup(m => m.GetParams()).Returns(It.IsAny<BlackSholesParams>()).Verifiable();
            viewMock.Setup(m => m.ShowResults(It.IsAny<double>(), It.IsAny<double>())).Verifiable();
            modelMock.Setup(m => m.SetParams(It.IsAny<BlackSholesParams>())).Verifiable();
            modelMock.Setup(m => m.PriceCallOption()).Returns(It.IsAny<double>()).Verifiable();
            modelMock.Setup(m => m.PricePutOption()).Returns(It.IsAny<double>()).Verifiable();
        }

        [Test]
        public void PriceShouldCalculateThePriceAndShowResult()
        {
            IBlackSholesController controller = new BlackSholesController(modelMock.Object, viewMock.Object);
            controller.Price();
            viewMock.Verify();
            modelMock.Verify();
        }
    }
}
