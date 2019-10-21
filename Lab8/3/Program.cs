using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input height of rectangle: ");
            double a =double.Parse(Console.ReadLine());
            Console.WriteLine("Input width of rectangle: ");
            double b =double.Parse(Console.ReadLine());
            Rectangle A = new Rectangle(a, b);
            A.Info();            
            Console.WriteLine(A.Draw());

            Console.WriteLine("Input radius of circle: ");
            double c = double.Parse(Console.ReadLine());
            Circle C = new Circle(c);
            C.Info();
            Console.WriteLine(C.Draw());
        }
    }
}
