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
        public Dish dish { get; set; }
        public int tableNumber { get; set; } 

        public Order(Dish dich, int tableNumber)
        {
            this.dish = dich;
            this.tableNumber = tableNumber;
        }
    }
}
