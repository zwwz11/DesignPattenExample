using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample.Decorator
{
    abstract class Beverage
    {
        protected string description = string.Empty;
        public virtual string GetDescription()
        {
            return this.description;
        }

        public abstract int Cost();
    }
}
