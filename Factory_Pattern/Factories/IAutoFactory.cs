using Factory_Pattern.Autos;

namespace Factory_Pattern.Factories
{
    internal interface IAutoFactory
    {
        IAuto CreateAutomobile();
    }
}