using Controleur.Commun.Interfaces;
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
    public class CleanKitchenware
    {
        public void act(WashingKitchenTools washmachine, QueueKitchenTools queueKitchenToolsList)
        {
            washmachine.addToWash(queueKitchenToolsList); //Ajoute le plus possible d'élements dans la machine pour laver
            if (!washmachine.isRunning) //Si elle n'est pas en cours d'exécution
            {
                washmachine.wash(); //Le cuisinier lance ensuite la machine à laver
            } //Sinon il reesayera la prochaine fois qu'il reçoit de la vaisselle
        }
    }
}
