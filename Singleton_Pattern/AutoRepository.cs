namespace Singleton_Pattern
{
    internal class AutoRepository
    {
        public AutoRepository()
        {
        }

        internal AutomobileBase Find(string vehicle)
        {
            if (vehicle.ToUpper().Contains("BMW"))
            {
                return new BMW();
            }
            else
            {
                return NullImplemetation.Instance;
            }
        }
    }
}