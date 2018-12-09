using Controleur.Commun;
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

        public void Action(String choice)
        {
            switch (choice)
            {
                case "isDishAchievable":
                    if (this.mapAct["IsDishAchievable"].boolAct()) //If dish is Achievable
                    {
                        this.mapAct["FindDishSimilarities"].voidAct(); //Regroupement des similarités
                        this.mapAct["AuthorizeOrder"].voidAct(); //Envoyer en cuisine & autoriser
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
