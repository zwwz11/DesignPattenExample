using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample.Decorator
{
    class WhippedCream : Decorator
    {
        private Beverage beverage;

        public WhippedCream(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override int Cost()
        {
            return this.beverage.Cost() + 500;
        }

        public override string GetDescription()
        {
            return $"{this.beverage.GetDescription()} + 휘핑크림 추가";
        }
    }
}
