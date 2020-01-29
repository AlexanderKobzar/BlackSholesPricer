using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Distributions.Univariate;

namespace BlackSholesPricer
{
    /// <remarks>
    /// This class uses the Accord library in order to get the cumulative distribution function
    /// </remarks>

    public class BlackScholesModel : IBlackScholesModel
    {
        public BlackSholesParams modelParams { get; private set; }
        private readonly NormalDistribution normalDistribution = new NormalDistribution(mean: 0, stdDev: 1);
        public double PriceCallOption()
        {
            return modelParams.S * normalDistribution.DistributionFunction(D1) - modelParams.K * Math.Exp(-modelParams.r * modelParams.t) * normalDistribution.DistributionFunction(D2);
        }

        public double PricePutOption()
        {
            return modelParams.K * Math.Exp(-modelParams.r * modelParams.t) * normalDistribution.DistributionFunction(-D2) - modelParams.S * normalDistribution.DistributionFunction(-D1);
        }

        public void SetParams(BlackSholesParams modelParams)
        {
            this.modelParams = modelParams;
        }


        /// <remarks>
        /// This code is compiler-generated
        /// </remarks>
        public override bool Equals(object obj)
        {
            return obj is BlackScholesModel model &&
                   EqualityComparer<BlackSholesParams>.Default.Equals(modelParams, model.modelParams) &&
                   EqualityComparer<NormalDistribution>.Default.Equals(normalDistribution, model.normalDistribution) &&
                   D1 == model.D1 &&
                   D2 == model.D2;
        }

        /// <remarks>
        /// This code is compiler-generated
        /// </remarks>
        public override int GetHashCode()
        {
            var hashCode = 1754521385;
            hashCode = hashCode * -1521134295 + modelParams.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<NormalDistribution>.Default.GetHashCode(normalDistribution);
            hashCode = hashCode * -1521134295 + D1.GetHashCode();
            hashCode = hashCode * -1521134295 + D2.GetHashCode();
            return hashCode;
        }

        double D1 => (Math.Log(modelParams.S / modelParams.K) + (modelParams.r + Math.Pow(modelParams.sigma, 2) / 2) * modelParams.t) / (modelParams.sigma * Math.Sqrt(modelParams.t));
        double D2 => D1 - modelParams.sigma * Math.Sqrt(modelParams.t);
    }

}
