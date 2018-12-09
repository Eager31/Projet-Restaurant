using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Ingredients
    {
        public string name { get; set; }
        public Enum ingredientTypes { get; set; }
        public DateTime dateDelivered { get; set; }
        public DateTime dateExpire { get; set; }

        public Ingredients(string name, Enum ingredientTypes, DateTime dateDelivered, DateTime dateExpire)
        {
            this.name = name;
            this.ingredientTypes = ingredientTypes;
            this.dateDelivered = dateDelivered;
            this.dateExpire = dateExpire;
        }

        
    }
}
