using System;

    class Problem10
    {
        static void Main()
        {
        int n, lastDigit;
        n = Convert.ToInt32(Console.ReadLine());
        lastDigit = n % 10;
        Console.WriteLine(lastDigit);
        Console.ReadKey();
        }
    }

