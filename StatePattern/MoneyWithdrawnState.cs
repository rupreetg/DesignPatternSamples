using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class MoneyWithdrawnState : ATMState
    {
        public MoneyWithdrawnState()
        {
            
        }
        public override void ProcessState(ATMMachine machine)
        {
            Console.WriteLine("Money withdrawn state");
            machine.CurrentState = new ReceiptPrintState();
        }
    }
}
