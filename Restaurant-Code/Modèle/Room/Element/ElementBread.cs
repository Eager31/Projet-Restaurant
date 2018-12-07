using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    public class ElementBread : RoomStuff
    {
        public ElementBread(EnumRoom.BreadType type, EnumRoom.MaterialState state) : base("Bread", type, state)
        {
        }
    }
}
