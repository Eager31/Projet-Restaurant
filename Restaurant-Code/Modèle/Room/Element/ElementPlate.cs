using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    class ElementPlate : RoomStuff
    {
        public ElementPlate(string name, string type) : base(name, type)
        {
            this.name = "Plate";
            this.type = type;
        }
    }
}
