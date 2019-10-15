using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Author:");
            string author = Console.ReadLine();
            Console.WriteLine("Input Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Input Price:");
            decimal price =decimal.Parse(Console.ReadLine());
            try
            {
                Book book = new Book(title, author, price);
                Console.WriteLine(book);
                book = new GoldenEditionBook(title, author, price);
                Console.WriteLine(book);
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadKey();
        }
    }
}
