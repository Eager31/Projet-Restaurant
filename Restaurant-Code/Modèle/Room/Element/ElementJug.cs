using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    public class ElementJug : RoomStuff
    {
        public ElementJug(EnumRoom.JugType type, EnumRoom.MaterialState state) : base("Jug", type, state)
        {
        }
    }
}
