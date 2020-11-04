using System;
class Problem10
{
    static int LastDigit(int n) => n % 10;
    static void Main() => Console.WriteLine(LastDigit(int.Parse(Console.ReadLine())));
}