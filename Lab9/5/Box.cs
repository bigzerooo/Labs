using System;
class Box<T>:IComparable where T: IComparable //Где Т можно сравнивать
{
    public T Value { get; set; }//Значение в коробке
    public Box(T value) //Конструктор
    {
        Value = value;
    }    
    public override string ToString()//Строка
    {
        return $"{this.Value.GetType().FullName}: {Value}";
    }
    public static bool operator > (Box<T> a, Box<T> b)//Операторы сравнения коробок >
    {
        return a.Value.CompareTo(b.Value) > 0;
    }
    public static bool operator < (Box<T> a, Box<T> b)//Операторы сравнения коробок <
    {
        return a.Value.CompareTo(b.Value) < 0;
    }    
    public int CompareTo(object obj)
    {
        if(this.GetType().Name==obj.GetType().Name)
        {
            Box<T> x = (Box<T>)obj;
            return this.Value.CompareTo(x.Value);
        }
        //if (obj.GetType().Name == "Box`1")
        //{
        //    Box<T> x = (Box<T>)obj;
        //    return this.Value.CompareTo(x.Value);
        //}
        else
        {
            return 0;
        }
    }

}