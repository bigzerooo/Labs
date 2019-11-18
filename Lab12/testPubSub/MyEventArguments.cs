using System;
using System.Collections.Generic;
using System.Text;

namespace testPubSub
{
    class MyEventArguments:EventArgs
    {
        public string Message { get; set; }
        public MyEventArguments(string message)
        {
            Message = message;
        }
    }
}
