using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Group { get; set; }
        public Student(string firstName, string lastName, int group)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
        }
        public Student(string firstName,string lastName):this(firstName,lastName,0)
        {

        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
