using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Room;
using Modèle.Room.Element;

namespace Controleur.Commun
{
    public class BringJug
    {
            // TODO : Need to take care of the DateBase and of the thread lock
        public void act(ElementTable table, EnumRoom.JugType type ) // Bring Water
        {
            ElementJug jug = new ElementJug(type, EnumRoom.MaterialState.OK); // Create a new Jug
            table.jug = jug; // Add the Jug to the table
            //Jug in database --
        }
    }
}
