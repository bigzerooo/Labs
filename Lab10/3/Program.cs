using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            while (true)
            {
                string command=Console.ReadLine().Replace(',',' ');
                command = command.ToLower();
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 0)
                {
                    if (tokens[0] == "end")
                        break;
                    switch (tokens[0])
                    {
                        case "push":
                            for(int i=1;i<tokens.Length;i++)
                                stack.Push(int.Parse(tokens[i]));
                            break;
                        case "pop":
                            stack.Pop();
                            break;
                    }
                }                                    
            }
            for(int i=0;i<2;i++)
                foreach(var item in stack)
                {
                    Console.WriteLine(item);
                }
            Console.ReadKey();
        }
    }
}
