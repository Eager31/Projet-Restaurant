using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class OrderTable
    {
        public OrderTable(Dish[] dishTable, int[] tableNumberTable) //Check if we can make static
        {
            this.dishTable = dishTable;
            this.tableNumberTable = tableNumberTable;
        }

        // /!\ les indices doivent-être respectés
        public Dish[] dishTable { get; set; }
        public int[] tableNumberTable { get; set; }

    }
}
