using System;
using System.Linq;
public class Problem15
{
    public static string Sign(float[] a) => a.Count(x => x < 0) % 2 == 0 ? "Positive" : "Negative";
    public static void Main()
    {
        float[] a = new float[3];
        for (int i = 0; i < 3; i++)
            a[i] = float.Parse(Console.ReadLine());
        Console.WriteLine(Sign(a));
    }
}