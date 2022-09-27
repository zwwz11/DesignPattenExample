using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Observer
{
    interface ISubject
    {
        public int Price { get; set; }
        void AddScreen(Screen screen);
        void RemoveScreen(Screen screen);
        void Notify();
    }
}
