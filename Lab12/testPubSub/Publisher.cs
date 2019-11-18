using System;
using System.Collections.Generic;
using System.Text;

namespace testPubSub
{
    class Publisher
    {
        public string Name { get; set; }//Поле
        public EventHandler<MyEventArguments> MyEvent;//Событие
        public void Notify(string message)//Метод вызывающий событие
        {
            MyEventArguments args = new MyEventArguments(message);
            MyEvent?.Invoke(this,args); 
        }
    }
}
