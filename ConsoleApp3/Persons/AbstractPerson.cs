using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Persons
{
     abstract class AbstractPerson
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime Birthday { get; set; }
        abstract public void Print();
        protected AbstractPerson()
        {
            FirstName = "";
            SecondName = "";
            Birthday = DateTime.Now;
        }
        protected AbstractPerson(
            string firstName,
            string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
            Birthday = DateTime.Now;
        }
        protected AbstractPerson(
            string firstName,
            string secondName,
            DateTime birthday) 
        {
            FirstName = firstName;
            SecondName = secondName;
            Birthday = birthday;
        }
    }
}
