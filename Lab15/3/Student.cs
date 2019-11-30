using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Student(string firstName, string lastName) : this(firstName, lastName, 0)
        {

        }
        public override string ToString()
        {
            return FirstName + " " + LastName+ " " +Age;
        }
    }
}
