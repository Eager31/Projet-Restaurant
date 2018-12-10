using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur.Room;
using Modèle.Room;

namespace Controleur.Commun
{
    public class AssignTable // Give the client a table number
    {
        // TODO : Need to use Thread and the locks
        public void act(Client client, ElementTable table) // Assign a client to a table
        {
            PlaceClient placeClient = new PlaceClient();
            client.setTableNumber(table.tableNumber); // Give the table's number to the client
            table.state = "occupied";

            if(table.isReserved == true) // Remove reservation if assigned
            {
                table.isReserved = false;
            }
            placeClient.act(table, client); // Place the client to the table
        }
    }
}
