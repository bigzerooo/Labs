using System;
class AddCollection:MyCollection,IAddable
{
    public AddCollection() : base()
    {

    }
    public virtual int Add(string item)
    {
        Values[Count] = item;        
        Count++;
        return Count - 1;
    }
}