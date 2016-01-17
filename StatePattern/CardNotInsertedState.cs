using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class CardNotInsertedState : ATMState
    {
        public CardNotInsertedState()
        {
            
        }

        public override void ProcessState(ATMMachine machine)
        {
            Console.WriteLine("Card Not Inserted State");
            machine.CurrentState = new CardInsertedState();    
        }


    }
}
