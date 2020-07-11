using ConsoleApp3.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Repository
{
    class StudentRepository
    {

        private Student[] students =
        {
            new Student("gr1","Al","Iv",DateTime.Now),
            new Student("gr1","Al","Sm",DateTime.Now),
        };
        public Student[] FindASll()
        {
            return students;
        }
    }
}
