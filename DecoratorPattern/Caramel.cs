using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Caramel : CoffeeAddons
    {
        private Coffee coffee;

        public Caramel(Coffee _coffee)
        {
            coffee = _coffee;
        }

        public override int GetCost()
        {
            return coffee.GetCost() + 4;
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Caramel";
        }
    }
}
