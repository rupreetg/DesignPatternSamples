using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Expresso : Coffee
    {
        public override int GetCost()
        {
            return 10;
        }

        public override string GetDescription()
        {
            return "Black Coffee";
        }
    }
}
