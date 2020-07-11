using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Persons;

namespace ConsoleApp3.Repository
{
    class TeacherRepository
    {
        private Teacher[] teachers =
        {
            new Teacher("classroom1","Victor","Victorovich",DateTime.Now),
            new Teacher("classroom2","Mariya","Ivanovna",DateTime.Now),
        };
        public Teacher[] FindASll()
        {
            return teachers;
        }
    }
}
