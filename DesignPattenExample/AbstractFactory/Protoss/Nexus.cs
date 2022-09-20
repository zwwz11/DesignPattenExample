using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.AbstractFactory.Protoss
{
    class Nexus : MainCenterBuilding
    {
        public override Worker CreateWorker()
        {
            return new Probe();
        }
    }
}
