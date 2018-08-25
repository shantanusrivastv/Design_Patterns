using Decorator_Pattern.ConcreteDecorators;
using System;

namespace Decorator_Pattern
{
    using Component;
    using ConcreteComponents;
    using Decorator;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Peppers(largePizza);

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine(largePizza.CalculateCost().ToString("C"));
            Console.ReadKey();
        }
    }
}