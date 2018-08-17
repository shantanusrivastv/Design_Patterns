namespace Factory_Pattern
{
    using Autos;

    internal interface IAutoFactory
    {
        IAuto CreateAutomobile();
    }
}