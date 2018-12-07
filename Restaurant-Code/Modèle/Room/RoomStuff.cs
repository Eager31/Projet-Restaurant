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
        private Enum type { get; set; }
        private Enum state { get; set; }

        protected RoomStuff(string name, Enum type, Enum state)
        {
            this.name = name;
            this.type = type;
            this.state = state;
        }
    }
}
