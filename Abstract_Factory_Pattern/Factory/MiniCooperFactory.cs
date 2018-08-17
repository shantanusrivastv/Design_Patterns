namespace Abstract_Factory_Pattern.Factory
{
    using Autos;
    using Autos.Mini;

    class MiniCooperFactory : IAutoFactory
    {

        // Very different implmentataion than that of BMWFactory

        public IAutomobile CreateSportsCar()
        {
            var mini = new MiniCooper();

            mini.AddSportPackage();

            return mini;
        }

        public IAutomobile CreateLuxuryCar()
        {
            var mini = new MiniCooper();

            mini.AddLuxuryPackage();

            return mini;
        }

        public IAutomobile CreateEconomyCar()
        {
            return new MiniCooper();
        }
    }
}