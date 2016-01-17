using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class Coffee : Beverage
    {
        public Coffee()
        {
            Console.WriteLine("Preparing Coffee");
        }

        protected override void AddFlavors()
        {
            Console.WriteLine("Adding Milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brew Coffee");
        }
    }
}
