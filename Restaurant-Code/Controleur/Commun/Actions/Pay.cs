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
    public class Pay //: IAct
    {
         //TODO : Take care of the threads and find how to free a thread
        public void voidAct(Client client, ElementTable table)
        {
            // We don't manage the price of the dishes 
            // so we could think we just have to destroy the client's thread.

            table.state = "free";
            //client.Dispose();
        }
    }
}
