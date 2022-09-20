using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.AbstractFactory
{
    abstract class PopulationBuilding
    {
        public abstract void Interact(MainCenterBuilding mainCenterBuilding);
    }
}
