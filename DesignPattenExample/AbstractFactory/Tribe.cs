using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.AbstractFactory
{
    abstract class Tribe
    {
        public abstract MainCenterBuilding CreateMainCenterBuilding();
        public abstract PopulationBuilding CreatePopulationBuilding();
    }
}
