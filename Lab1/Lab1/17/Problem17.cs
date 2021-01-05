using System;
using System.Linq;
public class Problem17
{
    public static int Factorial(int n) => Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item);
    public static void Main() => Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));
}