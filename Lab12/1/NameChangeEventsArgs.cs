using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class NameChangeEventsArgs:EventArgs//аргументы события
    {
        public string Name {get; private set; }//аргумент - Имя, которое может быть установлено конструктором
        public NameChangeEventsArgs(string name)
        {
            Name = name;
        }
    }
}
