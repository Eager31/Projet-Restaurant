using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room
{
    public abstract class RoomStuff
    {
        private string name { get; set; }
        private Enum type;
        private Enum state { get; set; }
        public Enum Type { get => type; set => type = value; }

        protected RoomStuff(string name, Enum type, Enum state)
        {
            this.name = name;
            this.Type = type;
            this.state = state;
        }
    }
}
