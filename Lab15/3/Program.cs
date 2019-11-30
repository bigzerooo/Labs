using System;
using System.Collections.Generic;
using System.Linq;
namespace _3
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
                    students.Add(new Student(tokens[0], tokens[1],int.Parse(tokens[2])));
            }
            var selectedStudents = from t in students
                                   where t.Age>=18&&t.Age<=24
                                   select t;
            foreach (var t in selectedStudents)
                Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
