using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string driversName = Console.ReadLine();
            Ferrari car = new Ferrari(driversName);
            car.Info();
            Console.ReadKey();
        }
    }
}
