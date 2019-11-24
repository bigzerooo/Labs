using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            string protocol;            
            string server;
            string resource;
            int k = url.IndexOf("://");
            if (k < 0)
                protocol = "";
            else
            {
                protocol = url.Substring(0, k);
                url = url.Substring(k + 3, url.Length - (k+3));
            }            
            k = url.IndexOf("/");
            if(k<0)
            {
                server = url;
                resource = "";
            }
            else
            {
                server = url.Substring(0, k);
                resource = url.Substring(k + 1, url.Length - (k + 1));
            }
            Console.WriteLine($"[protocol]=\"{protocol}\"\n[server]=\"{server}\"\n[resource]=\"{resource}\"");
            Console.ReadKey();
        }
    }
}
