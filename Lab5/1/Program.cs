using System;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            float l, w, h;
            Console.Write("Length: ");
            l = float.Parse(Console.ReadLine());
            Console.Write("Width: ");
            w = float.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            h = float.Parse(Console.ReadLine());
            Box a = new Box(l, w, h);
            Console.WriteLine($"Surface Area - {a.SurfaceArea()}");
            Console.WriteLine($"Lateral Surface Area - {a.LateralSurfaceArea()}");
            Console.WriteLine($"Volume - {a.Volume()}");
            Console.ReadKey();

        }
    }
}
