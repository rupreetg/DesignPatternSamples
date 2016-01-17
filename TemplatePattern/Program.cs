using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage tea = new Tea();
            tea.PrepareBeverage();

            Console.WriteLine("-----------------");

            Beverage coffee = new Coffee();
            coffee.PrepareBeverage();
        }
    }
}
