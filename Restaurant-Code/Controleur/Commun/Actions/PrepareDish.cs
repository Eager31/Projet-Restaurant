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
    public class PrepareDish
    {
        public List<Dish> act(Order order, KitchenClerck kc, Cook c)
        {
            List<Dish> dishListReturn = new List<Dish>();
            Dish mynewDish = new Dish(null, null, null, null, null);
            foreach (Menu menu in order.orderList)
            {
                foreach (Dish dish in menu.dishList)
                {
                    foreach (Instruction instruction in dish.listInstructions)
                    {
                        //On pourrait l'améliorer avec une enumeration à la place du name ==> Amélioration du porgramme
                        if (instruction.action.name.Equals("Chop Vegetables") && (!kc.lockAction))//Si nécessité de chop vegetables, demander de le faire au Comis de cuisine si dispo
                        {
                            kc.Action("ChopVegetables", null, instruction.action.duration, null); //Demander au comis de préparer le plat (Pause du comis)
                        }
                        else
                        {
                            c.lockAction = true;
                            //c.checkTime(); // sur la instruction.action.duration
                            c.lockAction = false;
                        }
                    }
                    dishListReturn.Add(new Dish(dish.name, dish.description, dish.listInstructions, dish.type, EnumKitchen.DishState.OK));

                }
            }
            return dishListReturn;
        }
    }
}
