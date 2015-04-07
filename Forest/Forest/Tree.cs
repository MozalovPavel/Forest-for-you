using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    public class Tree : AbstractCell
    {
        public Tree(string name) : base(name) { }
        public override string GetName()
        {
           return "1";
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
