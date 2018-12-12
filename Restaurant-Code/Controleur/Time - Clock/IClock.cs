using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Temps
{
    interface IClock
    {
        void Start();                           // Start the tick count incrementation
        void Stop();                            // Stop the tick count from incrementing
        void Reset();                           // Set tick count to 0
        void Warp(int multiplier);              // Modify ticker speed
        void Tick(object sender, EventArgs e);  // Increment tick count
        long GetTickCount();                    // Retrun the tick count (getter for the "tickCount" attribute)

    }
}
