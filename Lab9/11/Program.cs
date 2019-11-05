using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 tuple
            string[] tokens1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            MyTuple<string, string> name = new MyTuple<string, string>(tokens1[0], tokens1[1]);
            MyTuple<MyTuple<string, string>, string, string> tuple1 = new MyTuple<MyTuple<string, string>, string, string>(name, tokens1[2], tokens1[3]);

            //2 tuple
            string[] tokens2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool drunkOrNot;
            if (tokens2[2] == "drunk")
                drunkOrNot = true;
            else
                drunkOrNot = false;
                MyTuple<string, int, bool> tuple2 = new MyTuple<string, int, bool>(tokens2[0],int.Parse(tokens2[1]),drunkOrNot);

            //3 tuple
            string[] tokens3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            MyTuple<string, double, string> tuple3 = new MyTuple<string, double, string>(tokens3[0],double.Parse(tokens3[1]),tokens3[2]);

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}
