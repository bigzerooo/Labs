using System;
class Circle:Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
    public override double CalculatePerimeter()
    {
        return Math.PI * 2 * Radius;
    }
    public override string Draw()
    {
        string figure="";
        for (int i = 0; i <= 2 * Radius; i++)
        {
            for (int j = 0; j <= 2 * Radius; j++)
            {
                double distance = Math.Sqrt((double)(i - Radius) * (i - Radius) + (j - Radius) * (j - Radius));
                if (distance > Radius - 0.5 && distance < Radius + 0.5)
                {
                    figure += "**";//Console.Write("**");
                }
                else
                {
                    figure += "  ";// Console.Write("  ");
                }
            }
            figure += "\n";// Console.Write("\n");
        }
        return figure;
    }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override void Info()
    {
        base.Info();
    }
}
