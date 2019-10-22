using System;
class Box<T>:IComparable where T: IComparable
{
    public T Value { get; set; }
    public Box(T value)
    {
        Value = value;
    }    
    public override string ToString()
    {
        return $"{this.Value.GetType().FullName}: {Value}";
    }
    public static bool operator > (Box<T> a, Box<T> b)
    {
        return a.Value.CompareTo(b.Value) > 0;
    }
    public static bool operator < (Box<T> a, Box<T> b)
    {
        return a.Value.CompareTo(b.Value) < 0;
    }    
    public int CompareTo(object obj)
    {        
        if(obj.GetType().Name== "Box`1")
        {
            Box<T> x =(Box<T>)obj;
            return this.Value.CompareTo(x.Value);
        }
        else
        {
            return 0;
        }
    }

}