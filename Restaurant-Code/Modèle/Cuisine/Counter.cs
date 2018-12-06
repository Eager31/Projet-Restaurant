using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class Counter
    {
        private Dish[] tabDish;

        public Counter()
        {
            this.TabDish = new Dish[15];
        }

        public Dish[] TabDish { get => tabDish; set => tabDish = value; }

        public int actualLengthTab()
        {
            int cpt = 0;
            for (int i = 0; i < TabDish.Length; i++)
            {
                if (tabDish[i] != null)
                {
                    cpt++;
                }
            }
            return cpt;
        }

        public Boolean isTabFull()
        {
            if (actualLengthTab() >= TabDish.Length)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
