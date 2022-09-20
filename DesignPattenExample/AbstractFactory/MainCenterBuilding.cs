using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.AbstractFactory
{
    abstract class MainCenterBuilding
    {
        public abstract Worker CreateWorker();
    }
}
