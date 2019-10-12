using System;
using System.Collections;
using System.Collections.Generic;
class Pizza
{
    string name;
    Dough Dough;
    List<Topping> Toppings = new List<Topping>();
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length < 1 || value.Length > 15)
                throw new Exception("Pizza name should be between 1 and 15 symbols.");
            else
                name = value;
        }
    }
    public int NumberOfToppings
    {
        get
        {
            return Toppings.Count;
        }
    }
    public Pizza(string name,Dough dough)
    {
        Name = name;
        Dough = dough;
    }
    public void AddTopping(Topping topping)
    {
        Toppings.Add(topping);
        if (Toppings.Count > 10)
            throw new Exception("Number oftoppings should be in range [0..10].");
    }
    public float TotalCalories
    {
        get
        { 
            float calories=0;
            for (int i = 0; i < Toppings.Count; i++)
                calories += Toppings[i].Calories();
            calories += Dough.Calories();
            return calories;
        }
    }
}
