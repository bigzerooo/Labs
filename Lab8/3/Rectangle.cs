using System;
class Rectangle : Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public override double CalculateArea()
    {
        return Height * Width;
    }
    public override double CalculatePerimeter()
    {
        return (Height + Width) * 2;
    }
    public override string Draw()
    {
        string figure="";
        for(int i=0;i<Height;i++)
        {
            if (i == 0 || i == Height - 1)
                for (int j = 0; j < Width; j++)
                    if(j==0||j==Width-1)
                        figure += "|";
                    else
                        figure += "--";
            else
                for (int j = 0; j < Width; j++)
                    if (j == 0 || j == Width - 1)
                        figure += "|";
                    else
                        figure += "  ";
            figure += "\n";
        }
        return figure;
    }
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
    public override void Info()
    {
        base.Info();
    }
}
