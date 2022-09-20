using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.AbstractFactory.Protoss
{
    class Protoss : Tribe
    {
        public override MainCenterBuilding CreateMainCenterBuilding()
        {
            return new Nexus();
        }

        public override PopulationBuilding CreatePopulationBuilding()
        {
            return new Pylon();
        }
    }
}
