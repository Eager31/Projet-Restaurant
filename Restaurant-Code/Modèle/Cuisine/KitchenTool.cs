using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class KitchenTool
    {

        public string name { get; set; }
        public Enum type { get; set; }

        public KitchenTool(string name, Enum type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
