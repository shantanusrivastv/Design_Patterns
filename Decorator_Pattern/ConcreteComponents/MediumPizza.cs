using System;

namespace Decorator_Pattern.ConcreteComponents
{
    using Component;

    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            Description = "Medium Pizza";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 6.00;
        }

       
    }
}