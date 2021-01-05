using System;
public class Problem9
{
    public static float Area(float a, float b, float h) => (a + b) / 2 * h;
    public static void Main()
    {
        float[] a = new float[3];
        for (int i = 0; i < 3; i++)
            a[i] = float.Parse(Console.ReadLine());
        Console.WriteLine(Area(a[0], a[1], a[2]));
    }
}