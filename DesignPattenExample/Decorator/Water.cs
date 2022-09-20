using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Decorator
{
    class Water : Decorator
    {
        private Beverage beverage;
        public Water(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override int Cost()
        {
            return beverage.Cost() + 500;
        }

        public override string GetDescription()
        {
            return $"{beverage.GetDescription()} + 물 추가";
        }
    }
}
