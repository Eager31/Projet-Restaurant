using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public class BringMealToCounter
    {
       public Counter act(Tuple<List<Dish>, int> tupleCommand, Counter c)
        {
           
            if (c != null){ //Pour ne pas casser les ancients tests
                while (tupleCommand.Item1.Any()) //Tant qu'on a pas placé tous les plats sur le comptoir
                {
                    while (c.isTabFull()) //Si le comptoir est plein à craquer
                    {
                        //wait que le serveur prenne des plats
                    }

                    for (int i = 0; i < c.tabDish.Length; i++) //On place un élement
                    {
                        if (c.tabDish[i] == null) //Un espace vide
                        {
                            foreach (Dish myDish in tupleCommand.Item1)
                            {
                                c.tabDish[i] = myDish; //Association du plat
                                c.tableNumber[i] = tupleCommand.Item2; //Numéro de table
                                tupleCommand.Item1.Remove(myDish);
                                break; //On sort d'ici pour ne pas casser le foreach
                            }
                        }
                    }
                }
                    //On alerte le serveur tous les plats de la même table sont placés sur le comptoir (notre commande = liste)
                    //HERE
            }
            return c; //On retorune le comptoir pour tester
        }
    }
}
