using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Group { get; set; }
        public Student(string firstName,string lastName,int group)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
