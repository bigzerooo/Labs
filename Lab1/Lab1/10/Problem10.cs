using System;
public class Problem10
{
    public static int LastDigit(int n) => n % 10;
    public static void Main() => Console.WriteLine(LastDigit(int.Parse(Console.ReadLine())));
}