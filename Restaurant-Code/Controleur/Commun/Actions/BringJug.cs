using Controleur.Commun.Interfaces;
using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using Modèle.Room.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public class BringJug //: IAct
    {
         // TODO : Need to take care of the DateBase and of the thread lock
        public void voidAct(ElementTable table, EnumRoom.JugType type = EnumRoom.JugType.Tap) // Bring Water
        {
            ElementJug jug = new ElementJug(type, EnumRoom.MaterialState.OK); // Create a new Jug
            table.jug = jug; // Add the Jug to the table
            //Jug in database --
        }
    }

}
