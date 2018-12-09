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
        private List<RoomStuff> roomToolsQueue;

        public QueueRoomStuff()
        {
            this.RoomToolsQueue = new List<RoomStuff>(); 
        }

        public List<RoomStuff> RoomToolsQueue { get => roomToolsQueue; set => roomToolsQueue = value; }
    }
}
