using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Instruction
    {

        public int number { get; set; }
        public string name { get; set; }
        public List<KitchenTool> kitchenTool { get; set; }
        public List<Ingredients> ingredients { get; set; }
        public KitchenAction action { get; set; }
        public int duration { get; set; }

        public Instruction(int number,string name, List<KitchenTool> kitchenTool, List<Ingredients> ingredients, KitchenAction action, int duration)
        {
            this.number = number;
            this.name = name;
            this.kitchenTool = kitchenTool;
            this.ingredients = ingredients;
            this.action = action;
        }

    }
}
