﻿using System;
using System.Linq;
class Problem14
{
    static void Main()
    {
        int[] a = new int[3];
        for (int i = 0; i < 3; i++)
            a[i] = int.Parse(Console.ReadLine());
        Console.WriteLine(a.Max());
        Console.ReadKey();
    }
}