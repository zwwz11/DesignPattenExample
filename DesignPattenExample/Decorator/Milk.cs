using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Decorator
{
    class Milk : Decorator
    {
        private Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override int Cost()
        {
            return beverage.Cost() + 500;
        }

        public override string GetDescription()
        {
            return $"{beverage.GetDescription()} + 우유 추가";
        }
    }
}
