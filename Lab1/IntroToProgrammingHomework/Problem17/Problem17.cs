using System;
using System.Linq;
class Problem17
{
    static int Factorial(int n) => Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item);
    static void Main() => Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));
}