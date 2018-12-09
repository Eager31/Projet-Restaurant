using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{

    public class Dish
    {
        public string name { get; set; }
        public List<Instruction> listInstructions { get; set; }
        public Enum type { get; set; }
        public Enum state { get; set; }
        public string description { get; set; }

        public Dish(string name, string description, List<Instruction> listInstructions, Enum type, Enum state)
        {
            this.name = name;
            this.listInstructions = listInstructions;
            this.type = type;
            this.state = state ;
            this.description = description;
        }

    }
}
