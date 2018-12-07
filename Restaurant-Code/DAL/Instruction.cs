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
        public Ingredient ingredient { get; set; }
        public Action action { get; set; }
        public KitchenTool tool { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
