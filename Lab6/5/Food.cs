using System;
class Food
{
    string name;
    int hapiness;
    string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value.ToLower();
        }
    }
    public int Hapiness
    {
        get
        {
            return hapiness;
        }
        private set
        {
            hapiness = value;
        }
    }
    public Food(string name)
    {
        Name = name;
        switch (Name)
        {
            case "cram":
                Hapiness = 2;
                break;
            case "lembas":
                Hapiness = 3;
                break;
            case "apple":
                Hapiness = 1;
                break;
            case "melon":
                Hapiness = 1;
                break;
            case "honeycake":
                Hapiness = 5;
                break;
            case "mushrooms":
                Hapiness = -10;
                break;
            default:
                hapiness = -1;
                break;
        }
    }
}
