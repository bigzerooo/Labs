using System;
    class Topping:Ingredient
    {
    string toppingType;
    public string ToppingType
    {
        get
        {
            return toppingType;
        }
        set
        {
            if (value.ToLower() == "meat" || value.ToLower() == "veggies" || value.ToLower() == "cheese" || value.ToLower() == "sauce")
                toppingType = value.ToLower();
            else
                throw new Exception($"Cannot place {value}  on top of your pizza.");
        }
    }
    public Topping(float weight,string toppingType):base(weight)
    {
        ToppingType = toppingType;
        if (weight < 1 || weight > 50)
            throw new Exception($"{toppingType} weight should be in the range [1..50].");        
    }
    public override float Calories()
    {
        float calories= base.Calories();
        switch (ToppingType)
        {
            case "meat":
                calories *= (float)1.2;
                break;
            case "veggies":
                calories *= (float)0.8;
                break;
            case "cheese":
                calories *= (float)1.1;
                break;
            case "sauce":
                calories *= (float)0.9;
                break;
        }
        return calories;
    }
}
