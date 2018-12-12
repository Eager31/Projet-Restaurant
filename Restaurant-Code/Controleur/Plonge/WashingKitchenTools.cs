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
                foreach (KitchenTool tool in qkt.kitchenToolsQueue)
                {
                    if (!this.toolsToWash.Any()) { this.toolsToWash.Add(tool); } //premier passage
                    if (this.toolsToWash.Count <= this.maxToolNumber)
                    {
                        this.toolsToWash.Add(tool);
                        //retirer de la queue 
                        qkt.kitchenToolsQueue.Remove(tool);
                    }
                    else //isFull
                    {
                        return;
                    }
                    if (!qkt.kitchenToolsQueue.Any()){ tmp = true; } //Si la queue est vide
                    break;
                }
            }
        }

        //supprime les élements pour réimplémenter plus tard
        public void endWash()
        {
            toolsToWash.Clear();
        }

        public override void wash()
        {
            this.isRunning = true;
            if (!toolsToWash.Any()) { return; } //Liste vide ou moins d'élements que prévu ==> Arrêt machine (même si durée ne change pas)
                foreach (KitchenTool tw in toolsToWash)
                {
                    tw.type = EnumKitchen.KitchenToolsType.OK;
                }
            endWash();
            this.isRunning = false;
        }
        
        }  
}
