using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Strategies
{
    public class BlueDartShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            return 5.00d;
        }
    }
}
