using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur.Room;
using Modèle.Cuisine;

namespace Controleur.Commun
{
    public class TakeOrder
    {
        // Todo : Need to take car of the thread, the lock access
        /*
        Actor.lockAction lockAction;
        Boolean orderOk = false;

        // This method changes the lock and gives the list of dish to the kitchen
        public void act(Client client, List<Menu> menus)
        {
            while (orderOk = false) {  
                if (lockAction = true)  // Need to look at the lock
                {
                    Thread.Sleep(2000);
                }

                else if(lockAction = false) // If the client is free, take the order
                {
                    lockAction = true;
                    tableOrder.registerOrder(client.tableNumber, menus);
                    orderOk = true;

                }
            }
        }
        */
    }
}
