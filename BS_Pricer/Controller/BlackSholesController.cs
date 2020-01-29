using System;

namespace BlackSholesPricer
{
    public class BlackSholesController : IBlackSholesController
    {
        private readonly IBlackScholesModel model;
        private readonly IBlackSholesView view;

        public BlackSholesController(IBlackScholesModel model, IBlackSholesView view)
        {
            this.model = model;
            this.view = view;
        }
        public void Price()
        {
            model.SetParams(view.GetParams());
            view.ShowResults(model.PriceCallOption(), model.PricePutOption());
        }
    }
}
