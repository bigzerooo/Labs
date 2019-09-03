using System;

    class Problem9
    {
        static void Main()
        {
        float a, b, h, area;
        Console.WriteLine("Input a, b and h: ");
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        h = float.Parse(Console.ReadLine());
        area = ((a + b) / 2) * h;
        Console.WriteLine(area);
        Console.ReadKey();
    }
    }

