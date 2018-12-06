using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{

    

    public class Recipe
    {
        private string name;
        private List<Instruction> listInstructions;

        public Recipe(string name, List<Instruction> listInstructions)
        {
            this.Name = name;
            this.ListInstructions = listInstructions;
        }

        public string Name { get => name; set => name = value; }
        public List<Instruction> ListInstructions { get => listInstructions; set => listInstructions = value; }
    }
}
