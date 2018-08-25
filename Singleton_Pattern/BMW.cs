namespace Singleton_Pattern
{
    using System;

    class BMW : AutomobileBase
    {
        public override string Name
        {
            get { return "BMW 335 Xi"; }
        }
        public override void Start()
        {
            Console.WriteLine("BMW has started ");
        }

        public override void Stop()
        {
            Console.WriteLine("BMW has stopped ");
        }
    }
}