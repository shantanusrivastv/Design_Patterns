using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    using Autos;

    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory autoFactory = LoadFactory();
            IAuto car = autoFactory.CreateAutomobile();

            car.Start();
            car.Stop();
        }

        private static  IAutoFactory  LoadFactory()
        {
            // We can get this from config , DB etx.
            const string factoryName = "Bmw";
            var factortType = Assembly.GetExecutingAssembly().
                                GetTypes().
                                FirstOrDefault(x => x.Name.Contains(factoryName.ToUpper()));

            return Activator.CreateInstance(factortType) as IAutoFactory;
        }
    }
}
