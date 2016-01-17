using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ATMMachine machine = new ATMMachine(new CardNotInsertedState());
            machine.SubmitForRequest();
            machine.SubmitForRequest();
            machine.SubmitForRequest();
            machine.SubmitForRequest();
            machine.SubmitForRequest();
        }
    }
}
