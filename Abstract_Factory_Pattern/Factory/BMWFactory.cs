namespace Abstract_Factory_Pattern.Factory
{
    using Autos;
    using Autos.BMW;

    class BMWFactory : IAutoFactory
    {
        public IAutomobile CreateSportsCar()
        {
            return new BMWM3();
        }

        public IAutomobile CreateLuxuryCar()
        {
            return new BMW740i();
        }

        public IAutomobile CreateEconomyCar()
        {
            return new BMW328i();
        }
    }
}