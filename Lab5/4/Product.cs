using System;
class Product
{
    string name;
    int cost;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value == "")
                Console.WriteLine("Name cannot be an empty string");
            else
                name = value;
        }
    }
    public int Cost
    {
        get
        {
            return cost;
        }
        set
        {
            cost = value;
        }
    }
    public Product(string name,int cost)
    {
        Name = name;
        Cost = cost;
    }
}
