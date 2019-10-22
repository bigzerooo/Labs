using System;
class Box<T>
{
    T Value { get; set; }    
    public Box(T value)
    {
        Value = value;
    }
    public override string ToString()
    {
        return $"{this.Value.GetType().FullName}: {Value}";
    }
}