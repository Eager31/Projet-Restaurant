using Controleur.Commun;
using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Cuisine
{
    public class MainChef : Actor
    {
        public MainChef(string name) : base(name)
        {
            this.mapAct.Add("isDishAchievable", new IsDishAchievable());
            this.mapAct.Add("AuthorizeOrder", new AuthorizeOrder());
            this.mapAct.Add("RefuseOrder", new RefuseOrder());
            this.mapAct.Add("FindDishSimilarities", new FindDishSimilarities());
        }

        public void Action(String choice, OrderTable orderTbl, Storage stor)
        {
            switch (choice)
            {
                case "isDishAchievable":
                    if (this.mapAct["IsDishAchievable"].boolAct(orderTbl, stor)) //If dish is Achievable
                    {
                        this.mapAct["FindDishSimilarities"].voidAct(orderTbl); //Regroupement des similarités
                        this.mapAct["AuthorizeOrder"].voidAct(orderTbl); //Envoyer en cuisine & autoriser
                    }
                    else
                    {
                        this.mapAct["RefuseOrder"].voidAct();
                    }
                    break;
                case "CheckClock":
                    this.checkTime();
                    break;
                default:
                    //Do nothing ?
                    break;
            }
        }

    }
}
