using System;
using System.Collections.Generic;
using System.Text;

namespace Joins
{
    class Buy
    {
        public int ID { get; set; }
        public string tName { get; set; }
        public Buy(int id, string tname)
        {
            ID = id;
            tName = tname;
        }
    }
}
