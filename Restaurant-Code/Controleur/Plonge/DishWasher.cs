using Controleur.Commun;
using Controleur.Commun.ObserverObservable;
using Modèle.Cuisine;
using Modèle.Plonge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Cuisine
{
    // Observer
    public class DishWasher : Actor
    {
        public DishWasher(string name) : base(name)
        {
            
        }
        
    }
}

