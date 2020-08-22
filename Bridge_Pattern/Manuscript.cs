namespace Bridge_Pattern
{
    public abstract class Manuscript
    {
        protected readonly IFormatter _formatter;

        protected Manuscript(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public abstract void Print();
    }
}