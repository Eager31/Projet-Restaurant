using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class KitchenTool
    {

        private string name;
        private Enum type;

        public KitchenTool(string name, Enum type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get => name; set => name = value; }
        public Enum Type { get => type; set => type = value; }
    }
}
