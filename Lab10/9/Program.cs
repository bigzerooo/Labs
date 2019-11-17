using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 500)
                    throw new Exception("Invalid number of commands!");
                MyLinkedList myLinkedList = new MyLinkedList();
                for(int i=0;i<n;i++)
                {
                    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (tokens[0] == "Add")
                    {
                        myLinkedList.Add(int.Parse(tokens[1]));
                    }
                    if(tokens[0]=="Remove")
                    {
                        myLinkedList.Remove(int.Parse(tokens[1]));
                    }
                }
                Console.WriteLine(myLinkedList.Count);
                foreach (int x in myLinkedList)
                {
                    Console.Write($"{x} ");
                }
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadKey();
        }
    }
}
