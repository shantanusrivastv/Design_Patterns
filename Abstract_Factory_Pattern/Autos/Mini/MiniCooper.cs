namespace Abstract_Factory_Pattern.Autos.Mini
{
    using System;

    public class MiniCooper : IAutomobile
    {
        string name;

        public MiniCooper()
        {
            this.name = "Mini Cooper";
        }

        public void AddSportPackage()
        {
            this.name += " S";
        }

        public void AddLuxuryPackage()
        {
            this.name += " with leather upholstery";
        }

        public void TurnOn()
        {
            Console.WriteLine("The " + this.name + " is on! 1.6 Liters of brutal force is churning.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The Mini Cooper is has turned off.");
        }
    }
}