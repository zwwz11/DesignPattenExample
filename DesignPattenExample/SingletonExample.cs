using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample
{
    class SingletonExample
    {
        private static SingletonExample singleton;
        public static SingletonExample Instance() 
        { 
            if(singleton == null)
            {
                singleton = new SingletonExample();
            }

            return singleton;
        }
    }
}
