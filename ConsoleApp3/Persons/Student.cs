using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Persons
{
    class Student: AbstractPerson
    {
        public string GroupName { get; set; }

        public override void Print()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", FirstName, SecondName, Birthday, GroupName);
        }
        public Student(
            string firstName,
            string secondName,
            string groupName,
            DateTime birthday):base(firstName, secondName, birthday)
        {
            GroupName = groupName;
            
        }
    }
}
