using System;

    class Problem8
    {
        static void Main()
        {
        float a, b, c, average;
        a =float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        c = float.Parse(Console.ReadLine());
        average = (a + b + c) / 3;
        Console.WriteLine($"Average: {average}");
        Console.ReadKey();
    }
    }
