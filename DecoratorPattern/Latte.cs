using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Latte : Coffee
    {
        public override int GetCost()
        {
            return 15;
        }

        public override string GetDescription()
        {
            return "Latte"; 
        }
    }
}
