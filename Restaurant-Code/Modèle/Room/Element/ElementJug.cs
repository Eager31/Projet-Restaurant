using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    class ElementJug : RoomStuff
    {
        public ElementJug(string name, string type) : base(name, type)
        {
            this.name = "Jug";
            this.type = type;
        }
    }
}
