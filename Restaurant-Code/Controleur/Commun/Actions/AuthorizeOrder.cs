using Controleur.Commun.Interfaces;
using Controleur.Cuisine;
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
    public class AuthorizeOrder
    {
        /* Main */
        public void act(OrderTable orderTbl, Cook c, KitchenClerck kc, Counter counter, QueueKitchenTools queueKitchenTools)
        {
            //Les cooks vont devoir cuisiner
           foreach (Order order in orderTbl.orderList)
            {
                c.Action("PrepareDish", order, kc, counter, queueKitchenTools);
            }

        }

        public void act(OrderTable orderTbl)
        {
            throw new NotImplementedException();
        }
    }
}
