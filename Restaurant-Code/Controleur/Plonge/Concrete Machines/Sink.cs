using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Plonge
{
    public class Sink : WashingKitchenTools
    {
        public Sink() : base(20, 3, "Sink") //int washTime, int maxNumber, name
        {

        }
    }
}
