using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    class Room
    {
        public override string ToString() => Name;

        public string Name { get; set; }

        public string Description { get; set;}
        public Room(string name, string description = null)
        {
            Name = name;
            Description = description;
        }
    }
}
