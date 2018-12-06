using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Temps
{
    interface IClock
    {
        DateTime getTime();
        void setTime(DateTime time);
        void pause();
        void resume();
        void accelerate(int fast);
    }
}
