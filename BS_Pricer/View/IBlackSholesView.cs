using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSholesPricer
{
    public interface IBlackSholesView
    {
        BlackSholesParams GetParams();
        void ShowResults(double c, double d);
    }
}
