using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    public class Trap : AbstractCell
    {
        public Trap(string name) : base(name) { }
        public override string GetName()
        {
            return "K";
        }
        public override bool CanMove()
        {
            return true;
        }
        public override string ReturnNewNameAfterHuman()
        {
            throw new NotImplementedException();
        }
        public override bool CanAdd()
        {
            return true;
        }
        public override int ChangeLive()
        {
            return -1;
        }
    }
}