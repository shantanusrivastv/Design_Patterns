namespace Abstract_Factory_Pattern.Autos
{
    public class NullAutomobile : IAutomobile
    {
        public string Name
        {
            get { return string.Empty; }
        }

        public void TurnOn()
        {
            
        }

        public void TurnOff()
        {
            
        }
    }
}