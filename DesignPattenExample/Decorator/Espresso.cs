using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample.Decorator
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            base.description = "에스프레소";
        }

        public override int Cost()
        {
            return 1500;
        }
    }
}
