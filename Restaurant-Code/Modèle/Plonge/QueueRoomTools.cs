using Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Plonge
{
    public class QueueRoomTools //must extends Obserer
    {
        private List<KitchenTool> roomToolsQueue; //Must be List<KitchenRoom>

        public QueueRoomTools()
        {
            this.RoomToolsQueue = new List<KitchenTool>(); //Must be List<KitchenRoom>
        }

        public List<KitchenTool> RoomToolsQueue { get => roomToolsQueue; set => roomToolsQueue = value; }
    }
}
