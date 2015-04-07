using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    class Man : AbstractCell
    {
            public Man(string name) : base(name) { }
            public Point Coordinate;
            public int Live = 3;

            public override string GetName()
            {
                return "Man";
            }
            public override bool CanMove()
            {
                return false;
            }
            public override string ReturnNewNameAfterHuman()
            {
                throw new NotImplementedException();
            }
            public override bool CanAdd()
            {
                return false;
            }
            public override int ChangeLive()
            {
                return 0;
            }
    }
}
