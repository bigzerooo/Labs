using System;
using System.Text.RegularExpressions;
namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            //< *div [^>]*(id|class) *= *"(?<grp1>main|header|nav|article|section|aside|footer)"[^>]*>.*< *\/div *> *< *!-- *\k<grp1> *-- *>
            //https://regex101.com/   
            //Реджекс находит нужные теги
        }
    }
}
