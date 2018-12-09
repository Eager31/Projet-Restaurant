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
        public List<KitchenTool> kitchenToolsQueue { get; set; }

        public QueueKitchenTools()
        {
            this.kitchenToolsQueue = new List<KitchenTool>();
        }
        
    }
}
