using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (tokens[0] != "Pizza")
                throw new Exception("It's not Pizza!");
            string name = tokens[1];
            string[] tokens2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (tokens2[0] != "Dough")
                throw new Exception("It's not Dough!");
            Dough dough = new Dough(float.Parse(tokens2[3]), tokens2[1], tokens2[2]);
            Pizza pizza = new Pizza(name, dough);
            while (true)
            {                
                string[] tokens3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens3[0] == "END")
                    break;
                if (tokens3[0] != "Topping")
                    throw new Exception("It's not Topping!");
                Topping topping = new Topping(float.Parse(tokens3[2]), tokens3[1]);
                pizza.AddTopping(topping);
            }
            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories.ToString("0.00")} Calories");
            Console.ReadKey();
        }
    }
}
