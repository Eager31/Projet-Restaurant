using Modèle.Cuisine;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Plonge
{
    public class QueueRoomStuff //must extends Obserer
    {
        public List<RoomStuff> roomToolsQueue { get; set; }

        public QueueRoomStuff()
        {
            this.roomToolsQueue = new List<RoomStuff>(); 
        }
        
    }
}
