using System;
abstract class MyCollection
{
    protected string[] Values;
    protected int Count { get; set; }
    public MyCollection()
    {
        Values = new string[100];
        Count = 0;
    }
}