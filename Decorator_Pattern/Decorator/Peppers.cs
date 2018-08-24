using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator
{
    public class Peppers :PizzaDecorator
    {
        public Peppers(Pizza pizza) :base(pizza)
        {
            Description = "Peppers";
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()} , {this.Description}";

        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 2.25d;
        }
    }
}
