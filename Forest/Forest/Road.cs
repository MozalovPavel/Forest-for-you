using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    public class Road : AbstractCell
    {
        public Road(string name) : base(name) { }

        public override string GetName()
        {
            return "0";
        }
        public override bool CanMove()
        {
            return true;
        }
        public override string ReturnNewNameAfterHuman()
        {
            return "0";
        }
        public override bool CanAdd()
        {
            return true;
        }
        public override int ChangeLive()
        {
            return 0;
        }
    }
}

