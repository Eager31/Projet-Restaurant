using Modèle.Cuisine;
using Modèle.Room;
using Modèle.Room.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Plonge
{
    public abstract class WashingRoomTools : WashMachine
    {
        public WashingRoomTools(int washTime, int maxToolNumber, string name) : base(washTime, maxToolNumber, name)
        {

        }

        public void addToWash(QueueRoomStuff qrs)
        {
            Boolean tmp = false;
            while (tmp == false)
            {
                foreach (RoomStuff tool in qrs.roomToolsQueue)
                {
                    if (!this.toolsToWash.Any()) { this.toolsToWash.Add(tool); } //premier passage
                    if (this.toolsToWash.Count <= this.maxToolNumber)
                    {
                        this.toolsToWash.Add(tool);
                        //retirer de la queue 
                        qrs.roomToolsQueue.Remove(tool);
                    }
                    else //isFull
                    {
                        return;
                    }
                    if (!qrs.roomToolsQueue.Any()) { tmp = true; } //Si la queue est vide
                    break;
                }
            }
        }

        //supprime les élements pour réimplémenter plus tard
        public void endWash()
        {
            toolsToWash.Clear();
        }

        public void wash()
        {
            this.isRunning = true;
            if (!toolsToWash.Any()) { return; } //Liste vide ou moins d'élements que prévu ==> Arrêt machine (même si durée ne change pas)
            foreach (RoomStuff tw in toolsToWash)
            {
                tw.Type = EnumRoom.MaterialState.OK;
            }
            endWash();
            this.isRunning = false;
        }

    }
}




