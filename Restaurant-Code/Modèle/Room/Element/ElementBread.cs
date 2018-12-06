using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    class ElementBread : RoomStuff
    {
        public ElementBread(string name, string type) : base(name, type)
        {
            this.name = "Bread";
            this.type = type;
        }
    }
}
