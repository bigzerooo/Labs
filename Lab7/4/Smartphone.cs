using System;
class Smartphone:IBrowsable, ICallable
{
    public void Call(string number)
    {
        bool good = true;        
        for (int i = 0; i < number.Length; i++)//48-57  43
            if (char.IsNumber(number[i]) == false && number[i] != '+')
                good = false;            
        if (good)
        {
            Console.WriteLine($"Calling... {number}");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
    public void Browse(string url)
    {
        bool good = true;
        for(int i = 0; i < url.Length; i++)        
            if (char.IsNumber(url[i]))
                good = false;
        if (good)
        {
            Console.WriteLine($"Browsing {url}");
        }
        else
        {
            Console.WriteLine("Invalid URL!");
        }
    }
}