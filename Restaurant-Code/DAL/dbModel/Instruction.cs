using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Instruction
    {
        public int ID { get; set; }
        public int ingredientId { get; set; }
        public int actionId { get; set; }
        public int toolId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
