using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Human
    {
        public string Name { get; }
        public Human(string name)
        {
            Name = name;
        }
    }
}
