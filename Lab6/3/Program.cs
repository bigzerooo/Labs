using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string first_name = tokens1[0];
            string last_name = tokens1[1];
            string faculty_number = tokens1[2];
            Console.WriteLine();
            try
            {
                Student student = new Student(first_name,last_name,faculty_number);
                student.Display();
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.WriteLine();
            string[] tokens2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            first_name = tokens2[0];
            last_name = tokens2[1];
            double salary = double.Parse(tokens2[2]);
            double hours = double.Parse(tokens2[3]);
            Console.WriteLine();
            try
            {
                Worker worker = new Worker(first_name, last_name, salary, hours);
                worker.Display();
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadKey();
        }
    }
}
