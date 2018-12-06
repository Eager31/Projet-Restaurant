using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    class ElementWater : RoomStuff
    {
        public ElementWater(string name, string type) : base(name, type)
        {
            this.name = "Tablecloth";
            this.type = type;
        }
    }
}
