using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Room.Element;
//using Modèle.Map.IElement;

namespace Modèle.Room
{
    public class ElementTable// : IElement
    {

        public int chairAmount { get; set; }
        public int tableNumber { get; set; }
        public string state { get; set; }
        public Boolean isReserved { get; set; }
        public ElementBread bread { get; set; }
        public ElementJug jug { get; set; }
        public ElementPlate plate { get; set; }
        public ElementTablecloth tablecloth { get; set; }
        public ElementTowel towel { get; set; }
        public ElementGlass glass { get; set; }
        public Card card { get; set; }

        public ElementTable(int chairAmount, int tableNumber, string state, bool isReserved, ElementPlate plate, ElementTablecloth tablecloth, ElementTowel towel, ElementGlass glass, ElementBread bread = null, ElementJug jug = null, Card card = null)
        {
            this.chairAmount = chairAmount;
            this.tableNumber = tableNumber;
            this.state = state;
            this.isReserved = isReserved;
            this.bread = bread;
            this.jug = jug;
            this.plate = plate;
            this.tablecloth = tablecloth;
            this.towel = towel;
            this.glass = glass;
            this.card = card;
        }

    }
}
