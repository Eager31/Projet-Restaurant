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
    public class IsDishAchievable
    {
        /* Principal */

        public bool act(OrderTable orderTbl, Storage stor)
        {
            foreach (Order order in orderTbl.orderList)
            {
                foreach (Menu menu in order.orderList)
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

    }
}
       