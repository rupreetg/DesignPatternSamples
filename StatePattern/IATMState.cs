using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class ATMState
    {
        //public ATMMachine AtmMachine
        //{
        //    get; set;
        //}
        public abstract void ProcessState(ATMMachine machine);
    }
}
