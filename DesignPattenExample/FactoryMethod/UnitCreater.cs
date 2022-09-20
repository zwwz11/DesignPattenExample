using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.FactoryMethod
{
    abstract class UnitCreater
    {
        public abstract Unit CreateUnit(string name);
    }
}
