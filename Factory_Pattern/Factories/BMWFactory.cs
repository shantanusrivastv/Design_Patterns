namespace Factory_Pattern
{
    using Autos;

    class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {

            return new BMW();
        }
    }
}