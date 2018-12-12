using Modèle.Cuisine;
using Modèle.Plonge;
using Modèle.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public class BringMenu //: IAct
    {
        // TODO : Need to use thread
        public void voidAct(ElementTable table, Card card) // Bring the menu to the client
        {
            table.card = card; // Add the card to the table

            // If we want to remove the card from stock we can do something like that :
            /*
                int cardToRemove = table.chairAmount
                RemoveCardFromStock(cardToRemove)
            */
        }
    }
}
