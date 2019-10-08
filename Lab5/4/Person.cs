using System;
using System.Collections;
using System.Collections.Generic;
class Person
{
    string name;
    int money;
    List<Product> BagOfProducts=new List<Product>();
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
    public int Money
    {
        get
        {
            return money;
        }
        set
        {
            if (value < 0)
                Console.WriteLine("Money cannot be negative");
            else
                money = value;

        }
    }
    public Person(string name,int money)
    {
        Name = name;
        Money = money;
    }
    public void Buy(Product product)
    {
        if(Money<product.Cost)
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} bought {product.Name}");
            Money -= product.Cost;
            BagOfProducts.Add(product);
        }
    }
    public void DisplayBag()
    {
        Console.Write($"{Name} - ");
        if (BagOfProducts.Count > 0)
            for (int i = 0; i < BagOfProducts.Count; i++)
                Console.Write($"{BagOfProducts[i].Name}, ");
        else
            Console.Write("Nothing bought");
        Console.WriteLine();
    }
}