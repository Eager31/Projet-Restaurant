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
    public class PrepareMorningDish : IDishAct
    {
        public Dish act()
        {
            Dish dish = new Dish("Spceial dessert", "Prepared in the morning", null, EnumKitchen.DishType.dessert, EnumKitchen.DishState.OK);
            return dish;
        }
        
    }
}
