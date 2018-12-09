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
                foreach (RoomStuff tool in qrs.RoomToolsQueue)
                {
                    if (!this.ToolsToWash.Any()) { this.ToolsToWash.Add(tool); } //premier passage
                    if (this.ToolsToWash.Count <= this.MaxToolNumber)
                    {
                        this.ToolsToWash.Add(tool);
                        //retirer de la queue 
                        qrs.RoomToolsQueue.Remove(tool);
                    }
                    else //isFull
                    {
                        return;
                    }
                    if (!qrs.RoomToolsQueue.Any()) { tmp = true; } //Si la queue est vide
                    break;
                }
            }
        }

        //supprime les élements pour réimplémenter plus tard
        public void endWash()
        {
            ToolsToWash.Clear();
        }

        public void wash()
        {
            this.IsRunning = true;
            if (!ToolsToWash.Any()) { return; } //Liste vide ou moins d'élements que prévu ==> Arrêt machine (même si durée ne change pas)
            foreach (RoomStuff tw in ToolsToWash)
            {
                tw.Type = EnumRoom.MaterialState.OK;
            }
            endWash();
            this.IsRunning = false;
        }

    }
}




