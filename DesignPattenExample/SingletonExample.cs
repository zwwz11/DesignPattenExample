﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
{
    class SingletonExample
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }

        private static SingletonExample singleton;
        public static SingletonExample Instance()
        {
            if (singleton == null)
            {
                singleton = new SingletonExample();
            }

            return singleton;
        }
    }
}
