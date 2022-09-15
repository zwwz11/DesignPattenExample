using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample.Adapter
{
    class Unit : NewUnit
    {
        private OldUnit oldUnit = new OldUnit();

        public override void Move()
        {
            oldUnit.MoveToPoint();
        }
    }
}
