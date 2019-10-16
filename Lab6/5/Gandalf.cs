using System;
using System.Collections.Generic;
class Gandalf
{
    public int Happiness
    {
        get
        {
            int happiness = 0;
            for (int i = 0; i < EatenFood.Count; i++)
                happiness += EatenFood[i].Hapiness;
            return happiness;
        }
    }
    public Mood Mood
    {
        get
        {
            return MoodFactory.Create(Happiness);
        }
    }
    List<Food> EatenFood;
    public void Eat(Food food)
    {
        if (EatenFood.Count == 100)
            Console.WriteLine("The food count would be in the range [1…100].");
        else
            EatenFood.Add(food);
    }
    public Gandalf()
    {
        EatenFood = new List<Food>();
    }
    
}
