using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSholesPricer
{
    public struct BlackSholesParams
    {
        public BlackSholesParams(double s, double k, double t, double sigma, double r)
        {
            S = s;
            K = k;
            this.t = t;
            this.sigma = sigma;
            this.r = r;
        }

        public double S { get; set; }
        public double K { get; set; }
        public double t { get; set; }
        public double sigma { get; set; }
        public double r { get; set; }
    }
}
