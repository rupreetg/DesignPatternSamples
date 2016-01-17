using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class Beverage
    {
        protected void BoilWater()
        {
            Console.WriteLine("Water is Boiling");
        }

        protected abstract void Brew();

        protected void PourInCup()
        {
            Console.WriteLine("Pouring in cup");
        }

        protected abstract void AddFlavors();

        public void PrepareBeverage()
        {
            BoilWater();

            Brew();

            PourInCup();

            AddFlavors();
        }
    }
}
