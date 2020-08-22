using Factory_Pattern.Autos;

namespace Factory_Pattern.Factories
{
    class MarutiFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            // Here what lies power of specific factories
            // their is no parmeter constructor for BMW but other factry can have one
            return new Maruti("Alto 800");

        }


    }
}