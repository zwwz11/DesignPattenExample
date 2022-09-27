using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Observer
{
    class ConcreateSubject : ISubject
    {
        private List<Screen> screens = new List<Screen>();
        private int price;
        public int Price 
        { 
            get { return this.price; }
            set { this.price = value; }
        }

        public void AddScreen(Screen screen)
        {
            this.screens.Add(screen);
        }

        public void RemoveScreen(Screen screen)
        {
            this.screens.Remove(screen);
        }

        public void Notify()
        {
            screens.ForEach(screen => screen.ShowPrice());
        }

    }
}
