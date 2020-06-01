using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp.interfaces
{
    class Dog : IAnimal
    {
        public string Name { get; set; }
        public Dog()
        {

        }

        public void Bark()
        {
            throw new NotImplementedException();
        }
    }
}