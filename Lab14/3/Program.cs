using System;
using System.Text;
using System.Text.RegularExpressions;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] tokens = email.Split('@');
            string username = tokens[0];
            string domain = tokens[1];
            string censoredUsername;            

            Regex regex = new Regex(@"(\S)");//Реджекс, который принимает любой символ кроме проблеа
            censoredUsername = regex.Replace(username, "*");//Заменяет все символы кроме пробелов на *

            string censoredEmail = censoredUsername + "@" + domain;

            string text = Console.ReadLine();

            text=text.Replace(email, censoredEmail);
            Console.WriteLine(text);
        }
    }
}
