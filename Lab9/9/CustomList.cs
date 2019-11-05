using System;
using System.Collections;
public class CustomList<T>:IEnumerable where T: IComparable
{
    public T[] Values { get; set; }
    public IEnumerator GetEnumerator()
    {
        return Values.GetEnumerator();
    }
    public int Count { get; private set; }
    public CustomList()
    {
        Values = new T[20];
        Count = 0;
    }
    public CustomList(T[] values)
    {
        Values = values;
        Count = values.Length;
    }
    public void Print()
    {

        for (int i = 0; i < Count; i++)
        {
            Console.Write($"{Values[i]}\n");
        }
        //Console.WriteLine();
    }
    public void PrintEvery()        //foreach
    {
            foreach (T i in Values)
            Console.Write($"{i}\n");
    }

public void Add(T item)
    {
        Values[Count] = item;
        Count++;
    }
    public void Remove(int index)
    {
        for(int j=index;j<Count-1;j++)
        {
            Values[j] = Values[j + 1];
        }
        Count--;
    }
    public bool Contains(T item)
    {
        bool contains = false;
        for (int i = 0; i < Count; i++)
            if (Values[i].CompareTo(item)==0)
                contains = true;
        return contains;
    }
    public void Swap(int i1,int i2)
    {
        if(i1<Count&&i2<Count&&i1>=0&&i2>=0)
        { 
            T t = Values[i1];
            Values[i1] = Values[i2];
            Values[i2] = t;
        }
    }
    public int GreaterThan(T item)
    {
        int k = 0;
        for(int i=0;i<Count;i++)
            if (Values[i].CompareTo(item) > 0)
                k++;
        return k;
    }
    public T Max()
    {
        T max = Values[0];
        for (int i = 0; i < Count; i++)
            if (Values[i].CompareTo(max) > 0)
                max = Values[i];
        return max;
    }
    public T Min()
    {
        T min = Values[0];
        for (int i = 0; i < Count; i++)
            if (Values[i].CompareTo(min) < 0)
                min = Values[i];
        return min;
    }
}