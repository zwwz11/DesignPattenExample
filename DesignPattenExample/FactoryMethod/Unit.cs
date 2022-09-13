using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample.FactoryMethod
{
    abstract class Unit
    {
        private string name;
        private int health;
        private int attackPower;

        public string Name { get { return this.name; } set { this.name = value; } }
        public int Health { get { return this.health; } set { this.health = value; } }
        public int AttackPower { get { return this.attackPower; } set { this.attackPower = value; } }

        public abstract void Move(string place);
        public abstract void Attack(Unit attackedUnit);
    }
}
