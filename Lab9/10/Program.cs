using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            MyTuple<string, string> name1 = new MyTuple<string, string>(tokens1[0], tokens1[1]);
            MyTuple<MyTuple<string, string>, string> tuple1 = new MyTuple<MyTuple<string, string>, string>(name1, tokens1[2]);

            string[] tokens2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            MyTuple<string, int> tuple2 = new MyTuple<string, int>(tokens2[0], int.Parse(tokens2[1]));

            string[] tokens3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            MyTuple<int, double> tuple3 = new MyTuple<int, double>(int.Parse(tokens3[0]), double.Parse(tokens3[1]));

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}
