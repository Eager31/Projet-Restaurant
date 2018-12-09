using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Freezer : Storage
    {
        public Freezer(List<Ingredients> ingredientsList)
            : base(-10, ingredientsList)
        {

        }
    }
}
