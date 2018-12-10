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
    public class PrepareDish : IAct
    {
        /* principal */

        public List<Dish> dishListAct(Order order)
        {
            List<Dish> dishListReturn = new List<Dish>();
            Dish mynewDish = new Dish(null, null, null, null, null);
            foreach (Menu menu in order.dishList)
            {
                foreach (Dish dish in menu.dishList)
                {
                    dishListReturn.Add(new Dish(dish.name, dish.description, dish.listInstructions, dish.type, EnumKitchen.DishState.OK));
                }
            }
            return dishListReturn;
        }

        /* Others*/
        public bool boolAct()
        {
            throw new NotImplementedException();
        }

        public bool boolAct(Actor act)
        {
            throw new NotImplementedException();
        }

        public Dish dishAct()
        {
            throw new NotImplementedException();
        }

        public void eTableAct(Actor act)
        {
            throw new NotImplementedException();
        }

        public List<Ingredients> ingredientListAct(Storage stor)
        {
            throw new NotImplementedException();
        }

        public int intAct()
        {
            throw new NotImplementedException();
        }

        public void voidAct()
        {
            throw new NotImplementedException();
        }

        public void voidAct(Dish d)
        {
            throw new NotImplementedException();
        }

        public void voidAct(WashMachine washMachine, QueueKitchenTools queueKitchenTool)
        {
            throw new NotImplementedException();
        }

        public void voidAct(WashMachine washMachine, QueueRoomStuff queueRoomStuff)
        {
            throw new NotImplementedException();
        }

        public void voidAct(ElementTable elementTable)
        {
            throw new NotImplementedException();
        }

        public void voidAct(int number, Ingredients ingredient)
        {
            throw new NotImplementedException();
        }

        public bool boolAct(OrderTable orderTbl, Storage stor)
        {
            throw new NotImplementedException();
        }

        public void voidAct(OrderTable orderTbl)
        {
            throw new NotImplementedException();
        }

        public Dish dishAct(Order order)
        {
            throw new NotImplementedException();
        }


    }
}
