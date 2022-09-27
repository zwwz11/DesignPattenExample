using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Observer
{
    class ClientScreen : Screen
    {
        private ISubject subject;

        public ClientScreen(ISubject subject)
        {
            this.subject = subject;
        }

        public override void ShowPrice()
        {
            Console.WriteLine($"상대가 보는 가격 : {this.subject.Price}");
        }
    }
}
