using System;
using System.Collections.Generic;
using System.Text;

namespace _9
{
    class Student
    {
        public string FacultyNumber { get; set; }
        public List<int> Marks { get; set; }
        public Student(string facultyNumber,List<int> marks)
        {
            FacultyNumber = facultyNumber;
            Marks = marks;
        }

    }
}
