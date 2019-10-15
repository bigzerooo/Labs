using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Person's Name and Age: ");
            string[] tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            int age =int.Parse(tokens[1]);
            try
            {
                Person person = new Person(name, age);
                Console.WriteLine(person);
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }            
            Console.WriteLine("Input Child's Name and Age: ");
            tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            name = tokens[0];
            age = int.Parse(tokens[1]);
            try
            { 
                Child child = new Child(name, age);
                Console.WriteLine(child.ToString());
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadKey();
        }
    }
}
