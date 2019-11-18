using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimitiveCalculator calculator = new PrimitiveCalculator();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "End")
                    break;
                if (tokens[0] == "mode")
                {
                    char[] charTokens = tokens[1].ToCharArray();
                    calculator.ChangeStrategy(charTokens[0]);
                }
                else
                {
                    int result=calculator.PerformCalculation(int.Parse(tokens[0]), int.Parse(tokens[1]));
                    Console.WriteLine(result);
                }
            }
            Console.ReadKey();
        }
    }
}
