using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    public class ElementGlass : RoomStuff
    {
        public ElementGlass(EnumRoom.GlassType type, EnumRoom.MaterialState state) : base("Glass", type, state)
        {
        }
    }
}
