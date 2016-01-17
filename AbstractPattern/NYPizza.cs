using System;

namespace AbstractPattern
{
    public class NYPizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("Baking it in NY style");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting it in NY style");
        }

        public override void Pack()
        {
            Console.WriteLine("Packing it in NY style");
        }

        public override void Prepare()
        {
            Console.WriteLine("Prepare it in NY style");
        }
    }
}
