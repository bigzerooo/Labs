using System;
public class Problem13
{
    public static bool IsDivided(int n) => n % 9 == 0 || n % 11 == 0 || n % 13 == 0;
    public static void Main() => Console.WriteLine(IsDivided(int.Parse(Console.ReadLine())));
}