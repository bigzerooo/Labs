using System;
class Robot:IIdentificable
{
    public string ID { get; set; }
    public string Model { get; set; }
    public bool Check(string lastDigits)
    {
        bool good = true;
        int nID = ID.Length;
        int nDig = lastDigits.Length;
        if (nDig <= nID)
        {
            int k = 0;
            for (int i = 1; i <= nDig; i++)
                if (ID[nID - i] == lastDigits[nDig - i])
                    k++;

            if (k == nDig)
                good = false;
        }
        return good;
    }
    public Robot(string model,string id)
    {
        Model = model;
        ID = id;
    }
}