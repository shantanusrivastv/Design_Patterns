using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoRepository = new AutoRepository();

            AutomobileBase automobile = autoRepository.Find("bmw");
            AutomobileBase automobile2 = autoRepository.Find("Invalid");

            //No Need to check for null
            automobile.Start();
            automobile.Stop();

            //Nothing is going to have
            automobile2.Start();
            automobile2.Stop();


            /* Similar implementaion is used in LINQ when it retuens IEnumerable hence we don't have to
             * Check for null
             *  public IEnumerable<IAutomobile> FindAllByName(string name)
                {
                   return autos.FindAll(a => a.Name.ToLower().Contains(name.ToLower()));
                }

                public IAutomobile Find(Guid id)
                {
                    return autos.Find(a => a.Id == id);
                }
                */
        }
    }
}
