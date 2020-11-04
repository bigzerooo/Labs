using System;
class Problem9
{
    static float Area(float a, float b, float h) => (a + b) / 2 * h;
    static void Main()
    {
        float[] a = new float[3];
        for (int i = 0; i < 3; i++)
            a[i] = float.Parse(Console.ReadLine());
        Console.WriteLine(Area(a[0], a[1], a[2]));
    }
}