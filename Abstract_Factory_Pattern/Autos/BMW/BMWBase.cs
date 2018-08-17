namespace Abstract_Factory_Pattern.Autos.BMW
{
    using System;

    public abstract class BMWBase : IAutomobile
    {
        public abstract string Name { get; }

        public void TurnOn()
        {
            Console.WriteLine("The " + this.Name + " is on and running.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The " + this.Name + " is off.");
        }

    }
}