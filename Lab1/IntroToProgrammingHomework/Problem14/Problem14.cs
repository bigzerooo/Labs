using System;

    class Problem14
    {
        static void Main()
        {
        int a, b, c,max;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        max = a;
        if (max < b) 
            max = b;
        if (max < c)
            max = c;
        Console.WriteLine(max);
        Console.ReadKey();
    }
    }

