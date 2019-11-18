using System;

namespace testPubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub1 = new Publisher();//Паблишер имеет в себе какой-то ивент
            pub1.Name = "Tom";
            Subscriber sub1 = new Subscriber();
            Subscriber sub2 = new Subscriber();
            Subscriber sub3 = new Subscriber();
            sub1.Subscribe(pub1);//субскрайберы подписываються на этот ивент

            sub2.Subscribe(pub1);
            sub3.Subscribe(pub1);
            pub1.Notify("Hello world!");

        }
    }
}
