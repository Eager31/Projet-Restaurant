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
    public class CheckStocks
    {

        public List<Ingredients> act(Storage stor)
        {
            return stor.checkStorage();
        }
        
    }
}
