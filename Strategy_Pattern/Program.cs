using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    using Strategies;

    class Program
    {
        static void Main(string[] args)
        {
            #region Simple Approach
            UpsShipping();
            FedxXShipping();
            BlueDartShipping(); 
            #endregion

            // Different Approach
            //CreateStrategies
            //Using different ways 
            Func<Order, double> fedExStrategy = CalcForFedEx;
            Func<Order, double> blueDartStrategy = delegate (Order order) { return 4.00d; };
            Func<Order, double> upsStrategy = (order) => (5.5d);

            // Instead of Constructor DI we can use Method DI
            var anotherShippingCalculator = new AnotherShippingCostCalculatorService();
            var genericOrder = Helper.CreateGenericOrder();
            // We can also reuse AnotherShippingCostCalculatorService instance isntead of creating 
            // new one for each strategy
            anotherShippingCalculator.CalculateShippingCost(genericOrder,upsStrategy);
            anotherShippingCalculator.CalculateShippingCost(genericOrder,fedExStrategy);
            anotherShippingCalculator.CalculateShippingCost(genericOrder, blueDartStrategy);


        }

        private static void UpsShipping()
        {
            var upsStrategy = new UPSShippingCostStrategy();
            var shippingCalucaltor = new ShippingCostCalculatorService(upsStrategy);
            var order = Helper.CreateOrder_UPS();
            shippingCalucaltor.CalculateShippingCost(order);
        }

        private static void FedxXShipping()
        {
            //Same as above
        }
        private static void BlueDartShipping()
        {   
            //Same as above
        }

        private static double CalcForFedEx(Order order)
        {
            return 2.2D;
        }

    }
}
