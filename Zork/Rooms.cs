using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    class Rooms
    {
        public string Name { get; set; }

        public string Description { get; set;}
        public Rooms(string name, string description = null)
        {
            Name = name;
            Description = description;
        }
    }
}
