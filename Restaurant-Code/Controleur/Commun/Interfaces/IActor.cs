using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public interface IActor
    {
        void checkTime();
        void threadStart();
        void action();
    }
}
