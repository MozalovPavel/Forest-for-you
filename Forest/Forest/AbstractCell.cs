using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest
{
    public abstract class AbstractCell
    {
        public AbstractCell(string name)
        {
            this.name = name;
        }
        public abstract string GetName();
        public abstract bool CanMove();
        public abstract string ReturnNewNameAfterHuman();
        public abstract int ChangeLive();
        protected string name;
        public abstract bool CanAdd();
    }
}
