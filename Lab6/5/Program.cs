using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Gandalf gandalf = new Gandalf();
            string input = Console.ReadLine();
            if (input.Length > 1000)
                throw new Exception("The characters in the input string will be no more than: 1000");
            string[] foods = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < foods.Length; i++)
            { 
                gandalf.Eat(FoodFactory.Create(foods[i]));
            }
            Console.WriteLine(gandalf.Happiness);
            Console.WriteLine(gandalf.Mood.Name);
            Console.ReadKey();
        }
    }
}
