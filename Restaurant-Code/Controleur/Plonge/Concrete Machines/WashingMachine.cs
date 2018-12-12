using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Cuisine;

namespace Modèle.Plonge
{
    public class WashingMachine : WashingRoomTools
    {
        public WashingMachine() : base(10, 5, "Washing Machine") //int washTime, int maxNumber, name
        {

        }

    }
}
