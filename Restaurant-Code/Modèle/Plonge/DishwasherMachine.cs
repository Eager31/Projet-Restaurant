using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Plonge
{
    public class DishwasherMachine : WashingKitchenTools
    {
        public DishwasherMachine() : base(10, 3) //int washTime, int maxNumber
        {

        }
    }
}
