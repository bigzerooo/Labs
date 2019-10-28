using System;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] sites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Smartphone nokia = new Smartphone();
            for (int i = 0; i < numbers.Length; i++)
                nokia.Call(numbers[i]);
            for (int i = 0; i < sites.Length; i++)
                nokia.Browse(sites[i]);

            Console.ReadKey();

        }
    }
}
