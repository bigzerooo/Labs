using System;
namespace _6
{
    class TrafficLight
    {
        string _state;
        public string State
        {
            get
            {
                return _state;
            }
            private set
            {
                if (value == "Yellow" || value == "Green" || value == "Red")
                    _state = value;
                else
                    throw new Exception("Wrong state!");
            }            
        }
        public void Change()
        {
            switch (State)
            {
                case "Red":
                    State = "Green";
                    break;
                case "Green":
                    State = "Yellow";
                    break;
                case "Yellow":
                    State = "Red";
                    break;
            }
        }
        public TrafficLight(string state)
        {
            State = state;
        }


    }
}
