﻿using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.FactoryMethod
{
    class Marine : Unit
    {
        public Marine(string name)
        {
            Name = name;
            Health = 100;
            AttackPower = 20;
            Console.WriteLine($"{name} 생성 완료!");
        }

        public override void Attack(Unit attackedUnit)
        {
            attackedUnit.Health -= AttackPower;
            Console.WriteLine($"{attackedUnit.Name}이 공격당해 체력이 {attackedUnit.Health} 남았습니다.");
        }

        public override void Move(string place)
        {
            Console.WriteLine($"{place}으로 이동");
        }
    }
}
