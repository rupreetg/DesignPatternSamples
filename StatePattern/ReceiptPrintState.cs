using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ReceiptPrintState : ATMState
    {
        
        public ReceiptPrintState()
        {
            
        }
        public override void ProcessState(ATMMachine machine)
        {
            Console.WriteLine("receipt print state");
        }
    }
}
