using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.AbstractFactory.Terran
{
    class Terran : Tribe
    {
        public override MainCenterBuilding CreateMainCenterBuilding()
        {
            return new CommandCenter();
        }

        public override PopulationBuilding CreatePopulationBuilding()
        {
            return new SupplyDepot();
        }
    }
}
