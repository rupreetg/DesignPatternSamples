using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class Tea : Beverage
    {
        public Tea()
        {
            Console.WriteLine("Preparing Tea");
        }
        protected override void AddFlavors()
        {
            Console.WriteLine("Adding lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Add Tea");
        }
    }
}
