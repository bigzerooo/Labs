using System;
abstract class Shape
{
    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
    
    public virtual string Draw()
    {
        return "";
    }    
    public virtual void Info()
    {
        Console.WriteLine($"Area: {this.CalculateArea()} Perimeter: {this.CalculatePerimeter()}");
    }
}