using Controleur.Commun.Interfaces;
using Controleur.Room;
using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public class PlaceClient //: IAct
    {
        // TODO : Need to use thread, locks 
        public void voidAct(ElementTable table, Client client)
        {
            ClientListTable.clientAndTable.Add(table, client); // Add the client in the list of client present in the room
            ClientList.clientList.Remove(client); // Remove the client of the queue
        }
    }
}
