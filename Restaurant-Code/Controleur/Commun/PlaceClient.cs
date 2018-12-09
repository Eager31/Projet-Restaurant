using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur.Room;
using Modèle.Room;

namespace Controleur.Commun
{
    public class PlaceClient
    {
        // TODO : Need to use thread, locks 
        public void act(ElementTable table, Client client)
        {
            ClientListTable.clientAndTable.Add(table, client); // Add the client in the list of client present in the room
            ClientList.clientList.Remove(client); // Remove the client of the queue
        }
    }
}
