namespace Singleton_Pattern
{
    using System;

    internal abstract class AutomobileBase
    {
        public abstract string Name { get; }

        public abstract void Start();

        public abstract void Stop();
    }

    internal class NullImplemetation : AutomobileBase
    {
        public override string Name
        {
            get { return String.Empty; }
        }
        private NullImplemetation()
        {
        }

        public static AutomobileBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NullImplemetation();
                }
                return instance;
            }
        }

        private static NullImplemetation instance = null;
        



        public override void Start()
        {
            //do nothing
        }

        public override void Stop()
        {
            //do nothing
        }
    }
}