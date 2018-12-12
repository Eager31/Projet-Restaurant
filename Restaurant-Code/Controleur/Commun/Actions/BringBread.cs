using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using Modèle.Room.Element;

namespace Controleur.Commun
{
    public class BringBread //: IAct
    {
         // TODO : Need to take care of the DateBase and of the thread lock
        public void voidAct(ElementTable table, EnumRoom.BreadType type = EnumRoom.BreadType.White) // Bring bread
        {
            ElementBread bread = new ElementBread(type, EnumRoom.MaterialState.OK); // Create a new bread
            table.bread = bread; // Add the bread to the table
            //Bread in database --
        }
    }
}
