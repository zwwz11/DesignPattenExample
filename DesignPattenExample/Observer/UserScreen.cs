using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Observer
{
    class UserScreen : Screen
    {
        private ISubject subject;

        public UserScreen(ISubject subject)
        {
            this.subject = subject;
        }

        public override void ShowPrice()
        {
            Console.WriteLine($"내가 보는 가격 : {this.subject.Price}");
        }
    }
}
