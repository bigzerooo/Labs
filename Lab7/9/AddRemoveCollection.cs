using System;
class AddRemoveCollection:AddCollection,IAddable,IRemoveable
{
    public AddRemoveCollection() : base()
    {

    }
    public override int Add(string item)
    {
        Count++;
        for (int i = Count - 1; i >= 1; i--)
        {
            Values[i] = Values[i - 1];
        }
        Values[0] = item;
        return 0;
    }
    public virtual string Remove()
    {
        Count--;
        return Values[Count];
    }
}