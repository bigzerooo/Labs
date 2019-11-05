using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {            
            CustomList<string> customList = new CustomList<string>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 0)
                {
                    if (tokens[0] == "END")
                        break;            
                    
                    switch (tokens[0])
                    {
                            case "Add":
                                customList.Add(tokens[1]);
                                break;
                            case "Remove":
                                customList.Remove(int.Parse(tokens[1]));
                                break;
                            case "Contains":
                                Console.WriteLine(customList.Contains(tokens[1]));
                                break;
                            case "Swap":
                                customList.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                                break;
                            case "Greater":
                                Console.WriteLine(customList.GreaterThan(tokens[1]));
                                break;
                            case "Max":
                                Console.WriteLine(customList.Max());
                                break;
                            case "Min":
                                Console.WriteLine(customList.Min());
                                break;
                            case "Print":
                                customList.Print();
                                break;
                            case "Sort":
                                Sorter.Sort<string>(customList);
                                break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
