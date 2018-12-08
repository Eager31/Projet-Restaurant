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
    public abstract class WashingRoomTools
    {
        private int washTime;
        private int maxNumber;
        
        public WashingRoomTools(int washTime, int maxNumber)
        {
            this.WashTime = washTime;
            this.MaxNumber = maxNumber;
        }

        public int WashTime { get => washTime; set => washTime = value; }
        public int MaxNumber { get => maxNumber; set => maxNumber = value; }

        public int wash(List<RoomStuff> roomStuffList)
        {
            int cpt = MaxNumber;
            while (cpt >= 0)
            {
                if (!roomStuffList.Any()) { return 0; } //Liste vide ou moins d'élements que prévu ==> Arrêt machine (même si durée ne change pas)
                foreach (RoomStuff kt in roomStuffList) //c'est pas très beau :( mais ça marche :)
                {
                    //vérification que le materiel est bien sale
                    if (kt.Equals(EnumRoom.MaterialState.Dirt))
                    {
                        roomStuffList.Remove(kt);
                        cpt--;
                    }
                    break;
                }
            }
            return 1; 
        }
    }
}

