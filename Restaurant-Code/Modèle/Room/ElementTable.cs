using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Room.Element;
using Modèle.Map.IElement

namespace Modèle.Room
{
    class ElementTable : IElement
    {
        int chairAmount;
        int tableNumber;
        string state;
        Boolean isReserved;
        ElementBread bread;
        ElementWater water;
        ElementPlate plate;
        ElementTablecloth tablecloth;
        ElementTowel towel;
        ElementGlass glass;


    }
}
