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
    public class CleanTable // : IAct
    {
        public List<string> elementToClean = new List<string> { };
        // TODO: Need to use thread and locks
        public void voidAct(ElementTable table) // Clean all the Element
        {
            int numberOfClient = table.chairAmount; // Number of client at table
            int moveNeeded = (numberOfClient / 5) + 1; // Number of move between room and kitchen needed
            table.bread = null;
            table.card = null;
            table.glass = null;
            table.jug = null;
            table.plate = null;
            table.tablecloth = null;
            table.towel = null;

            elementToClean.Add("bread");
            elementToClean.Add("jug");
            elementToClean.Add("tablecloth");

            for (int i = 0; i < numberOfClient; i++) // Add in list all elements
            {
                elementToClean.Add("plate");
                elementToClean.Add("card");
                elementToClean.Add("glass");
                elementToClean.Add("towel");
            }
            for (int i = 0; i < moveNeeded; i++) // Carry 5 items to kitchen and loop until done
            {
                // Call Socket here
            }
        }
    }
}
