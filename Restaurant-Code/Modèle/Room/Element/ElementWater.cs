using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    public class ElementWater : RoomStuff
    {
        public ElementWater(EnumRoom.WaterType type, EnumRoom.MaterialState state) : base("Water", type, state)
        {
        }
    }
}
