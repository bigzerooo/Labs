using System;
namespace _3_REWORK
{
    class Program
    {
        static void Main(string[] args) //with boxes
        {
            int n = int.Parse(Console.ReadLine());
            Box<string>[] boxes= new Box<string>[n];
            
            for (int i = 0; i < n; i++)
            {
                Box<string> t = new Box<string>(Console.ReadLine());
                boxes[i] = t;
            }

            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] indexes = new int[2];
            indexes[0] = int.Parse(tokens[0]);
            indexes[1] = int.Parse(tokens[1]);

            string a = boxes[indexes[0]].Value;
            string b = boxes[indexes[1]].Value;            
            Swap<string>(ref a, ref b);
            boxes[indexes[0]].Value = a;
            boxes[indexes[1]].Value = b;

            for (int i = 0; i < n; i++)
              Console.WriteLine(boxes[i].ToString());            

            Console.ReadKey();
        }
        public static void Swap<T>(ref T a,ref T b)
        {
            T c = a;            
            a = b;
            b = c;            
        }

    }
}
