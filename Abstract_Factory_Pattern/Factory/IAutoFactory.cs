namespace Abstract_Factory_Pattern.Factory
{
    using Autos;

    internal interface IAutoFactory
    {
        IAutomobile CreateSportsCar();
        IAutomobile CreateLuxuryCar();
        IAutomobile CreateEconomyCar();
    }
}