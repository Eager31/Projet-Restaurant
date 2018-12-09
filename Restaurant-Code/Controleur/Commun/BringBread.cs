using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Room;
using Modèle.Room.Element;

namespace Controleur.Commun
{
    public class BringBread
    {
        // TODO : Need to take care of the DateBase and of the thread lock
        public void act(ElementTable table, EnumRoom.BreadType type) // Bring bread
        {
            ElementBread bread = new ElementBread(type, EnumRoom.MaterialState.OK); // Create a new bread
            table.bread = bread; // Add the bread to the table
            //Bread in database --
        }
    }
}
