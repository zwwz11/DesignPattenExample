using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample.Decorator
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
            return this.beverage.Cost() + 500;
        }

        public override string GetDescription()
        {
            return $"{this.beverage.GetDescription()} + 물 추가";
        }
    }
}
