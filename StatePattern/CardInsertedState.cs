using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class CardInsertedState : ATMState
    {
        public CardInsertedState()
        {
            

        }
        public override void ProcessState(ATMMachine machine)
        {
            Console.WriteLine("Card Inserted State");
            machine.CurrentState = new PINInsertedState();
        }
    }
}
