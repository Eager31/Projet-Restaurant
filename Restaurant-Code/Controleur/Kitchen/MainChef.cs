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
                    IsDishAchievable isDishAchievable = (IsDishAchievable)this.mapAct["IsDishAchievable"];
                    if (isDishAchievable.act(orderTbl, stor)) //If dish is Achievable
                    {
                        FindDishSimilarities findDishSimilarities = (FindDishSimilarities) this.mapAct["FindDishSimilarities"];
                        findDishSimilarities.act(orderTbl); //Regroupement des similarités
                        AuthorizeOrder authorizeOrder = (AuthorizeOrder)this.mapAct["AuthorizeOrder"];
                        authorizeOrder.act(orderTbl); //Envoyer en cuisine & autoriser
                    }
                    else
                    {
                        RefuseOrder refuseOrder = (RefuseOrder)this.mapAct["RefuseOrder"];
                        refuseOrder.act(orderTbl);
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
