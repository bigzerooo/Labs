using System;

    class Problem17
    {
        static void Main()
        {
        ulong n;
        ulong factorial = 1;
        n =Convert.ToUInt64( Console.ReadLine());
        Console.WriteLine();
        for (ulong i = 2; i <= n; i++)
        {
            factorial *= i;
            Console.WriteLine(factorial);
        }
        Console.ReadKey();
        }
    }

