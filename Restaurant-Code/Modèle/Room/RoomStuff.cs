using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room
{
    abstract class RoomStuff
    {
        public string name;
        public ElementType type;

        protected RoomStuff(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
