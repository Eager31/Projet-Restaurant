using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    interface IStorage
    {
        void fillStorage(int number, Ingredients ingredient);
        void removeFromStorage(int number, Ingredients ingredient);
        List<Ingredients> checkStorage();
    }
}
