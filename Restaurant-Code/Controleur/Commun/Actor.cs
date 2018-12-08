using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Controleur.Commun
{
    public abstract class Actor : IAgir, IActor
    {

        private string name;
        private IAgir act;
        private int number;

        public void agir()
        {
            throw new NotImplementedException();
        }

        public void checkTime()
        {
            throw new NotImplementedException();
        }

        public int intAgir()
        {
            throw new NotImplementedException();
        }


        //start the Thrad <==> implements Runnable in Java
        public void threadStart()
        {
            ThreadStart threadDelegate = new ThreadStart(this.agir);
            Thread newThread = new Thread(threadDelegate);
            newThread.Start();
        }

    }

}