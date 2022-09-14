using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample.AbstractFactory
{
    class Nexus : MainCenterBuilding
    {
        public override Worker CreateWorker()
        {
            return new Probe();
        }
    }
}
