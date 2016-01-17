using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class PINInsertedState : ATMState
    {
        public PINInsertedState()
        {
            
        }
        public override void ProcessState(ATMMachine machine)
        {
            Console.WriteLine("Pin inserted state");
            machine.CurrentState = new MoneyWithdrawnState();
        }
    }
}
