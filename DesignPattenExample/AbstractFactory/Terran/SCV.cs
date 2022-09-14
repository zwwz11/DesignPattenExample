using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample.AbstractFactory
{
    class SCV : Worker
    {
        public SCV()
        {
            Console.WriteLine($"{this.GetType().Name} 생성 완료!");
        }

        public override void DigMinerals()
        {
            Console.WriteLine($"{this.GetType().Name} : 미네랄 캐는중...");
        }
    }
}
