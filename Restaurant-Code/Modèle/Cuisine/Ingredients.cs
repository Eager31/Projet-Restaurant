using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Ingredients
    {
        private string name;
        private Enum ingredientTypes;
        private DateTime dateDelivered;
        private DateTime dateExpire;

        public Ingredients(string name, Enum ingredientTypes, DateTime dateDelivered, DateTime dateExpire)
        {
            this.name = name;
            this.ingredientTypes = ingredientTypes;
            this.dateDelivered = dateDelivered;
            this.dateExpire = dateExpire;
        }

        public string Name { get => name; set => name = value; }
        public Enum IngredientTypes { get => ingredientTypes; set => ingredientTypes = value; }
        public DateTime DateDelivered { get => dateDelivered; set => dateDelivered = value; }
        public DateTime DateExpire { get => dateExpire; set => dateExpire = value; }
    }
}
