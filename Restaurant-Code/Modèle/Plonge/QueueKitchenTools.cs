using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Plonge
{
    public class QueueKitchenTools //must extends Obserer
    {
        private List<KitchenTool> kitchenToolsQueue;

        public QueueKitchenTools()
        {
            this.KitchenToolsQueue = new List<KitchenTool>();
        }

        public List<KitchenTool> KitchenToolsQueue { get => kitchenToolsQueue; set => kitchenToolsQueue = value; }
    }
}
