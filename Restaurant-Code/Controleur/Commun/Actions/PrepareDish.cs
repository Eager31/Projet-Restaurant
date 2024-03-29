﻿using Controleur.Cuisine;
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
        public Tuple<List<Dish>,int> act(Order order, KitchenClerck kc, Cook c, Counter counter, QueueKitchenTools qKT)
        {
            List<Dish> dishListReturn = new List<Dish>();
            Dish mynewDish = new Dish(null, null, null, null, null);
            foreach (Menu menu in order.orderList)
            {
                foreach (Dish dish in menu.dishList)
                {
                    foreach (Instruction instruction in dish.listInstructions)
                    {
                        //Utilisation du morning Dish à implémenter ici

                        //On pourrait l'améliorer avec une enumeration à la place du name ==> Amélioration du porgramme
                        if (instruction.action.name.Equals("Chop Vegetables") && (!kc.lockAction))//Si nécessité de chop vegetables, demander de le faire au Comis de cuisine si dispo
                        {
                            kc.actionKitchenClerck("ChopVegetables", null, instruction.action.duration, null,null,null); //Demander au comis de préparer le plat (Pause du comis)
                        }
                        else //Cook cuisine directement
                        {
                            c.lockAction = true;
                            //c.checkTime(); // sur la instruction.action.duration
                            c.lockAction = false;
                        }

                        //Envoyer outils à la plonge
                        
                        foreach (KitchenTool kt in instruction.kitchenTool)
                        { 
                            kt.type = EnumKitchen.KitchenToolsType.Dirt;
                            qKT.kitchenToolsQueue.Add(kt); //Envoyer vers la plonge
                            //notifier le plongeur
                        }
                    }

                    dishListReturn.Add(new Dish(dish.name, dish.description, dish.listInstructions, dish.type, EnumKitchen.DishState.OK));
                }
            }
            kc.actionKitchenClerck("BringMealToCounter",null, 0,null, Tuple.Create(dishListReturn, order.tableNumber),counter);
            return Tuple.Create(dishListReturn,order.tableNumber); 
        }
    }
}
