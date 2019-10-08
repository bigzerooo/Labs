using System;
class Box
{
    float length, width, height;       
    float Length
    {
        get
        {
            return length;
        }
        set
        {
            if (value <= 0)
                Console.WriteLine("Length cannot be zero or negative");
            else
                length = value;
        }
    }
    float Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value <= 0)
                Console.WriteLine("Width cannot be zero or negative");
            else
                width = value;
        }
    }
    float Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value <= 0)
                Console.WriteLine("Length cannot be zero or negative");
            else
                height = value;
        }
    }
    public Box(float length, float width, float height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    public float SurfaceArea()
    {
        float result = 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
        return result;
    }
    public float LateralSurfaceArea()
    {
        float result = 2 * Length * Height + 2 * Width * Height;
        return result;
    }
    public float Volume()
    {
        float result = Length * Width * Height;
        return result;
    }
}

