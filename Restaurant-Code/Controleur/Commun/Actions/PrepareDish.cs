using Controleur.Commun.Interfaces;
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
    public class PrepareDish : IDishListActWithOrder
    {
        public List<Dish> act(Order order)
        {
            List<Dish> dishListReturn = new List<Dish>();
            Dish mynewDish = new Dish(null, null, null, null, null);
            foreach (Menu menu in order.orderList)
            {
                foreach (Dish dish in menu.dishList)
                {
                    dishListReturn.Add(new Dish(dish.name, dish.description, dish.listInstructions, dish.type, EnumKitchen.DishState.OK));
                }
            }
            return dishListReturn;
        }
    }
}
