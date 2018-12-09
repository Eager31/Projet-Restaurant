using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int typeId { get; set; }
        public int quantityInStock { get; set; }
        public DateTime dateArrival { get; set; }
        public DateTime dateExpire { get; set; }
    }
}
