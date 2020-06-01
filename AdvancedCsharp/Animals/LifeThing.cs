using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp.Animals
{
    public abstract class LifeThing
    {
        public void DoStuff()
        {

        }
        public virtual void Life() { }
        public abstract void Execute();
    }
}
