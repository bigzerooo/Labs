using System;
class Citizen:IIdentificable,IBirthable,IBuyer
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }    
    public string Birthdate { get; set; }
    public int Food { get; set; }
    public bool Check(string lastDigits)
    {
        bool good = true;
        int nID = ID.Length;
        int nDig = lastDigits.Length;
        if (nDig <= nID)
        {
            int k = 0;
            for(int i = 1; i <= nDig; i++)
                if (ID[nID - i] == lastDigits[nDig - i])
                    k++;

            if (k == nDig)
                good = false;
        }    
        return good;
    }
    public void BuyFood() => Food += 10;    
    public Citizen(string name,int age,string id,string birthdate)
    {
        Name = name;
        Age = age;
        ID = id;
        Birthdate = birthdate;
        Food = 0;
    }

}