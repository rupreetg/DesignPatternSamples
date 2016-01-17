using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Order a Latte with Cream
            Coffee latteWithCream = new Latte();
            latteWithCream = new WhipCream(latteWithCream);
            Console.WriteLine(latteWithCream.GetDescription() + " at $" + latteWithCream.GetCost());

            //Order an Expresso with Caramel and Cream
            Coffee expressoWithCaramelAndCream = new Expresso();
            expressoWithCaramelAndCream = new WhipCream(expressoWithCaramelAndCream);
            expressoWithCaramelAndCream = new Caramel(expressoWithCaramelAndCream);
            Console.WriteLine(expressoWithCaramelAndCream.GetDescription() + " at $" + expressoWithCaramelAndCream.GetCost());
        }
    }
}
