namespace Decorator_Pattern
{
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