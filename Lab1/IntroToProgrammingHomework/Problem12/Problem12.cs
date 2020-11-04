using System;
class Problem12
{
    static bool IsBigAndOdd(int n) => n > 20 && n % 2 == 1;
    static void Main()
    {
        Console.WriteLine(IsBigAndOdd(int.Parse(Console.ReadLine())));
        Console.ReadKey();
    }
}