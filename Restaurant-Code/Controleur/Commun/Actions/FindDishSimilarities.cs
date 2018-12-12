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
    public class FindDishSimilarities
    {
        public void act(OrderTable orderTbl)
        {
            orderTbl.orderList.Sort();
        }        
    }
}
