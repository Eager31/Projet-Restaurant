using Modèle.Plonge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun.Interfaces
{
    public interface IVoidActWithMachineAndQrStuff
    {
        void act(WashMachine washMachine, QueueRoomStuff queueRoomStuff);
    }
}
