namespace Factory_Pattern.Autos
{
    using System;

    internal class BMW : IAuto
    {
        public void Start()
        {
            Console.WriteLine( " BMW is started ");
        }

        public void Stop()
        {
            Console.WriteLine(" BMW is started ");
        }
    }
}