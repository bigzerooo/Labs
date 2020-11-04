using System;
class Problem11
{
    static char NDigit(int number, int n)
    {
        string numberString = number.ToString();
        int length = numberString.Length;
        if (length < n || n <= 0)
            return '-';
        return numberString[length - n];
    }
    static void Main() =>
        Console.WriteLine(NDigit(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));    
}