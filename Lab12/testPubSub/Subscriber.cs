using System;
using System.Collections.Generic;
using System.Text;

namespace testPubSub
{
    class Subscriber
    {
        public void Subscribe(Publisher publisher)//Добавить обработчик события
        {
            publisher.MyEvent += Update;
        }
        public void Unsubscribe(Publisher publisher)//Забрать обработчик события
        {
            publisher.MyEvent -= Update;
        }
        public void Update(object sender,MyEventArguments args)//Сам обработчик события
        {
            Console.WriteLine(((Publisher)sender).Name + " sent a message " + args.Message);
        }
    }
}
