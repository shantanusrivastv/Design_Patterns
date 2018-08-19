using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}
