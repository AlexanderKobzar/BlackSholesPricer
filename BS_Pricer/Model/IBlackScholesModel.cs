namespace BlackSholesPricer
{
    public interface IBlackScholesModel
    {
         void SetParams(BlackSholesParams modelParams);
         double PriceCallOption();
         double PricePutOption();
    }
}