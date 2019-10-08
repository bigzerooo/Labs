using System;
    class Box
    {
    float Length { get; set; }
    float Width { get; set; }
    float Height { get; set; }
    public Box(float length,float width,float height)
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

