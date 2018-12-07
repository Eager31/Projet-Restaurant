using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Room.Element;
//using Modèle.Map.IElement;

namespace Modèle.Room
{
    public class ElementTable //: IElement
    {

        private int chairAmount { get; set; }
        private int tableNumber { get; set; }
        private string state { get; set; }
        private Boolean isReserved { get; set; }
        private ElementBread bread { get; set; }
        private ElementWater water { get; set; }
        private ElementPlate plate { get; set; }
        private ElementTablecloth tablecloth { get; set; }
        private ElementTowel towel { get; set; }
        private ElementGlass glass { get; set; }

        public ElementTable(int chairAmount, int tableNumber, string state, bool isReserved, ElementBread bread, ElementWater water, ElementPlate plate, ElementTablecloth tablecloth, ElementTowel towel, ElementGlass glass)
        {
            this.chairAmount = chairAmount;
            this.tableNumber = tableNumber;
            this.state = state;
            this.isReserved = isReserved;
            this.bread = bread;
            this.water = water;
            this.plate = plate;
            this.tablecloth = tablecloth;
            this.towel = towel;
            this.glass = glass;
        }


    }
}
