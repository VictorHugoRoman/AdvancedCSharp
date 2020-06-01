using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp.Animals
{
    class Dog : LifeThing
    {
        public string Name{ get; set; }
        public Dog()
        {

        }
        public override void Execute()
        {
            throw new NotImplementedException();
        }
        public override void Life()
        {
            base.Life();
        }
        public override bool Equals(object obj)
        {
            if (obj is Dog)
            {
                Dog param = (Dog)obj;
                return param.Name.Equals(Name);
            }
            else
            {
                return base.Equals(obj);
            }
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
