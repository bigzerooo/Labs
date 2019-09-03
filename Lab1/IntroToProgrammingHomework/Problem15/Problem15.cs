using System;

    class Problem15
    {
        static void Main()
        {
        double a, b, c;
        int counter=0;
        string sign="none";
        a =Convert.ToDouble( Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        if (a < 0)
            counter++;
        if (b < 0) 
            counter++;
        if (c < 0)
            counter++;

        if (counter == 1 || counter == 3)
            sign = "Negative";
        if (counter == 0 || counter == 2)
            sign = "Positive";
        Console.WriteLine(sign);
        Console.ReadLine();
        }
    }

