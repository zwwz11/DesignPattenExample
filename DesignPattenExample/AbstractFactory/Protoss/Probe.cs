using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.AbstractFactory.Protoss
{
    class Probe : Worker
    {
        public Probe()
        {
            Console.WriteLine($"{GetType().Name} 생성 완료!");
        }

        public override void DigMinerals()
        {
            Console.WriteLine($"{GetType().Name} : 미네랄 캐는중...");
        }
    }
}
