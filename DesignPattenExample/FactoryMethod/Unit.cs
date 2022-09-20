using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.FactoryMethod
{
    abstract class Unit
    {
        private string name;
        private int health;
        private int attackPower;

        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int AttackPower { get { return attackPower; } set { attackPower = value; } }

        public abstract void Move(string place);
        public abstract void Attack(Unit attackedUnit);
    }
}
