using System;

namespace Strategy_Pattern
{
    public class AnotherShippingCostCalculatorService
    {
        public double CalculateShippingCost(Order order, Func<Order, double> shippingCostStrategy)
        {
            return shippingCostStrategy(order);
        }
    }
}