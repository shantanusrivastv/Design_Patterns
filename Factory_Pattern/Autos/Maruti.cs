namespace Factory_Pattern.Autos
{
    using System;

    class Maruti : IAuto
    {
        private string v;

        public Maruti(string v)
        {
            this.v = v;
        }

        public void Start()
        {
            Console.WriteLine( "Maruti has started" );
        }

        public void Stop()
        {
            Console.WriteLine("Maruti has Stopped");
        }
    }
}