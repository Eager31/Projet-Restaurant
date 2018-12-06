using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    class ElementTowel : RoomStuff
    {
        public ElementTowel(string name, string type) : base(name, type)
        {
            this.name = "Towel";
            this.type = type;
        }
    }
}
