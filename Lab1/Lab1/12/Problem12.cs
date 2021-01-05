using System;
public class Problem12
{
    public static bool IsBigAndOdd(int n) => n > 20 && n % 2 == 1;
    public static void Main() => Console.WriteLine(IsBigAndOdd(int.Parse(Console.ReadLine())));
}