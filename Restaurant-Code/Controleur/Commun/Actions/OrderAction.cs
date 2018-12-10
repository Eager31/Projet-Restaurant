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
    public class OrderAction //: IAct
    {
        // TODO : Need to take car of the thread, the lock access
        // TODO : Need to correct the attributes access

        public Client client { get; set; }

        public bool orderOk = false;

        Random rnd = new Random();

        List<Menu> orderList { get; set; }

        public void act(Card card)         // This method changes the lock and gives the list of dish to HeadWaiter
        {
            int sizeOfMenuDish = card.menus.Count -1 ; // Get the length of the menu list

            for (int i =0; i < client.number; i++){ // For all client on the table
                int rndNumber = rnd.Next(0, sizeOfMenuDish); // generate a random number
                Menu menuToOrder = card.menus[rndNumber]; // With this number, choose a random menu on the card
                orderList.Add(menuToOrder); // Add the menu to the order list
            }

            orderOk = true;
            TakeOrder takeOrder = new TakeOrder();
            takeOrder.voidAct(client, orderList);  
        }
    }
}
