using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ATMMachine
    {
        public ATMState CurrentState { get; set; }
        public ATMMachine(ATMState _state)
        {
             CurrentState = _state;
        }
        
        public void SubmitForRequest()
        {
            CurrentState.ProcessState(this);
        }
    }
}
