using Factory_Pattern.Autos;

namespace Factory_Pattern.Factories
{
    class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {

            return new BMW();
        }
    }
}