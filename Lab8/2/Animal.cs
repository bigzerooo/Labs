﻿using System;
class Animal
{
    public string Name { get; set; }
    public string FavouriteFood { get; set; }
    public Animal(string name,string favouriteFood)
    {
        Name = name;
        FavouriteFood = favouriteFood;
    }
    public virtual string ExplainSelf()
    {
        return $"I am {Name} and my favourite food is {FavouriteFood}";
    }
}