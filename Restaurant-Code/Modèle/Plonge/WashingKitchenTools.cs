using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Plonge
{
    public abstract class WashingKitchenTools : IWashingKitchenTools
    {
        private int washTime;
        private int maxNumber;

        public WashingKitchenTools(int washTime, int maxNumber)
        {
            this.WashTime = washTime;
            this.MaxNumber = maxNumber;
        }

        public int WashTime { get => washTime; set => washTime = value; }
        public int MaxNumber { get => maxNumber; set => maxNumber = value; }

        public int wash(List<KitchenTool> kitchenToolList)
        {
            int cpt = MaxNumber;
            while (cpt >= 0)
            {
                if (!kitchenToolList.Any()) { return 0; } //Liste vide ou moins d'élements que prévu ==> Arrêt machine (même si durée ne change pas)
                foreach (KitchenTool kt in kitchenToolList) //c'est pas très beau :( mais ça marche :)
                {
                    //vérification que l'outil est bien sale
                    if (kt.Type.Equals(EnumKitchen.KitchenToolsType.dirt))
                    {
                        kitchenToolList.Remove(kt);
                        cpt--;
                    } 
                    break;
                }
            }
            return 1; //Si on lui donne une liste vide
        }
    }
}
