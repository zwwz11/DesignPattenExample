using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Decorator
{
    abstract class Decorator : Beverage
    {
        public abstract override string GetDescription();
    }
}
