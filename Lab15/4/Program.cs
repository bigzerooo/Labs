using System;
using System.Collections.Generic;
using System.Linq;
namespace _4
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
                    students.Add(new Student(tokens[0], tokens[1]));
            }

            var selectedStudents = students.OrderBy(t => t.LastName).ThenByDescending(t => t.FirstName);

            foreach (var t in selectedStudents)
                Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
