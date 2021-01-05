using System;
public class Problem11
{
    public static char NDigit(int number, int n)
    {
        string numberString = number.ToString();
        int length = numberString.Length;
        if (length < n || n <= 0)
            return '-';
        return numberString[length - n];
    }
    public static void Main() =>
        Console.WriteLine(NDigit(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
}