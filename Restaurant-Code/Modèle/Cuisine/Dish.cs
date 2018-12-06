using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{

    

    public class Dish
    {
        private string name;
        private List<Instruction> listInstructions;
        private Enum type;
        private Enum state;

        public Dish(string name, List<Instruction> listInstructions, Enum type, Enum state)
        {
            this.Name = name;
            this.ListInstructions = listInstructions;
            this.Type = type;
            this.State = state;
        }

        public string Name { get => name; set => name = value; }
        public List<Instruction> ListInstructions { get => listInstructions; set => listInstructions = value; }
        public Enum Type { get => type; set => type = value; }
        public Enum State { get => state; set => state = value; }
    }
}
