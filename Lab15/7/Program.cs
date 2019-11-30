using System;
using System.Collections.Generic;
using System.Linq;
namespace _7
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
                    for (int i = 2; i < tokens.Length; i++)
                        marks.Add(int.Parse(tokens[i]));
                    students.Add(new Student(tokens[0], tokens[1], marks));
                }
                    
            }

            var selectedStudents = from t in students
                                   where t.Marks.Any(x=>x==6)
                                   select t;



            foreach (var t in selectedStudents)
                Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
