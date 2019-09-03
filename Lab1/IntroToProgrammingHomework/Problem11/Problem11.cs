using System;

    class Problem11
    {
        static void Main()
        {
        int Number, n, nDigit;
        Console.WriteLine("Input Number and n: ");
        Number =Convert.ToInt32( Console.ReadLine());
        n = Convert.ToInt32(Console.ReadLine());
        if (Number/Math.Pow(10, n - 1) < 1&& Number/Math.Pow(10, n - 1) > -1)
            Console.WriteLine("-");
        else
        {
            nDigit = (Number / (int)Math.Pow(10, n - 1)) % 10;
            Console.WriteLine(nDigit);
        }
        Console.ReadKey();
        }
    }

