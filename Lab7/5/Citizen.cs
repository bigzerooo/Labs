using System;
class Citizen:IIdentificable
{
    public string ID { get; set; }

    public bool Check(string lastDigits)
    {
        bool good = true;
        int nID = ID.Length;
        int nDig=lastDigits.Length
        if(nID>=nDig)
        {
            nID -= 1;
            int k = 0;
            for(int i=nDig-1;i>=0;i--)
            {
                
                
            }
        }
        return good;
    }
}