using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    public class ElementPlate : RoomStuff
    {
        public ElementPlate(EnumRoom.PlateType type, EnumRoom.MaterialState state) : base("Plate", type, state)
        {
        }
    }
}
