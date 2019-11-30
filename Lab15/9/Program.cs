using System;
using System.Collections.Generic;
using System.Linq;
namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "END")
                    break;
                else
                {
                    List<int> marks = new List<int>();
                    for (int i = 1; i < tokens.Length; i++)
                        marks.Add(int.Parse(tokens[i]));
                    students.Add(new Student(tokens[0],marks));
                }

            }

            var selectedStudents = from t in students
                                   where t.FacultyNumber.Substring(4,2)=="14"|| t.FacultyNumber.Substring(4, 2) == "15"
                                   select t;



            foreach (var t in selectedStudents)
            {          
                foreach (int mark in t.Marks)                
                    Console.Write($"{mark} ");                
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
