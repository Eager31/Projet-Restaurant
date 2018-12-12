using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.Actions
{
    public class FillStocks
    {
       public void act(Storage stor, int number, Ingredients ingredients)
        {
            stor.fillStorage(number, ingredients);
        }
    }
}
