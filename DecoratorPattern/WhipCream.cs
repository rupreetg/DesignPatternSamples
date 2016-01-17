using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class WhipCream : CoffeeAddons
    {
        private Coffee coffee;
        public WhipCream(Coffee _coffee)
        {
            coffee = _coffee;
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Whip Cream";
        }

        public override int GetCost()
        {
            return coffee.GetCost() + 2;
        }
    }
}
