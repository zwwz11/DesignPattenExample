using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample.FactoryMethod
{
    internal class Barracks : UnitCreater
    {
        public override Unit CreateUnit(string name)
        {
            return new Marine(name);
        }
    }
}
