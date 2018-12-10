using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Cuisine;

namespace Modèle.Room
{
    public class Order
    {
        public List<Menu> dishList { get; set; }
        public int tableNumber { get; set; } 

        public Order(List<Menu> dishList, int tableNumber)
        {
            this.dishList = dishList;
            this.tableNumber = tableNumber;
        }
    }
}
