using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Coffee
    {
        public abstract string GetDescription();

        public abstract int GetCost();   
    }
}
