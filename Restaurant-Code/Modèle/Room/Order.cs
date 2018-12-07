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
        private Dish dish { get; set; }
        private int tableNumber { get; set; } 

        public Order(Dish dich, int tableNumber)
        {
            this.dish = dich;
            this.tableNumber = tableNumber;
        }
    }
}
