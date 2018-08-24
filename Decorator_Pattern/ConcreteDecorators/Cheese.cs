using Decorator_Pattern.Decorator;

namespace Decorator_Pattern.ConcreteDecorators
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()} ,{ Description}";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.25d;
        }
    }
}