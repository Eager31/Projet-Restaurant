using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class OrderTable
    {
        public OrderTable(List<Order> orderList, int[] tableNumberTable) //Check if we can make static
        {
            this.orderList = orderList;
            this.tableNumberTable = tableNumberTable;
        }

        // /!\ les indices doivent-être respectés
        public List<Order> orderList { get; set; }
        public int[] tableNumberTable { get; set; }

    }
}
