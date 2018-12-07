using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    public class ElementTowel : RoomStuff
    {
        public ElementTowel(EnumRoom.TowelType type, EnumRoom.MaterialState state) : base("Towel", type, state)
        {
        }
    }
}
