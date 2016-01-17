
namespace AbstractPattern
{
    public class NYPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "cheese":
                    return new NYPizza();
                case "pepproni":
                    return null;
                default:
                    return null;
            }
        }
    }
}
