using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Instruction
    {

        private int number;
        private string name;
        private List<KitchenTool> kitchenTool;
        private List<Ingredients> ingredients;
        private KitchenAction action;

        public Instruction(int number,string name, List<KitchenTool> kitchenTool, List<Ingredients> ingredients, KitchenAction action)
        {
            this.Number = number;
            this.Name = name;
            this.KitchenTool = kitchenTool;
            this.Ingredients = ingredients;
            this.Action = action;
        }

        public int Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
        public List<KitchenTool> KitchenTool { get => kitchenTool; set => kitchenTool = value; }
        public List<Ingredients> Ingredients { get => ingredients; set => ingredients = value; }
        public KitchenAction Action { get => action; set => action = value; }
    }
}
