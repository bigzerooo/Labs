using System;
class Dough:Ingredient
{
            
    string flourType;
    public string FlourType
    {
        get
        {
            return flourType;
        }
        set
        {
            if (value.ToLower() == "white"|| value.ToLower() == "wholegrain")
                flourType = value.ToLower();
            else
                throw new Exception("Invalid type of dough");
        }
    }
    string bakingTechnique;
    public string BakingTechnique
    {
        get
        {
            return bakingTechnique;
        }
        set
        {
            if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
                bakingTechnique = value.ToLower();
            else
                throw new Exception("Invalid type of dough");
        }
    }
    public Dough(float weight,string flourType,string bakingTechnique):base(weight)
    {
        if (weight < 1 || weight > 200)
            throw new Exception("Dough weight should be in the range [1..200].");
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
    }
    public override float Calories()
    {
        float calories=base.Calories();
        switch (FlourType)
        {
            case "white":
                calories*=(float)1.5;
                break;
            case "wholegrain":
                calories *= 1;
                break;            
        }
        switch (BakingTechnique)
        {
            case "crispy":
                calories *= (float)0.9;
                break;
            case "chewy":
                calories *= (float)1.1;
                break;
            case "homemade":
                calories *= 1;
                break;
        }
        return calories;
    }

}
