using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    using Factory;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory autoFactory = LoadFactory();

            PrintHeader("SPORTS CAR");
            var sportsCar = autoFactory.CreateSportsCar();
            sportsCar.TurnOn();
            sportsCar.TurnOff();


            PrintHeader("LUXURY CAR");
            var luxuryCar = autoFactory.CreateLuxuryCar();
            luxuryCar.TurnOn();
            luxuryCar.TurnOff();


            PrintHeader("ECONOMY CAR");
            var economyCar = autoFactory.CreateEconomyCar();
            economyCar.TurnOn();
            economyCar.TurnOff();
            Console.ReadKey();

        }

        static void PrintHeader(string title)
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++ {0} ++++++++++++++++++", title);
        }

        private static IAutoFactory LoadFactory()
        {
            // We can get this from config , DB etx.
            const string factoryName = "Mini";
            var factortType = Assembly.GetExecutingAssembly().
                                GetTypes().
                                FirstOrDefault(x => x.Name.Contains(factoryName));


            if (factortType != null)
            {
                return Activator.CreateInstance(factortType) as IAutoFactory;

            }
            else
            {
                throw new NullReferenceException("Type is null");
            }
        }
    }
}
