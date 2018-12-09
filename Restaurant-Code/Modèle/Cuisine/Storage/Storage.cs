using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public abstract class Storage : IStorage
    {
        public int temperature { get; set; }
        public List<Ingredients> ingredientsList { get; set; }

        protected Storage(int temperature, List<Ingredients> ingredientsList)
        {
            this.temperature = temperature;
            this.ingredientsList = ingredientsList;
        }

        public List<Ingredients> checkStorage()
        {
            return ingredientsList;
        }

        public void fillStorage(int number, Ingredients ingredient)
        {
            for (int i = 0; i < number ; i++)
            {
                ingredientsList.Add(ingredient);
            }
        }

        public void removeFromStorage(int number, Ingredients ingredient)
        {
            for (int i = 0; i < number; i++)
            {
                ingredientsList.Remove(ingredient);
            }
        }
    }
}
