using System;
class Problem13
{
    static bool IsDivided(int n) => n % 9 == 0 || n % 11 == 0 || n % 13 == 0;
    static void Main() => Console.WriteLine(IsDivided(int.Parse(Console.ReadLine())));
}