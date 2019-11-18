using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            for(int i=0;i<100;i++)
            { 
                string command=Console.ReadLine();
                if (command == "End")
                    break;
                try
                { 
                    dispatcher.Name = command;
                }
                catch(Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
            Console.ReadKey();
            
        }
    }
}
