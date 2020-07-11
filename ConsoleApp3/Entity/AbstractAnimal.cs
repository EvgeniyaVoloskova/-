using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
   abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public void Eat(string food) 
        {
        //реализация насыщения
        }
        abstract public string Say();
    }

}
