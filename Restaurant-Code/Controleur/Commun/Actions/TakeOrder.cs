using Controleur.Room;
using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public class TakeOrder //: IAct
    {
        // Todo : Need to take car of the thread, the lock access
        
        Boolean orderOk = false;

        // This method changes the lock and gives the list of dish to the kitchen
        public void voidAct(Client client, List<Menu> orderList)
        {
            while (orderOk == false)
            {
                if (client.lockAction == true)  // Need to look at the lock
                {
                    Thread.Sleep(2000);
                }

                else if (client.lockAction == false) // If the client is free, take the order
                {
                    Order order = new Order(orderList, client.tableNumber);
                    client.lockAction = true;
                    // Give to the kitchen the order
                    //tableOrder.registerOrder(order);
                    orderOk = true;

                }
            }
        }
    }
}
