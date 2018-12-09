using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room
{
    public abstract class RoomStuff
    {
        public string name { get; set; }
        public Enum type;
        public Enum state { get; set; }
        public Enum Type { get; set; }

        protected RoomStuff(string name, Enum type, Enum state)
        {
            this.name = name;
            this.Type = type;
            this.state = state;
        }
    }
}
