using System;

namespace _7__Rework_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length - 7; i++)
            {
                if (text.Substring(i, 8) == "<upcase>")
                {
                    for (int j = i; j < text.Length - 8; j++)
                        if (text.Substring(j, 9) == "</upcase>")
                        {                            
                            string a = text.Substring(i + 8, j - i - 8);
                            a = a.ToUpper();                                                        
                            text =text.Remove(i, j-i+9);
                            text =text.Insert(i, a);                            
                            break;
                        }
                }
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
