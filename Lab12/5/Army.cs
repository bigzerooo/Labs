using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    class Army
    {
        public List<ISoldier> soldiers;
        public Army()
        {
            soldiers = new List<ISoldier>();
        }
        public void Add(ISoldier soldier)
        {
            soldiers.Add(soldier);
            soldier.Died += Remove;
        }
        public void Remove(ISoldier soldier)
        {
            soldiers.Remove(soldier);
        }

    }
}
