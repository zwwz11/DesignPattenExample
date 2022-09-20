using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Adapter
{
    class NewUnit
    {
        public virtual void Move()
        {
            Console.WriteLine("NewUnit : Move()");
        }
    }
}
