using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Age: ");
            try
            {
                age = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid age type");
                age = -1;
            }
            Chicken a = new Chicken(name, age);
            if (a.CalculateProductPerDay() != 0)
            {
                Console.WriteLine($"Chicken {a.Name} (age {a.Age}) can produce {a.CalculateProductPerDay()} eggs per day");
            }
            Console.ReadLine();
        }
    }
}
