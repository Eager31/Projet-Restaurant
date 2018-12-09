using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur.Room;
using Modèle.Room;

namespace Controleur.Commun
{
    public class Pay
    {
        //TODO : Take care of the threads and find how to free a thread
        public void act(Client client, ElementTable table)
        {
            // We don't manage the price of the dishes 
            // so we could think we just have to destroy the client's thread.

            table.state = "free";
            //client.Dispose();
        }
    }
}
