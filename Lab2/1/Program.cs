using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            
            string[] a1 = a.Split(char.Parse(" "));
            string[] b1 = b.Split(char.Parse(" "));

            int n1 = a1.Length;
            int n2 = b1.Length;

            int min = n1;//,max=n1;
            if (n2 < min)
                min = n2;
            //if (n2 > max)
              //  max = n2;
            int k1=0, k2=0;
            for (int i = 0; i < min; i++)
                if (a1[i] == b1[i])
                    k1++;
                else
                    break;
            for (int i = 0; i < min; i++)
                if (a1[n1 - 1 - i] == b1[n2 - 1 - i])
                    k2++;
                else
                    break;
            
            if (k1 > k2)
            {
                Console.Write("Найбольшее общее начало: ");
                Console.WriteLine(k1);
            }
            if (k2 > k1)
            {
                Console.Write("Найбольший общий конец: ");
                Console.WriteLine(k2);
            }
            if (k1 == k2 && k1 != 0)
            {
                Console.Write("Найбольшее общее начало и конец: ");
                Console.WriteLine(k1);
            }
            if (k1 == k2 && k1 == 0)
                Console.WriteLine("Нету общих слов");
        }
    }
}
