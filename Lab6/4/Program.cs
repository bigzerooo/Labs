using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            Songs playlist = new Songs();
            for (int i=0;i<n;i++)

            { 
                string[] tokens = Console.ReadLine().Split(';');                
                try
                {
                    Song t = new Song(tokens[0],tokens[1],tokens[2]);
                    playlist.Add(t);
                    Console.WriteLine("Song added");
                }
                catch(Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
            Console.WriteLine($"Songs added:{playlist.Count}");
            Console.WriteLine($"Playlist length: {playlist.Length}");
            Console.ReadKey();            
        }
    }
}
