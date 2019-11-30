using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Marks { get; set; }
        public Student(string firstName, string lastName, List<int> marks)
        {
            FirstName = firstName;
            LastName = lastName;
            Marks = marks;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
