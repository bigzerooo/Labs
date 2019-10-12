using System;
abstract class Ingredient
{    
    public float Weight { get; set; }
    public virtual float Calories()//Калории
    {
        return Weight * 2;
    }        
    public Ingredient(float weight)
    {
        Weight = weight;
    }
}
