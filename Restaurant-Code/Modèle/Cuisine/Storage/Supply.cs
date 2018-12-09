using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Supply : Storage
    {
        public Supply(List<Ingredients> listIngredients)
            : base(20, listIngredients)
        {

        }
    }
}
