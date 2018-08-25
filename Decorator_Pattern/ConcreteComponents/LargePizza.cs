namespace Decorator_Pattern.ConcreteComponents
{
    using Component;

    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            this.Description = "Large Pizza";
        }
        public override string GetDescription()
        {
            return this.Description;
        }

        public override double CalculateCost()
        {
            return 10d;
        }
    }
}