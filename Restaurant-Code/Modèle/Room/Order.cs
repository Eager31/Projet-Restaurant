using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Kitchen.Dich;

namespace Modèle.Room
{
    class Order
    {
        Dich dich;
        int tableNumber;

        public Order(Dich dich, int tableNumber)
        {
            this.dich = dich;
            this.tableNumber = tableNumber;
        }
    }
}
