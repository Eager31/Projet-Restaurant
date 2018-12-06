using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public abstract class DishDecorator : Dish
    {
        public DishDecorator(Dish originalDish) : base(originalDish.Name, originalDish.Description, originalDish.ListInstructions, originalDish.Type, originalDish.State)
        {

        }
    }
}
