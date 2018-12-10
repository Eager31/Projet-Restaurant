using Modèle.Cuisine;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.Interfaces
{
    public interface IDishListActWithOrder
    {
        List<Dish> act(Order order);
    }
}
