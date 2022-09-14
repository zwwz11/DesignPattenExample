using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample.AbstractFactory
{
    class SupplyDepot : PopulationBuilding
    {
        public override void Interact(MainCenterBuilding mainCenterBuilding)
        {
            Console.WriteLine($"{mainCenterBuilding.GetType().Name}가 완성되어야 {this.GetType().Name}을 건설 할 수 있습니다.");
        }
    }
}
