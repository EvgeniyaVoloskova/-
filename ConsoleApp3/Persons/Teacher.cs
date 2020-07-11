using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Persons
{
    class Teacher: AbstractPerson
    {
        public string ClassroomName { get; set; }

        public override void Print()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", FirstName, SecondName, Birthday, ClassroomName);
        }
        public Teacher(
           string classroomName,
           string firstName,
           string secondName,
           DateTime birthday) : base(firstName, secondName, birthday)
        {
            ClassroomName = classroomName;

        }
    }
}
