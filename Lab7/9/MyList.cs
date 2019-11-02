using System;
class MyList:AddRemoveCollection,IAddable,IRemoveable,IUseable
{
    public MyList() : base()
    {

    }
    public override int Add(string item)
    {
        return base.Add(item);
    }
    public override string Remove()
    {
        string item = Values[0];
        for (int i = 0; i < Count - 1; i++)
            Values[i] = Values[i + 1];
        Count--;
        return item;
    }
    public virtual int Used()
    {
        return Count;
    }
}