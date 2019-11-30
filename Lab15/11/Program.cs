using System;
using System.Collections.Generic;
using System.Linq;
namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentSpecialty> specialties = new List<StudentSpecialty>();
            List<Student> students = new List<Student>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Students:")
                    break;
                specialties.Add(new StudentSpecialty(tokens[0] + " " + tokens[1], tokens[2]));
            }
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "END")
                    break;
                students.Add(new Student(tokens[1] + " " + tokens[2], tokens[0]));
            }

            var result = from specialty in specialties
                         join student in students on specialty.FacultyNumber equals student.FacultyNumber
                         orderby student.Name
                         select new
                         {
                             student = student.Name,
                             faculty = student.FacultyNumber,
                             specialty = specialty.Name                             
                         };
            foreach(var res in result)            
                Console.WriteLine($"{res.student} {res.faculty} {res.specialty}");
            Console.ReadKey();
        }
    }
}
