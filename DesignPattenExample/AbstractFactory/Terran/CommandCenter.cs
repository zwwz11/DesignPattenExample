using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.AbstractFactory.Terran
{
    class CommandCenter : MainCenterBuilding
    {
        public override Worker CreateWorker()
        {
            return new SCV();
        }
    }
}
