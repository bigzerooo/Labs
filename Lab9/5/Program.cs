using System;
using System.Collections.Generic;
namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();   
            
            for (int i = 0; i < n; i++)
                boxes.Add(new Box<string>(Console.ReadLine()));
            
            Box<string> x = new Box<string>(Console.ReadLine());


            Console.WriteLine(Count<Box<string>>(boxes,x));
        }
        static int Count<T>(List<T>list,T t ) where T : IComparable 
        {
            int k = 0;            
            for (int i = 0; i < list.Count; i++)
                if (list[i].CompareTo(t)>0)
                    k++;            
            return k;
        }
    }
}
