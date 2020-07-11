using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    class Cat: AbstractAnimal
    {
       
        public override string Say()
        {
            return "meow";
        }
    }
}
