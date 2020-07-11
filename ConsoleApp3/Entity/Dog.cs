using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    class Dog : AbstractAnimal
    {
        
        public override string Say()
        {
            return "woof";
        }
    }
}
