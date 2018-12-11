using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Room.Element
{
    public class ElementTablecloth : RoomStuff
    {
        public ElementTablecloth(EnumRoom.TableclothType type, EnumRoom.MaterialState state) : base("Tablecloth", type, state)
        {

        }
    }
}
