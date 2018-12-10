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
    public class IsDishAchievable : IAct
    {
        /* Principal */

        public bool boolAct(OrderTable orderTbl, Storage stor)
        {
            foreach (Order order in orderTbl.orderList)
            {                
                foreach (Menu menu in order.dishList)
                {
                    foreach (Dish dish in menu.dishList)
                    {
                        foreach (Instruction inst in dish.listInstructions) //On récupère les instructions
                        {
                            foreach (Ingredients ing in inst.ingredients) //Pour tous les ingrédients de toutes les instructions
                            {
                                if (!stor.ingredientsList.Contains(ing)) //On peut l'améliorer plus tard, pour vérifier le nombre d'ingredient précisement
                                {
                                    return false; //Ingredient non contain into Storage
                                }
                            }
                        }   
                    }
                }
            }
            
            return true;
        }

        public bool boolAct()
        {
            throw new NotImplementedException();
        }

        public bool boolAct(Actor act)
        {
            throw new NotImplementedException();
        }

        public Dish dishAct(Order order)
        {
            throw new NotImplementedException();
        }

        public Dish dishAct()
        {
            throw new NotImplementedException();
        }

        public List<Dish> dishListAct(Order ord)
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

        public void voidAct(int number, Ingredients ingredient)
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

        public void voidAct(OrderTable orderTbl)
        {
            throw new NotImplementedException();
        }
    }
          /* Others */

}
       