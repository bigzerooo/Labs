using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class Handler
    {
        public void OnDispatcherNameChange(NameChangeEventsArgs args)//обработчик события
        {
            Console.WriteLine($"Dispatcher's name changed to {args.Name}");
        }
    }
}
