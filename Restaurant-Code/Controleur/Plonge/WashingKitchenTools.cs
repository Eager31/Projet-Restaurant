using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Plonge
{
    public abstract class WashingKitchenTools : WashMachine
    {
        public WashingKitchenTools(int washTime, int maxToolNumber, string name) : base(washTime, maxToolNumber, name)
        {

        }
        public void addToWash(QueueKitchenTools qkt)
        {
            Boolean tmp = false;
            while (tmp == false)
            {
                foreach (KitchenTool tool in qkt.KitchenToolsQueue)
                {
                    if (!this.ToolsToWash.Any()) { this.ToolsToWash.Add(tool); } //premier passage
                    if (this.ToolsToWash.Count <= this.MaxToolNumber)
                    {
                        this.ToolsToWash.Add(tool);
                        //retirer de la queue 
                        qkt.KitchenToolsQueue.Remove(tool);
                    }
                    else //isFull
                    {
                        return;
                    }
                    if (!qkt.KitchenToolsQueue.Any()){ tmp = true; } //Si la queue est vide
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
                foreach (KitchenTool tw in ToolsToWash)
                {
                    tw.Type = EnumKitchen.KitchenToolsType.OK;
                }
            endWash();
            this.IsRunning = false;
        }
        
        }  
}
