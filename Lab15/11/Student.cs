using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    class Student
    {
        public string Name { get; set; }
        public string FacultyNumber { get; set; }
        public Student(string name, string facultyNumber)
        {
            Name = name;
            FacultyNumber = facultyNumber;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
