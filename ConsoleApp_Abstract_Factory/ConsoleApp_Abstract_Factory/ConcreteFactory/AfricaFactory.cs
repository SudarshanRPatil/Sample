using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp_Abstract_Factory
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
