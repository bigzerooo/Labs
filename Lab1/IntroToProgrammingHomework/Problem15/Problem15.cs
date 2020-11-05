using System;
using System.Linq;
class Problem15
{
    static string Sign(float[] a) => a.Count(x => x < 0) % 2 == 0 ? "Positive" : "Negative";
    static void Main()
    {
        float[] a = new float[3];
        for (int i = 0; i < 3; i++)
            a[i] = float.Parse(Console.ReadLine());
        Console.WriteLine(Sign(a));        
    }
}