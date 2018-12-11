using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.Actions
{
    public class CleanTableware
    {
        public void act(WashingRoomTools washmachine, QueueRoomStuff queueRoomStuff)
        {
            washmachine.addToWash(queueRoomStuff); //Ajoute le plus possible d'élements dans la machine pour laver
            if (!washmachine.isRunning) //Si elle n'est pas en cours d'exécution
            {
                washmachine.wash(); //Le cuisinier lance ensuite la machine à laver
            } //Sinon il reesayera la prochaine fois qu'il reçoit de la vaisselleinon il reesayera la prochaine fois qu'il reçoit de la vaisselle
        }
    }
}
