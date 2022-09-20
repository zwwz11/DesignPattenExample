using DesignPatternExample.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Facade
{
    class CoffeeMachine
    {

        public Beverage MakeAmericano()
        {
            Beverage espresso = new Espresso();
            Beverage americano = new Water(espresso);
            return americano;
        }

        public Beverage MakeCafeLatte()
        {
            Beverage espresso = new Espresso();
            Beverage americano = new Water(espresso);
            Beverage cafeLatte = new Milk(americano);
            return cafeLatte;
        }
    }
}
